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
            
            Dialog.InitialDirectory = "c:\\";
            Dialog.Title = "Open text files";
            Dialog.Filter = "txt files|*.txt|All files|*.*";
            Dialog.FilterIndex = 2;
            Dialog.RestoreDirectory = true;

            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = Dialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            wyswietl.Text = Dialog.
                        }
                    }
                }
                catch(Exception ex)
                {

                }
            }


        }
    }
}
