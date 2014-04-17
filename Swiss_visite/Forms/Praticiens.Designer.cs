namespace Swiss_visite.Forms
{
    partial class Praticiens
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
            this.components = new System.ComponentModel.Container();
            this.labChercher = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labPrenom = new System.Windows.Forms.Label();
            this.labAdresse = new System.Windows.Forms.Label();
            this.labVille = new System.Windows.Forms.Label();
            this.labCoeff = new System.Windows.Forms.Label();
            this.cbChercher = new System.Windows.Forms.ComboBox();
            this.bsPraticiens = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_Praticien = new Swiss_visite.Datasets.GSB_Praticien();
            this.labNomBD = new System.Windows.Forms.Label();
            this.labPrenomBD = new System.Windows.Forms.Label();
            this.labVilleBD = new System.Windows.Forms.Label();
            this.labAdresseBD = new System.Windows.Forms.Label();
            this.labCoeffBD = new System.Windows.Forms.Label();
            this.labCPBD = new System.Windows.Forms.Label();
            this.labCP = new System.Windows.Forms.Label();
            this.pRATICIENTableAdapter = new Swiss_visite.Datasets.GSB_PraticienTableAdapters.PRATICIENTableAdapter();
            this.tableAdapterManager = new Swiss_visite.Datasets.GSB_PraticienTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticiens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Praticien)).BeginInit();
            this.SuspendLayout();
            // 
            // labChercher
            // 
            this.labChercher.AutoSize = true;
            this.labChercher.Location = new System.Drawing.Point(38, 17);
            this.labChercher.Name = "labChercher";
            this.labChercher.Size = new System.Drawing.Size(51, 13);
            this.labChercher.TabIndex = 1;
            this.labChercher.Text = "Praticien:";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(38, 63);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(32, 13);
            this.labNom.TabIndex = 3;
            this.labNom.Text = "Nom:";
            // 
            // labPrenom
            // 
            this.labPrenom.AutoSize = true;
            this.labPrenom.Location = new System.Drawing.Point(38, 104);
            this.labPrenom.Name = "labPrenom";
            this.labPrenom.Size = new System.Drawing.Size(46, 13);
            this.labPrenom.TabIndex = 4;
            this.labPrenom.Text = "Prénom:";
            // 
            // labAdresse
            // 
            this.labAdresse.AutoSize = true;
            this.labAdresse.Location = new System.Drawing.Point(38, 146);
            this.labAdresse.Name = "labAdresse";
            this.labAdresse.Size = new System.Drawing.Size(48, 13);
            this.labAdresse.TabIndex = 5;
            this.labAdresse.Text = "Adresse:";
            // 
            // labVille
            // 
            this.labVille.AutoSize = true;
            this.labVille.Location = new System.Drawing.Point(38, 190);
            this.labVille.Name = "labVille";
            this.labVille.Size = new System.Drawing.Size(29, 13);
            this.labVille.TabIndex = 6;
            this.labVille.Text = "Ville:";
            // 
            // labCoeff
            // 
            this.labCoeff.AutoSize = true;
            this.labCoeff.Location = new System.Drawing.Point(38, 279);
            this.labCoeff.Name = "labCoeff";
            this.labCoeff.Size = new System.Drawing.Size(84, 13);
            this.labCoeff.TabIndex = 7;
            this.labCoeff.Text = "Coeff. Notoriété:";
            // 
            // cbChercher
            // 
            this.cbChercher.DataSource = this.bsPraticiens;
            this.cbChercher.DisplayMember = "PRA_NUM";
            this.cbChercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChercher.FormattingEnabled = true;
            this.cbChercher.Location = new System.Drawing.Point(123, 14);
            this.cbChercher.Name = "cbChercher";
            this.cbChercher.Size = new System.Drawing.Size(166, 21);
            this.cbChercher.TabIndex = 15;
            this.cbChercher.ValueMember = "PRA_NUM";
            // 
            // bsPraticiens
            // 
            this.bsPraticiens.DataMember = "PRATICIEN";
            this.bsPraticiens.DataSource = this.gSB_Praticien;
            // 
            // gSB_Praticien
            // 
            this.gSB_Praticien.DataSetName = "GSB_Praticien";
            this.gSB_Praticien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labNomBD
            // 
            this.labNomBD.AutoSize = true;
            this.labNomBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_NOM", true));
            this.labNomBD.Location = new System.Drawing.Point(159, 63);
            this.labNomBD.Name = "labNomBD";
            this.labNomBD.Size = new System.Drawing.Size(0, 13);
            this.labNomBD.TabIndex = 18;
            // 
            // labPrenomBD
            // 
            this.labPrenomBD.AutoSize = true;
            this.labPrenomBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_PRENOM", true));
            this.labPrenomBD.Location = new System.Drawing.Point(159, 104);
            this.labPrenomBD.Name = "labPrenomBD";
            this.labPrenomBD.Size = new System.Drawing.Size(0, 13);
            this.labPrenomBD.TabIndex = 20;
            // 
            // labVilleBD
            // 
            this.labVilleBD.AutoSize = true;
            this.labVilleBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_VILLE", true));
            this.labVilleBD.Location = new System.Drawing.Point(159, 190);
            this.labVilleBD.Name = "labVilleBD";
            this.labVilleBD.Size = new System.Drawing.Size(0, 13);
            this.labVilleBD.TabIndex = 21;
            // 
            // labAdresseBD
            // 
            this.labAdresseBD.AutoSize = true;
            this.labAdresseBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_ADRESSE", true));
            this.labAdresseBD.Location = new System.Drawing.Point(159, 146);
            this.labAdresseBD.Name = "labAdresseBD";
            this.labAdresseBD.Size = new System.Drawing.Size(0, 13);
            this.labAdresseBD.TabIndex = 23;
            // 
            // labCoeffBD
            // 
            this.labCoeffBD.AutoSize = true;
            this.labCoeffBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_COEFNOTORIETE", true));
            this.labCoeffBD.Location = new System.Drawing.Point(159, 279);
            this.labCoeffBD.Name = "labCoeffBD";
            this.labCoeffBD.Size = new System.Drawing.Size(0, 13);
            this.labCoeffBD.TabIndex = 24;
            // 
            // labCPBD
            // 
            this.labCPBD.AutoSize = true;
            this.labCPBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPraticiens, "PRA_CP", true));
            this.labCPBD.Location = new System.Drawing.Point(159, 237);
            this.labCPBD.Name = "labCPBD";
            this.labCPBD.Size = new System.Drawing.Size(0, 13);
            this.labCPBD.TabIndex = 26;
            // 
            // labCP
            // 
            this.labCP.AutoSize = true;
            this.labCP.Location = new System.Drawing.Point(38, 237);
            this.labCP.Name = "labCP";
            this.labCP.Size = new System.Drawing.Size(67, 13);
            this.labCP.TabIndex = 25;
            this.labCP.Text = "Code Postal:";
            // 
            // pRATICIENTableAdapter
            // 
            this.pRATICIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PRATICIENTableAdapter = this.pRATICIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = Swiss_visite.Datasets.GSB_PraticienTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Praticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 314);
            this.Controls.Add(this.labCPBD);
            this.Controls.Add(this.labCP);
            this.Controls.Add(this.labCoeffBD);
            this.Controls.Add(this.labAdresseBD);
            this.Controls.Add(this.labVilleBD);
            this.Controls.Add(this.labPrenomBD);
            this.Controls.Add(this.labNomBD);
            this.Controls.Add(this.cbChercher);
            this.Controls.Add(this.labCoeff);
            this.Controls.Add(this.labVille);
            this.Controls.Add(this.labAdresse);
            this.Controls.Add(this.labPrenom);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.labChercher);
            this.Name = "Praticiens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Praticiens";
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticiens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Praticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labChercher;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labPrenom;
        private System.Windows.Forms.Label labAdresse;
        private System.Windows.Forms.Label labVille;
        private System.Windows.Forms.Label labCoeff;
        private System.Windows.Forms.ComboBox cbChercher;
        private System.Windows.Forms.Label labNomBD;
        private System.Windows.Forms.Label labPrenomBD;
        private System.Windows.Forms.Label labVilleBD;
        private System.Windows.Forms.Label labAdresseBD;
        private System.Windows.Forms.Label labCoeffBD;
        private System.Windows.Forms.Label labCPBD;
        private System.Windows.Forms.Label labCP;
        private Datasets.GSB_Praticien gSB_Praticien;
        private System.Windows.Forms.BindingSource bsPraticiens;
        private Datasets.GSB_PraticienTableAdapters.PRATICIENTableAdapter pRATICIENTableAdapter;
        private Datasets.GSB_PraticienTableAdapters.TableAdapterManager tableAdapterManager;
    }
}