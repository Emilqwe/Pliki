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
        Stream myStream = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void otworz_Click(object sender, EventArgs e)
        {
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

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog1.Font = wyswietl2.Font;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                wyswietl2.Font = fontDialog1.Font;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.InitialDirectory = "C:\\";
            saveDialog.Title = "Save text Files";
            saveDialog.CheckFileExists = true;
            saveDialog.CheckPathExists = true;
            saveDialog.DefaultExt = "txt";
            saveDialog.Filter = "Text files *.txt|*.txt|All files *.*|*.*|Rich Text Format *.rtf|*.rtf";
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

        private void kolor_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Color = wyswietl2.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                wyswietl2.ForeColor = fontDialog1.Color;
            }
        }

        private void grubosc_Click(object sender, EventArgs e)
        {
            int start = wyswietl2.SelectionStart;
            int dlugosc = wyswietl2.SelectionLength;

            wyswietl2.SelectionFont = new Font(wyswietl2.Font, FontStyle.Bold);

            
            wyswietl2.SelectionStart = wyswietl2.SelectionStart + wyswietl2.SelectionLength;
            wyswietl2.SelectionLength = 0;

            wyswietl2.SelectionFont = wyswietl2.Font;

            wyswietl2.Select(start, dlugosc);
        }

        private void pochylnosc_Click(object sender, EventArgs e)
        {
                 int start = wyswietl2.SelectionStart;
                 int dlugosc = wyswietl2.SelectionLength;

                 wyswietl2.SelectionFont = new Font(wyswietl2.Font, FontStyle.Italic);
       
                 wyswietl2.SelectionStart = wyswietl2.SelectionStart + wyswietl2.SelectionLength;
                 wyswietl2.SelectionLength = 0;

                 wyswietl2.SelectionFont = wyswietl2.Font;

                 wyswietl2.Select(start, dlugosc);
        }

        private void podkreslenie_Click(object sender, EventArgs e)
        {
            int start = wyswietl2.SelectionStart;
            int dlugosc = wyswietl2.SelectionLength;

            wyswietl2.SelectionFont = new Font(wyswietl2.Font, FontStyle.Underline);

            wyswietl2.SelectionStart = wyswietl2.SelectionStart + wyswietl2.SelectionLength;
            wyswietl2.SelectionLength = 0;

            wyswietl2.SelectionFont = wyswietl2.Font;

            wyswietl2.Select(start, dlugosc);
        }

        private void przekreslenie_Click(object sender, EventArgs e)
        {
            int start = wyswietl2.SelectionStart;
            int dlugosc = wyswietl2.SelectionLength;

            wyswietl2.SelectionFont = new Font(wyswietl2.Font, FontStyle.Strikeout);

            wyswietl2.SelectionStart = wyswietl2.SelectionStart + wyswietl2.SelectionLength;
            wyswietl2.SelectionLength = 0;

            wyswietl2.SelectionFont = wyswietl2.Font;

            wyswietl2.Select(start, dlugosc);
        }
    }
}
