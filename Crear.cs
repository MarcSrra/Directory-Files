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
    public partial class Crear : Form
    {
        String ruta, rutafinal, nom;
        Boolean afegir;
        List<Element> contingut;

        public Crear(String path, List<Element> content)
        {
            InitializeComponent();
            ruta = @path;
            contingut = content;
        }

        //Es crea un fitxer o directori al directori seleccionat amb el nom que s'indica al textBox
        //utilitzant les funcions CrearDir() i CrearFitx()
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            afegir = true;
            nom = textBoxNom.Text;

            if(textBoxNom.Text != "" && comboBoxTipus.Text == "Directori")
            {
                CrearDir();
            }
            else if(textBoxNom.Text != "" && comboBoxTipus.Text == "Arxiu")
            {
                CrearFitx();
            }
            else if (textBoxNom.Text == "")
            {
                MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(comboBoxTipus.Text == "")
            {
                MessageBox.Show("Selecciona el que vols crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Comproba que el nom que hem escollit no existeixi ja, si existeix se li afegeix un sufix " (n)" sent n
        //un número que incrementarà fins que trobi un nom disponible. Un cop trobat crea un subdirectori nou
        private void CrearDir()
        {
            int contador = 1;
            ruta += "\\" + textBoxNom.Text;
            rutafinal = ruta;

            do
            {
                afegir = true;

                foreach (Element element in contingut)
                {
                    if (element.nom == nom)
                    {
                        afegir = false;
                    }
                }

                if (afegir)
                {
                    try
                    {
                        afegir = true;
                        Directory.CreateDirectory(rutafinal);
                        this.Close();
                    }
                    catch (System.ArgumentException)
                    {
                        afegir = true;
                        MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rutafinal = ruta + " (" + contador.ToString() + ")";
                    nom = textBoxNom.Text + " (" + contador.ToString() + ")";
                    contador++;
                }
            } while (!afegir);
        }

        //Comproba que el nom que hem escollit no existeixi ja, si existeix se li afegeix un sufix " (n)" sent n
        //un número que incrementarà fins que trobi un nom disponible. Un cop trobat es crea un fitxer nou
        private void CrearFitx()
        {
            int contador = 1;
            ruta += "\\" + textBoxNom.Text;
            rutafinal = ruta;

            do
            {
                afegir = true;

                foreach (Element element in contingut)
                {
                    if (element.nom == nom)
                    {
                        afegir = false;
                    }
                }

                if (afegir)
                {
                    try
                    {
                        afegir = true;
                        File.Create(rutafinal);
                        this.Close();
                    }
                    catch (System.ArgumentException)
                    {
                        afegir = true;
                        MessageBox.Show("Nom no vàlid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rutafinal = ruta + " (" + contador.ToString() + ")";
                    nom = textBoxNom.Text + " (" + contador.ToString() + ")";
                    contador++;
                }
            } while (!afegir);
        }
    }
}
