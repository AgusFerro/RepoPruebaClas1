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
using IO;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            barraDeEstado.Text = $"{richTextBox1.Text.Length}  caracteres";
        }

        private void archivoMenuAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            open.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                path = open.FileName;
                if (open.DefaultExt == "dat")
                {
                    PuntoDat pd = new PuntoDat();
                    pd.Contenido = richTextBox1.Text;
                    pd.Leer(path);
                }
                else if(open.DefaultExt == "txt")
                {
                    PuntoTxt pt = new PuntoTxt();
                    pt.Leer(path);
                }
                else
                {
                    MessageBox.Show("Error","Elija otro formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                /*path = open.FileName;
                StreamReader sr = new StreamReader(open.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();*/
            }
        }

        private void archivoMenuGuardar_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                
            }
            /*if (File.Exists(path))
            { 
                StreamWriter sw = new StreamWriter(path);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
            else
            {
                archivoMenuGuardarComo_Click(sender,e);
            }*/
        }

        private void archivoMenuGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            save.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                if (save.DefaultExt == "dat")
                {
                    PuntoDat pd = new PuntoDat();
                    pd.Contenido = richTextBox1.Text;
                    pd.GuardarComo(path,pd);
                }
                /*StreamWriter sw = new StreamWriter(save.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();*/
            }
        }
    }
}
