
namespace Pliki
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wyswietl = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.otworz = new System.Windows.Forms.Button();
            this.zapisz = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.strona2 = new System.Windows.Forms.TabPage();
            this.zapisz2 = new System.Windows.Forms.Button();
            this.fontchange = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pochylnosc = new System.Windows.Forms.Button();
            this.grubosc = new System.Windows.Forms.Button();
            this.kolor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.wyswietl2 = new System.Windows.Forms.RichTextBox();
            this.podkreslenie = new System.Windows.Forms.Button();
            this.przekreslenie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.strona2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wyswietl
            // 
            this.wyswietl.Location = new System.Drawing.Point(16, 6);
            this.wyswietl.Multiline = true;
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(442, 273);
            this.wyswietl.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // otworz
            // 
            this.otworz.Location = new System.Drawing.Point(521, 35);
            this.otworz.Name = "otworz";
            this.otworz.Size = new System.Drawing.Size(75, 23);
            this.otworz.TabIndex = 1;
            this.otworz.Text = "Otwórz";
            this.otworz.UseVisualStyleBackColor = true;
            this.otworz.Click += new System.EventHandler(this.otworz_Click);
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(521, 197);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(75, 23);
            this.zapisz.TabIndex = 2;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            this.zapisz.Click += new System.EventHandler(this.zapisz_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.strona2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 436);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.wyswietl);
            this.tabPage1.Controls.Add(this.otworz);
            this.tabPage1.Controls.Add(this.zapisz);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "strona1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // strona2
            // 
            this.strona2.Controls.Add(this.przekreslenie);
            this.strona2.Controls.Add(this.podkreslenie);
            this.strona2.Controls.Add(this.wyswietl2);
            this.strona2.Controls.Add(this.kolor);
            this.strona2.Controls.Add(this.grubosc);
            this.strona2.Controls.Add(this.pochylnosc);
            this.strona2.Controls.Add(this.zapisz2);
            this.strona2.Controls.Add(this.fontchange);
            this.strona2.Location = new System.Drawing.Point(4, 22);
            this.strona2.Name = "strona2";
            this.strona2.Padding = new System.Windows.Forms.Padding(3);
            this.strona2.Size = new System.Drawing.Size(768, 410);
            this.strona2.TabIndex = 1;
            this.strona2.Text = "tabPage2";
            this.strona2.UseVisualStyleBackColor = true;
            // 
            // zapisz2
            // 
            this.zapisz2.Location = new System.Drawing.Point(584, 248);
            this.zapisz2.Name = "zapisz2";
            this.zapisz2.Size = new System.Drawing.Size(75, 23);
            this.zapisz2.TabIndex = 2;
            this.zapisz2.Text = "Zapisz";
            this.zapisz2.UseVisualStyleBackColor = true;
            this.zapisz2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fontchange
            // 
            this.fontchange.Location = new System.Drawing.Point(491, 30);
            this.fontchange.Name = "fontchange";
            this.fontchange.Size = new System.Drawing.Size(115, 23);
            this.fontchange.TabIndex = 1;
            this.fontchange.Text = "Zmień Czcionkę";
            this.fontchange.UseVisualStyleBackColor = true;
            this.fontchange.Click += new System.EventHandler(this.button1_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // pochylnosc
            // 
            this.pochylnosc.Location = new System.Drawing.Point(612, 59);
            this.pochylnosc.Name = "pochylnosc";
            this.pochylnosc.Size = new System.Drawing.Size(115, 23);
            this.pochylnosc.TabIndex = 3;
            this.pochylnosc.Text = "Pochyl";
            this.pochylnosc.UseVisualStyleBackColor = true;
            this.pochylnosc.Click += new System.EventHandler(this.pochylnosc_Click);
            // 
            // grubosc
            // 
            this.grubosc.Location = new System.Drawing.Point(491, 59);
            this.grubosc.Name = "grubosc";
            this.grubosc.Size = new System.Drawing.Size(115, 23);
            this.grubosc.TabIndex = 4;
            this.grubosc.Text = "Pogrub";
            this.grubosc.UseVisualStyleBackColor = true;
            this.grubosc.Click += new System.EventHandler(this.grubosc_Click);
            // 
            // kolor
            // 
            this.kolor.Location = new System.Drawing.Point(612, 30);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(115, 23);
            this.kolor.TabIndex = 5;
            this.kolor.Text = "Zmień Kolor";
            this.kolor.UseVisualStyleBackColor = true;
            this.kolor.Click += new System.EventHandler(this.kolor_Click);
            // 
            // wyswietl2
            // 
            this.wyswietl2.Location = new System.Drawing.Point(17, 6);
            this.wyswietl2.Name = "wyswietl2";
            this.wyswietl2.Size = new System.Drawing.Size(450, 332);
            this.wyswietl2.TabIndex = 6;
            this.wyswietl2.Text = "";
            // 
            // podkreslenie
            // 
            this.podkreslenie.Location = new System.Drawing.Point(491, 88);
            this.podkreslenie.Name = "podkreslenie";
            this.podkreslenie.Size = new System.Drawing.Size(115, 23);
            this.podkreslenie.TabIndex = 7;
            this.podkreslenie.Text = "Podkreśl";
            this.podkreslenie.UseVisualStyleBackColor = true;
            this.podkreslenie.Click += new System.EventHandler(this.podkreslenie_Click);
            // 
            // przekreslenie
            // 
            this.przekreslenie.Location = new System.Drawing.Point(612, 88);
            this.przekreslenie.Name = "przekreslenie";
            this.przekreslenie.Size = new System.Drawing.Size(115, 23);
            this.przekreslenie.TabIndex = 8;
            this.przekreslenie.Text = "Przekreśl";
            this.przekreslenie.UseVisualStyleBackColor = true;
            this.przekreslenie.Click += new System.EventHandler(this.przekreslenie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.strona2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox wyswietl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button otworz;
        private System.Windows.Forms.Button zapisz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage strona2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button zapisz2;
        private System.Windows.Forms.Button kolor;
        private System.Windows.Forms.Button grubosc;
        private System.Windows.Forms.Button pochylnosc;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button fontchange;
        private System.Windows.Forms.RichTextBox wyswietl2;
        private System.Windows.Forms.Button podkreslenie;
        private System.Windows.Forms.Button przekreslenie;
    }
}

