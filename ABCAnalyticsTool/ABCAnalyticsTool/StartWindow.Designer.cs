namespace ABCAnalyticsTool
{
    partial class StartWindow
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
            this.New = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 12);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(98, 23);
            this.New.TabIndex = 0;
            this.New.Text = "Neu Aus Datei";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 41);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(98, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Analyse öffnen";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(395, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 23);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Einstllungen";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 398);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.New);
            this.Name = "StartWindow";
            this.Text = "ABC-Analitics-Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Settings;
    }
}

