namespace Swiss_visite
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnConnex = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bsVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(329, 201);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(105, 25);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnConnex
            // 
            this.btnConnex.Location = new System.Drawing.Point(149, 153);
            this.btnConnex.Name = "btnConnex";
            this.btnConnex.Size = new System.Drawing.Size(123, 25);
            this.btnConnex.TabIndex = 3;
            this.btnConnex.Text = "Connexion";
            this.btnConnex.UseVisualStyleBackColor = true;
            this.btnConnex.Click += new System.EventHandler(this.btnConnex_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Location = new System.Drawing.Point(72, 65);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Utilisateur";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblPwd.Location = new System.Drawing.Point(51, 109);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(74, 13);
            this.lblPwd.TabIndex = 4;
            this.lblPwd.Text = "Mot de passe ";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(149, 62);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(123, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(149, 106);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(123, 20);
            this.tbPwd.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // bsVisiteurs
            // 
            this.bsVisiteurs.DataSource = typeof(Swiss_visite.ConnectDBGSB);
            // 
            // Connexion
            // 
            this.AcceptButton = this.btnConnex;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 235);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnConnex);
            this.Controls.Add(this.btnQuitter);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swiss Visite - GSB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnConnex;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource bsVisiteurs;
    }
}

