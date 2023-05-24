using DirectoryFilesForEver.Clases;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace DirectoryFilesForEver
{
    public partial class DirectoryFilesForever : Form
    {
        DirectoryInfo directoriactual;
        Boolean json = false;
        List<Element> subdirectoris = new List<Element>();
        List<Element> fitxers = new List<Element>();
        List<Element> subdirfitx = new List<Element>();
        List<Element> jsonelements = new List<Element>();
        List<Element> elementsReferencia = new List<Element>();

        DateTime Abans;
        DateTime Despres;

        public DirectoryFilesForever()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxVeure.SelectedIndex = 0;
            comboBoxOrdenar.SelectedIndex = 0;
            dateTimePickerAbansData.Value = DateTime.Today;
            dateTimePickerAbansTemps.Value = DateTime.Now;
        }


        /*
        Obre el File Dialog i ens proporciona la ruta del directori amb que es treballarà
        Es generen les llistes i es mostra
        */
        private void obrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            json = false;    
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                labelRuta.Text = dialog.FileName;
                directoriactual = new DirectoryInfo(labelRuta.Text);

                getDadesReferencia();
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
        }

        /*
        Obre el File Dialog i permet guardar les dades del directori actual amb els filtres 
        aplicats en un arxiu json
        */
        private void guardarJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelRuta.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                String nom;

                saveFileDialog.Filter = "json files (*.json)|*.json";
                saveFileDialog.FilterIndex = 0;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    nom = saveFileDialog.FileName;

                    if (comboBoxVeure.Text == "Tot")
                    {
                        ManageJson.Escribir(subdirfitx, nom);
                    }
                    else if (comboBoxVeure.Text == "Arxius")
                    {
                        ManageJson.Escribir(fitxers, nom);
                    }
                    else
                    {
                        ManageJson.Escribir(subdirectoris, nom);
                    }
                    MessageBox.Show("Arxiu guardat correctament", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No has seleccionat cap ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }

        /*
        Obre el File Dialog i permet llegir un arxiu json amb el mateix format que la classe Element i 
        en representa les dades a la dataGridView. En aquest mode no es poden crear, borrar ni modificar noms
        d'arxius ja que el json es tracta com una fotografía d'un moment en concret que es voldrà guardar sense 
        que es pugui alterar
        */
        private void llegirJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            json = true;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.Filters.Add(new CommonFileDialogFilter("Arxius json", "json"));

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                labelRuta.Text = "ARXIU JSON   " + dialog.FileName;
                jsonelements = ManageJson.Leer(dialog.FileName);

                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
        }


        /*
        Eines de selecció de les diferents formes de mostrar el contingut del directori escollit
        dins del DataGridView
        */
        //Mostrar DIrectoris, arxius o els dos
        private void comboBoxVeure_SelectedIndexChanged(object sender, EventArgs e) 
        {
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }

        //Ordenar per nom, tipus o data de creació
        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }

        //Canviar entre ascendent o descendent
        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }


        /*
        Eines de filtratge de les dades que previament hem mostrat dins del DataGridView
        */
        //Filtra per el nom, primer activa el filtratge amb el chechbox i després filtra en viu amb el textBox
        private void checkBoxNom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNom.Checked)
            {
                textBoxNom.Enabled = true;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
            else
            {
                textBoxNom.Enabled = false;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
        }
        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }

        //Filtra per data de creació, primer activa el filtratge amb el chechbox i després filtra en viu amb els dateTimePicker
        //Després de:
        private void checkBoxCreatDespres_CheckedChanged(object sender, EventArgs e)
        {
            Despres = dateTimePickerDespresData.Value.Date.Add(dateTimePickerDespresTemps.Value.TimeOfDay);

            if (checkBoxCreatDespres.Checked)
            {
                dateTimePickerDespresData.Enabled = true;
                dateTimePickerDespresTemps.Enabled = true;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
            else
            {
                dateTimePickerDespresData.Enabled = false;
                dateTimePickerDespresTemps.Enabled = false;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
        }
        private void dateTimePickerDespresData_ValueChanged(object sender, EventArgs e)
        {
            Despres = dateTimePickerDespresData.Value.Date.Add(dateTimePickerDespresTemps.Value.TimeOfDay);
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }
        private void dateTimePickerDespresTemps_ValueChanged(object sender, EventArgs e)
        {
            Despres = dateTimePickerDespresData.Value.Date.Add(dateTimePickerDespresTemps.Value.TimeOfDay);
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }
        //Abans de:
        private void checkBoxCreatAbans_CheckedChanged(object sender, EventArgs e)
        {
            Abans = dateTimePickerAbansData.Value.Date.Add(dateTimePickerAbansTemps.Value.TimeOfDay);

            if (checkBoxCreatAbans.Checked)
            {
                dateTimePickerAbansData.Enabled = true;
                dateTimePickerAbansTemps.Enabled = true;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
            else
            {
                dateTimePickerAbansData.Enabled = false;
                dateTimePickerAbansTemps.Enabled = false;
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
        }
        private void dateTimePickerAbansData_ValueChanged(object sender, EventArgs e)
        {
            Abans = dateTimePickerAbansData.Value.Date.Add(dateTimePickerAbansTemps.Value.TimeOfDay);
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }
        private void dateTimePickerAbansTemps_ValueChanged(object sender, EventArgs e)
        {
            Abans = dateTimePickerAbansData.Value.Date.Add(dateTimePickerAbansTemps.Value.TimeOfDay);
            getDades();
            ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
        }


        /*
        Botóns amb les diferents funcionalitats que tens un cop s'ha escollit un directori
        */
        //Crear un nou directori o fitxer
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            if (labelRuta.Text != "" && !json)
            {
                Crear crear = new Crear(labelRuta.Text, elementsReferencia);
                crear.ShowDialog();
                getDadesReferencia();
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
            else if (json)
            {
                MessageBox.Show("No pots crear cap element ara mateix ja que s'estan mostrant els continguts d'un fitxer json",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No has seleccionat cap ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Borrar el directori o fitxer seleccionat al dataGridView
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            int index;

            if (labelRuta.Text != "" && !json)
            {
                index = dataGridView.CurrentRow.Index;

                if (dataGridView.Rows[index].Cells[1].Value.ToString() == "Directori")
                {

                    DialogResult dr = MessageBox.Show("Estàs segur de que vols eliminar el directori " +
                                dataGridView.Rows[index].Cells[0].Value.ToString() + "?",
                                "Eliminar directori", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dr == DialogResult.Yes)
                    {
                        Directory.Delete(@labelRuta.Text + "\\" + dataGridView.Rows[index].Cells[0].Value.ToString());
                        getDadesReferencia();
                        getDades();
                        ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
                    }
                }
                else if (dataGridView.Rows[index].Cells[1].Value.ToString() == "Arxiu")
                {
                    DialogResult dr = MessageBox.Show("Estàs segur de que vols eliminar l'arxiu " +
                                dataGridView.Rows[index].Cells[0].Value.ToString() + "?",
                                "Eliminar arxiu", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(@labelRuta.Text + "\\" + dataGridView.Rows[index].Cells[0].Value.ToString());
                        getDadesReferencia();
                        getDades();
                        ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
                    }
                }
            }
            else if (json)
            {
                MessageBox.Show("No pots eliminar cap element ara mateix ja que s'estan mostrant els continguts d'un fitxer json",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No has seleccionat cap ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Modificar el nom del directori o fitxer seleccionat al dataGridView
        private void buttonModificarNom_Click(object sender, EventArgs e)
        {
            int index;

            if (labelRuta.Text != "" && !json)
            {
                index = dataGridView.CurrentRow.Index;

                ModifNom modificar = new ModifNom(labelRuta.Text, dataGridView.Rows[index].Cells[0].Value.ToString(),
                    dataGridView.Rows[index].Cells[1].Value.ToString(), elementsReferencia);
                modificar.ShowDialog();
                getDadesReferencia();
                getDades();
                ActualitzarDataGrid(comboBoxVeure.Text, comboBoxOrdenar.Text, radioButtonDesc.Checked);
            }
            else if (json)
            {
                MessageBox.Show("No pots modificar cap element ara mateix ja que s'estan mostrant els continguts d'un fitxer json",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No has seleccionat cap ruta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        /*
          Diferents funcions utilitzades al llarg de tot el codi
        */
        //Crea una List de referència que es farà servir per veure si el nom que volem assignar al JSON ja existeix
        private void getDadesReferencia()
        {
            elementsReferencia.Clear();

            foreach (DirectoryInfo subdir in directoriactual.GetDirectories())
            {
                Element dir = new Element();

                if (generateDir(subdir))
                {
                    dir.nom = subdir.Name;
                    dir.tipus = "Directori";
                    dir.creacio = subdir.CreationTime;
                    elementsReferencia.Add(dir);
                }
            }
            foreach (FileInfo fitx in directoriactual.GetFiles())
            {
                Element arxiu = new Element();

                if (generateFitx(fitx))
                {
                    arxiu.nom = fitx.Name;
                    arxiu.tipus = "Arxiu";
                    arxiu.creacio = fitx.CreationTime;
                    elementsReferencia.Add(arxiu);
                }
            }
        }


        //Funció general que genera totes les llistes que es mostraran al datGridView, es crida cada cop que
        //es modifica o es filtra alguna cosa dins del directori seleccionat
        private void getDades()
        {
            try
            {
                if (labelRuta.Text != "")
                {
                    ObtenirSubdir();
                    ObtenirFitxers();
                    ObtenirSubdirFitx();
                }
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("No tens accés a aquest directori", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        
        //Genera la llista de subdirectoris del directori seleccionat, cada vegada que es filtra o es modifica
        //algún item es regenera la llista tenint en compte els nous criteris, que es comproven amb generateDir()
        private void ObtenirSubdir()
        {
            subdirectoris.Clear();

            if (!json)
            {
                foreach (DirectoryInfo subdir in directoriactual.GetDirectories())
                {
                    Element dir = new Element();

                    if (generateDir(subdir))
                    {
                        dir.nom = subdir.Name;
                        dir.tipus = "Directori";
                        dir.creacio = subdir.CreationTime;
                        subdirectoris.Add(dir);
                    }
                }
            }
            else
            {
                foreach (Element subdir in jsonelements)
                {
                    Element dir = new Element();

                    if (subdir.tipus == "Directori" && generateDirJSON(subdir))
                    {
                        dir.nom = subdir.nom;
                        dir.tipus = "Directori";
                        dir.creacio = subdir.creacio;
                        subdirectoris.Add(dir);
                    }
                }
            }
            
        }

        //Genera la llista d'arxius del directori seleccionat, cada vegada que es filtra o es modifica
        //algún item es regenera la llista tenint en compte els nous criteris, que es comproven amb generateFitx()
        private void ObtenirFitxers()
        {
            fitxers.Clear();

            if (!json)
            {
                foreach (FileInfo fitx in directoriactual.GetFiles())
                {
                    Element arxiu = new Element();

                    if (generateFitx(fitx))
                    {
                        arxiu.nom = fitx.Name;
                        arxiu.tipus = "Arxiu";
                        arxiu.creacio = fitx.CreationTime;
                        fitxers.Add(arxiu);
                    }
                }
            }
            else
            {
                foreach (Element fitx in jsonelements)
                {
                    Element arxiu = new Element();

                    if (fitx.tipus == "Arxiu" && generateFitxJSON(fitx))
                    {
                        arxiu.nom = fitx.nom;
                        arxiu.tipus = "Arxiu";
                        arxiu.creacio = fitx.creacio;
                        fitxers.Add(arxiu);
                    }
                }
            }
            
        }

        //Genera la llista de subdirectoris i arxius (amdós en una mateixa llistadel directori seleccionat,
        //cada vegada que es filtra o es modifica algún item es regenera la llista tenint en compte els
        //nous criteris, que es comproven amb generateDir() i generateFitx()
        private void ObtenirSubdirFitx()
        {
            subdirfitx.Clear();

            if (!json)
            {
                foreach (DirectoryInfo subdir in directoriactual.GetDirectories())
                {
                    Element dir = new Element();

                    if (generateDir(subdir))
                    {
                        dir.nom = subdir.Name;
                        dir.tipus = "Directori";
                        dir.creacio = subdir.CreationTime;
                        subdirfitx.Add(dir);
                    }
                }
            }
            else
            {
                foreach (Element subdir in jsonelements)
                {
                    Element dir = new Element();

                    if (subdir.tipus == "Directori" && generateDirJSON(subdir))
                    {
                        dir.nom = subdir.nom;
                        dir.tipus = "Directori";
                        dir.creacio = subdir.creacio;
                        subdirfitx.Add(dir);
                    }
                }
            }

            if (!json)
            {
                foreach (FileInfo fitx in directoriactual.GetFiles())
                {
                    Element arxiu = new Element();

                    if (generateFitx(fitx))
                    {
                        arxiu.nom = fitx.Name;
                        arxiu.tipus = "Arxiu";
                        arxiu.creacio = fitx.CreationTime;
                        subdirfitx.Add(arxiu);
                    }
                }
            }
            else
            {
                foreach (Element fitx in jsonelements)
                {
                    Element arxiu = new Element();

                    if (fitx.tipus == "Arxiu" && generateFitxJSON(fitx))
                    {
                        arxiu.nom = fitx.nom;
                        arxiu.tipus = "Arxiu";
                        arxiu.creacio = fitx.creacio;
                        subdirfitx.Add(arxiu);
                    }
                }
            }
        }

        //Actualitza el dataGridView amb les llistes, s'acostuma a fer servir després de regenerar-les
        //a les funcions anteriors. Aquí es tenen en compte les diferents opcions de mostrar contingut
        //que s'ha mencionat anteriorment
        private void ActualitzarDataGrid(String llista, String ordre, Boolean descendent)
        {
            dataGridView.DataSource = null;

            if (descendent)
            {
                if (ordre == "Nom")
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderByDescending(a => a.nom).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderByDescending(a => a.nom).ToList();
                    fitxers = (List<Element>)fitxers.OrderByDescending(a => a.nom).ToList();
                }
                else if (ordre == "Tipus")
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderByDescending(a => a.tipus).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderByDescending(a => a.tipus).ToList();
                    fitxers = (List<Element>)fitxers.OrderByDescending(a => a.tipus).ToList();
                }
                else
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderByDescending(a => a.creacio).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderByDescending(a => a.creacio).ToList();
                    fitxers = (List<Element>)fitxers.OrderByDescending(a => a.creacio).ToList();
                }
            }
            else
            {
                if (ordre == "Nom")
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderBy(a => a.nom).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderBy(a => a.nom).ToList();
                    fitxers = (List<Element>)fitxers.OrderBy(a => a.nom).ToList();
                }
                else if (ordre == "Tipus")
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderBy(a => a.tipus).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderBy(a => a.tipus).ToList();
                    fitxers = (List<Element>)fitxers.OrderBy(a => a.tipus).ToList();
                }
                else
                {
                    subdirectoris = (List<Element>)subdirectoris.OrderBy(a => a.creacio).ToList();
                    subdirfitx = (List<Element>)subdirfitx.OrderBy(a => a.creacio).ToList();
                    fitxers = (List<Element>)fitxers.OrderBy(a => a.creacio).ToList();
                }
            }

            if (llista == "Tot")
            {
                dataGridView.DataSource = subdirfitx;
            }
            else if (llista == "Arxius")
            {
                dataGridView.DataSource = fitxers;
            }
            else
            {
                dataGridView.DataSource = subdirectoris;
            }

            dataGridView.Columns[0].HeaderText = "Nom";
            dataGridView.Columns[1].HeaderText = "Tipus";
            dataGridView.Columns[2].HeaderText = "Creació";

        }


        /*Comproba un subdirectori o fitxer del directori seleccionat que es passa com a paràmetre des de les funcións
        de generar les llistes. Es comprova si el directori o fitxer paràmetre compleix les funcions dels filtres 
        seleccionats i si entra dins els criteris es retorna un Boolean que determina si el subdirectori serà afegit 
        a la llista
        */
        //Per els directoris
        private Boolean generateDir(DirectoryInfo subdir)
        {
            Boolean insert = false;

            if (!checkBoxNom.Checked && !checkBoxCreatAbans.Checked && !checkBoxCreatDespres.Checked)
            {
                insert = true;
            }
            else if (checkBoxNom.Checked && checkBoxNom.Text != "")
            {
                if (checkBoxCreatAbans.Checked)
                {
                    if (checkBoxCreatDespres.Checked) //Nom, Abans de, Després de
                    {
                        if (subdir.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > subdir.CreationTime && Despres < subdir.CreationTime)
                        {
                            insert = true;
                        }
                    }
                    else //Nom, Abans de
                    {
                        if (subdir.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > subdir.CreationTime)
                        {
                            insert = true;
                        }
                    }
                }
                else if (checkBoxCreatDespres.Checked) //Nom, Després de
                {
                    if (subdir.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Despres < subdir.CreationTime)
                    {
                        insert = true;
                    }
                }
                else //Nom
                {
                    if (subdir.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()))
                    {
                        insert = true;
                    }
                }
            }
            else if (checkBoxCreatAbans.Checked)
            {
                if (checkBoxCreatDespres.Checked) //Abans de, Després de
                {
                    if (Abans > subdir.CreationTime && Despres < subdir.CreationTime)
                    {
                        insert = true;
                    }
                }
                else //Abans de
                {
                    if (Abans > subdir.CreationTime)
                    {
                        insert = true;
                    }
                }
            }
            else //Després de
            {
                if (Despres < subdir.CreationTime)
                {
                    insert = true;
                }
            }

            return insert;
        }

        //Per els arxius
        private Boolean generateFitx(FileInfo fitx)
        {
            Boolean insert = false;

            if (!checkBoxNom.Checked && !checkBoxCreatAbans.Checked && !checkBoxCreatDespres.Checked)
            {
                insert = true;
            }
            else if (checkBoxNom.Checked && checkBoxNom.Text != "")
            {
                if (checkBoxCreatAbans.Checked)
                {
                    if (checkBoxCreatDespres.Checked) //Nom, Abans de, Després de
                    {
                        if (fitx.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > fitx.CreationTime && Despres < fitx.CreationTime)
                        {
                            insert = true;
                        }
                    }
                    else //Nom, Abans de
                    {
                        if (fitx.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > fitx.CreationTime)
                        {
                            insert = true;
                        }
                    }
                }
                else if (checkBoxCreatDespres.Checked) //Nom, Després de
                {
                    if (fitx.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Despres < fitx.CreationTime)
                    {
                        insert = true;
                    }
                }
                else //Nom
                {
                    if (fitx.Name.ToLower().StartsWith(textBoxNom.Text.ToLower()))
                    {
                        insert = true;
                    }
                }
            }
            else if (checkBoxCreatAbans.Checked)
            {
                if (checkBoxCreatDespres.Checked) //Abans de, Després de
                {
                    if (Abans > fitx.CreationTime && Despres < fitx.CreationTime)
                    {
                        insert = true;
                    }
                }
                else //Abans de
                {
                    if (Abans > fitx.CreationTime)
                    {
                        insert = true;
                    }
                }
            }
            else //Després de
            {
                if (Despres < fitx.CreationTime)
                {
                    insert = true;
                }
            }

            return insert;
        }

        /*Comproba un subdirectori o fitxer del directori seleccionat que es passa com a paràmetre des de les funcións
        de generar les llistes. Es comprova si el directori o fitxer paràmetre compleix les funcions dels filtres 
        seleccionats i si entra dins els criteris es retorna un Boolean que determina si el subdirectori serà afegit 
        a la llista
        */
        //Per els directoris
        private Boolean generateDirJSON(Element subdir)
        {
            Boolean insert = false;

            if (!checkBoxNom.Checked && !checkBoxCreatAbans.Checked && !checkBoxCreatDespres.Checked)
            {
                insert = true;
            }
            else if (checkBoxNom.Checked && checkBoxNom.Text != "")
            {
                if (checkBoxCreatAbans.Checked)
                {
                    if (checkBoxCreatDespres.Checked) //Nom, Abans de, Després de
                    {
                        if (subdir.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > subdir.creacio && Despres < subdir.creacio)
                        {
                            insert = true;
                        }
                    }
                    else //Nom, Abans de
                    {
                        if (subdir.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > subdir.creacio)
                        {
                            insert = true;
                        }
                    }
                }
                else if (checkBoxCreatDespres.Checked) //Nom, Després de
                {
                    if (subdir.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Despres < subdir.creacio)
                    {
                        insert = true;
                    }
                }
                else //Nom
                {
                    if (subdir.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()))
                    {
                        insert = true;
                    }
                }
            }
            else if (checkBoxCreatAbans.Checked)
            {
                if (checkBoxCreatDespres.Checked) //Abans de, Després de
                {
                    if (Abans > subdir.creacio && Despres < subdir.creacio)
                    {
                        insert = true;
                    }
                }
                else //Abans de
                {
                    if (Abans > subdir.creacio)
                    {
                        insert = true;
                    }
                }
            }
            else //Després de
            {
                if (Despres < subdir.creacio)
                {
                    insert = true;
                }
            }

            return insert;
        }

        //Per els arxius
        private Boolean generateFitxJSON(Element fitx)
        {
            Boolean insert = false;

            if (!checkBoxNom.Checked && !checkBoxCreatAbans.Checked && !checkBoxCreatDespres.Checked)
            {
                insert = true;
            }
            else if (checkBoxNom.Checked && checkBoxNom.Text != "")
            {
                if (checkBoxCreatAbans.Checked)
                {
                    if (checkBoxCreatDespres.Checked) //Nom, Abans de, Després de
                    {
                        if (fitx.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > fitx.creacio && Despres < fitx.creacio)
                        {
                            insert = true;
                        }
                    }
                    else //Nom, Abans de
                    {
                        if (fitx.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Abans > fitx.creacio)
                        {
                            insert = true;
                        }
                    }
                }
                else if (checkBoxCreatDespres.Checked) //Nom, Després de
                {
                    if (fitx.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()) &&
                            Despres < fitx.creacio)
                    {
                        insert = true;
                    }
                }
                else //Nom
                {
                    if (fitx.nom.ToLower().StartsWith(textBoxNom.Text.ToLower()))
                    {
                        insert = true;
                    }
                }
            }
            else if (checkBoxCreatAbans.Checked)
            {
                if (checkBoxCreatDespres.Checked) //Abans de, Després de
                {
                    if (Abans > fitx.creacio && Despres < fitx.creacio)
                    {
                        insert = true;
                    }
                }
                else //Abans de
                {
                    if (Abans > fitx.creacio)
                    {
                        insert = true;
                    }
                }
            }
            else //Després de
            {
                if (Despres < fitx.creacio)
                {
                    insert = true;
                }
            }

            return insert;
        }

    }
}
