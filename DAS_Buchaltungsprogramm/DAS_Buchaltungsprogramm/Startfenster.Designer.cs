namespace DAS_Buchaltungsprogramm
{
    partial class startfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.eingab = new System.Windows.Forms.Button();
            this.ausgabe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eingab
            // 
            this.eingab.Location = new System.Drawing.Point(12, 50);
            this.eingab.Name = "eingab";
            this.eingab.Size = new System.Drawing.Size(75, 23);
            this.eingab.TabIndex = 0;
            this.eingab.Text = "Eingabe";
            this.eingab.UseVisualStyleBackColor = true;
            this.eingab.Click += new System.EventHandler(this.eingab_Click_1);
            // 
            // ausgabe
            // 
            this.ausgabe.Location = new System.Drawing.Point(367, 50);
            this.ausgabe.Name = "ausgabe";
            this.ausgabe.Size = new System.Drawing.Size(75, 23);
            this.ausgabe.TabIndex = 1;
            this.ausgabe.Text = "Ausgabe";
            this.ausgabe.UseVisualStyleBackColor = true;
            this.ausgabe.Click += new System.EventHandler(this.ausgabe_Click);
            // 
            // startfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 198);
            this.Controls.Add(this.ausgabe);
            this.Controls.Add(this.eingab);
            this.Name = "startfenster";
            this.Text = "Buchhaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eingab;
        private System.Windows.Forms.Button ausgabe;
    }
}

