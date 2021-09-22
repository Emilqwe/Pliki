
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
            this.SuspendLayout();
            // 
            // wyswietl
            // 
            this.wyswietl.Location = new System.Drawing.Point(12, 21);
            this.wyswietl.Multiline = true;
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(547, 369);
            this.wyswietl.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // otworz
            // 
            this.otworz.Location = new System.Drawing.Point(649, 32);
            this.otworz.Name = "otworz";
            this.otworz.Size = new System.Drawing.Size(75, 23);
            this.otworz.TabIndex = 1;
            this.otworz.Text = "Otwórz";
            this.otworz.UseVisualStyleBackColor = true;
            this.otworz.Click += new System.EventHandler(this.otworz_Click);
            // 
            // zapisz
            // 
            this.zapisz.Location = new System.Drawing.Point(649, 311);
            this.zapisz.Name = "zapisz";
            this.zapisz.Size = new System.Drawing.Size(75, 23);
            this.zapisz.TabIndex = 2;
            this.zapisz.Text = "Zapisz";
            this.zapisz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zapisz);
            this.Controls.Add(this.otworz);
            this.Controls.Add(this.wyswietl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wyswietl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button otworz;
        private System.Windows.Forms.Button zapisz;
    }
}

