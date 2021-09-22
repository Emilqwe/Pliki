using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pliki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void otworz_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog Dialog = new OpenFileDialog();
            
            Dialog.InitialDirectory = "C:\\";
            Dialog.Title = "Open text files";
            Dialog.Filter = "Text files *.txt|*.txt|All files *.*|*.*";
            Dialog.FilterIndex = 1;
            Dialog.RestoreDirectory = true;
            try
            {
                if (Dialog.ShowDialog() == DialogResult.OK)
                {

                    if ((myStream = Dialog.OpenFile()) != null)
                    {
                        using (var reader = new StreamReader(Dialog.FileName))
                        {
                            string linia;
                            while ((linia = reader.ReadLine()) != null)
                            {
                                wyswietl.Text += linia;
                                wyswietl.AppendText(Environment.NewLine);
                                myStream.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        private void zapisz_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.InitialDirectory = "C:\\";      
            saveDialog.Title = "Save text Files";
            saveDialog.CheckFileExists = true;
            saveDialog.CheckPathExists = true;
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Text files *.txt|*.txt|All files *.*|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, wyswietl.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not save file to disk. Original error: " + ex.Message);
            }
        }
    }
}
