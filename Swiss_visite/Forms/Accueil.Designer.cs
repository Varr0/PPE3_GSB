namespace Swiss_visite.Forms
{
    partial class Accueil
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
            this.btnCompteRendu = new System.Windows.Forms.Button();
            this.btnVisiteurs = new System.Windows.Forms.Button();
            this.btnPraticiens = new System.Windows.Forms.Button();
            this.btnMédics = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompteRendu
            // 
            this.btnCompteRendu.Location = new System.Drawing.Point(28, 27);
            this.btnCompteRendu.Name = "btnCompteRendu";
            this.btnCompteRendu.Size = new System.Drawing.Size(103, 28);
            this.btnCompteRendu.TabIndex = 0;
            this.btnCompteRendu.Text = "Compte-Rendus";
            this.btnCompteRendu.UseVisualStyleBackColor = true;
            this.btnCompteRendu.Click += new System.EventHandler(this.btnCompteRendu_Click);
            // 
            // btnVisiteurs
            // 
            this.btnVisiteurs.Location = new System.Drawing.Point(164, 27);
            this.btnVisiteurs.Name = "btnVisiteurs";
            this.btnVisiteurs.Size = new System.Drawing.Size(103, 28);
            this.btnVisiteurs.TabIndex = 1;
            this.btnVisiteurs.Text = "Visiteurs";
            this.btnVisiteurs.UseVisualStyleBackColor = true;
            this.btnVisiteurs.Click += new System.EventHandler(this.btnVisiteurs_Click);
            // 
            // btnPraticiens
            // 
            this.btnPraticiens.Location = new System.Drawing.Point(164, 90);
            this.btnPraticiens.Name = "btnPraticiens";
            this.btnPraticiens.Size = new System.Drawing.Size(103, 28);
            this.btnPraticiens.TabIndex = 2;
            this.btnPraticiens.Text = "Praticiens";
            this.btnPraticiens.UseVisualStyleBackColor = true;
            this.btnPraticiens.Click += new System.EventHandler(this.btnPraticiens_Click);
            // 
            // btnMédics
            // 
            this.btnMédics.Location = new System.Drawing.Point(28, 90);
            this.btnMédics.Name = "btnMédics";
            this.btnMédics.Size = new System.Drawing.Size(103, 28);
            this.btnMédics.TabIndex = 3;
            this.btnMédics.Text = "Médicaments";
            this.btnMédics.UseVisualStyleBackColor = true;
            this.btnMédics.Click += new System.EventHandler(this.btnMédics_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(164, 192);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(103, 28);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(28, 192);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(103, 28);
            this.btnDeco.TabIndex = 5;
            this.btnDeco.Text = "Déconnexion";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 246);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnMédics);
            this.Controls.Add(this.btnPraticiens);
            this.Controls.Add(this.btnVisiteurs);
            this.Controls.Add(this.btnCompteRendu);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompteRendu;
        private System.Windows.Forms.Button btnVisiteurs;
        private System.Windows.Forms.Button btnPraticiens;
        private System.Windows.Forms.Button btnMédics;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDeco;

    }
}