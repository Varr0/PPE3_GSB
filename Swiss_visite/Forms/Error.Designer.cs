namespace Swiss_visite.Forms
{
    partial class Error
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
            this.errorLbl = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(32, 27);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(244, 13);
            this.errorLbl.TabIndex = 0;
            this.errorLbl.Text = "Impossible de se connecter à la base de données.";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(79, 54);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 95);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.errorLbl);
            this.Name = "Error";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erreur de connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button btnQuit;
    }
}