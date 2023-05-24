using DirectoryFilesForEver.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryFilesForEver
{
    public partial class ModifNom : Form
    {
        String ruta, rutafinal, nom, nouNom, tipus;
        List<Element> contingut;
        Boolean afegir;

        public ModifNom(String path, String name, String type ,List<Element> content)
        {
            InitializeComponent();
            ruta = @path;
            nom = name;
            tipus = type;
            contingut = content;
        }

        private void ModifNom_Load(object sender, EventArgs e)
        {
            textBoxNom.Text = nom;
        }

        //Modifica el nom d'un fitxer o directori al directori seleccionat amb el nom que s'indica al textBox
        //utilitzant les funcions ModifDir() i ModifFitx()
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            afegir = true;
            nouNom = textBoxNom.Text;

            if (tipus == "Directori")
            {
                ModifDir();
            }
            else if (tipus == "Arxiu")
            {
                ModifFitx();
            }
            else if (textBoxNom.Text == "")
            {
                MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Comproba que el nom que hem escollit no existeixi ja, si existeix se li afegeix un sufix " (n)" sent n
        //un número que incrementarà fins que trobi un nom disponible. Un cop trobat es modifica
        //el nom del subdirectori
        private void ModifDir()
        {
            int contador = 1;
            rutafinal = ruta + "\\" + textBoxNom.Text;
            do
            {
                afegir = true;

                foreach (Element element in contingut)
                {
                    if (element.nom == nouNom)
                    {
                        afegir = false;
                    }
                    if(nom == nouNom)
                    {
                        afegir = true;
                    }
                }

                if (afegir)
                {
                    try
                    {
                        afegir = true;
                        Directory.Move(ruta + "\\" + nom, rutafinal);
                        this.Close();
                    }
                    catch (System.ArgumentException)
                    {
                        afegir = true;
                        MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.IO.IOException)
                    {
                        this.Close();
                    }
                }
                else
                {
                    rutafinal = ruta + "\\" + nouNom + " (" + contador.ToString() + ")";
                    nouNom = textBoxNom.Text + " (" + contador.ToString() + ")";
                    contador++;
                }
            } while (!afegir);
        }

        //Comproba que el nom que hem escollit no existeixi ja, si existeix se li afegeix un sufix " (n)" sent n
        //un número que incrementarà fins que trobi un nom disponible. Un cop trobat es modifica
        //el nom de l'arxiu
        private void ModifFitx()
        {
            int contador = 1;
            rutafinal = ruta + "\\" + textBoxNom.Text;

            do
            {
                afegir = true;

                foreach (Element element in contingut)
                {
                    if (element.nom == nouNom)
                    {
                        afegir = false;
                    }
                    if (nom == nouNom)
                    {
                        afegir = true;
                    }
                }

                if (afegir)
                {
                    try
                    {
                        afegir = true;
                        File.Move(ruta + "\\" + nom, rutafinal);
                        this.Close();
                    }
                    catch (System.ArgumentException)
                    {
                        afegir = true;
                        MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (System.IO.IOException)
                    {
                        this.Close();
                    }
                }
                else
                {
                    rutafinal = ruta + "\\" + nouNom + " (" + contador.ToString() + ")";
                    nouNom = textBoxNom.Text + " (" + contador.ToString() + ")";
                    contador++;
                }
            } while (!afegir);
        }
    }
}
