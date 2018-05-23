namespace DAS_Buchaltungsprogramm
{
    partial class eingabe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eingabe));
            this.ein = new System.Windows.Forms.RadioButton();
            this.aus = new System.Windows.Forms.RadioButton();
            this.grund = new System.Windows.Forms.TextBox();
            this.hoehe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dattum = new System.Windows.Forms.DateTimePicker();
            this.speichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ein
            // 
            resources.ApplyResources(this.ein, "ein");
            this.ein.Name = "ein";
            this.ein.TabStop = true;
            this.ein.UseVisualStyleBackColor = true;
            // 
            // aus
            // 
            resources.ApplyResources(this.aus, "aus");
            this.aus.Name = "aus";
            this.aus.TabStop = true;
            this.aus.UseVisualStyleBackColor = true;
            // 
            // grund
            // 
            resources.ApplyResources(this.grund, "grund");
            this.grund.Name = "grund";
            // 
            // hoehe
            // 
            resources.ApplyResources(this.hoehe, "hoehe");
            this.hoehe.Name = "hoehe";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dattum
            // 
            resources.ApplyResources(this.dattum, "dattum");
            this.dattum.Name = "dattum";
            // 
            // speichern
            // 
            resources.ApplyResources(this.speichern, "speichern");
            this.speichern.Name = "speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // eingabe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.speichern);
            this.Controls.Add(this.dattum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoehe);
            this.Controls.Add(this.grund);
            this.Controls.Add(this.aus);
            this.Controls.Add(this.ein);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eingabe";
            this.Load += new System.EventHandler(this.eingabe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ein;
        private System.Windows.Forms.RadioButton aus;
        private System.Windows.Forms.TextBox grund;
        private System.Windows.Forms.TextBox hoehe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dattum;
        private System.Windows.Forms.Button speichern;
    }
}