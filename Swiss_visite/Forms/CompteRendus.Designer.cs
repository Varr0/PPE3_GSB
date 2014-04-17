namespace Swiss_visite.Forms
{
    partial class CompteRendus
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
            this.cbRapport = new System.Windows.Forms.ComboBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_CompteRendus = new Swiss_visite.Datasets.GSB_CompteRendus();
            this.rAPPORT_VISITETableAdapter = new Swiss_visite.Datasets.GSB_CompteRendusTableAdapters.RAPPORT_VISITETableAdapter();
            this.tableAdapterManager = new Swiss_visite.Datasets.GSB_CompteRendusTableAdapters.TableAdapterManager();
            this.lblRapport = new System.Windows.Forms.Label();
            this.lblCollabBD = new System.Windows.Forms.Label();
            this.lblCollab = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblPraticienBD = new System.Windows.Forms.Label();
            this.lblPraticien = new System.Windows.Forms.Label();
            this.lblBilanBD = new System.Windows.Forms.Label();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblDateSaisieBD = new System.Windows.Forms.Label();
            this.lblDateSaisie = new System.Windows.Forms.Label();
            this.lblCoeffConfianceBD = new System.Windows.Forms.Label();
            this.lblCoeffConfiance = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.gSB_Motif = new Swiss_visite.Datasets.GSB_Motif();
            this.bsMotif = new System.Windows.Forms.BindingSource(this.components);
            this.mOTIFTableAdapter = new Swiss_visite.Datasets.GSB_MotifTableAdapters.MOTIFTableAdapter();
            this.tableAdapterManager1 = new Swiss_visite.Datasets.GSB_MotifTableAdapters.TableAdapterManager();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_CompteRendus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Motif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRapport
            // 
            this.cbRapport.DataSource = this.bsRapport;
            this.cbRapport.DisplayMember = "RAP_NUM";
            this.cbRapport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRapport.FormattingEnabled = true;
            this.cbRapport.Location = new System.Drawing.Point(178, 21);
            this.cbRapport.Name = "cbRapport";
            this.cbRapport.Size = new System.Drawing.Size(190, 21);
            this.cbRapport.TabIndex = 0;
            this.cbRapport.ValueMember = "COL_MATRICULE";
            // 
            // bsRapport
            // 
            this.bsRapport.DataMember = "RAPPORT_VISITE";
            this.bsRapport.DataSource = this.gSB_CompteRendus;
            // 
            // gSB_CompteRendus
            // 
            this.gSB_CompteRendus.DataSetName = "GSB_CompteRendus";
            this.gSB_CompteRendus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAPPORT_VISITETableAdapter
            // 
            this.rAPPORT_VISITETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RAPPORT_VISITETableAdapter = this.rAPPORT_VISITETableAdapter;
            this.tableAdapterManager.UpdateOrder = Swiss_visite.Datasets.GSB_CompteRendusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblRapport
            // 
            this.lblRapport.AutoSize = true;
            this.lblRapport.Location = new System.Drawing.Point(14, 24);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(140, 13);
            this.lblRapport.TabIndex = 1;
            this.lblRapport.Text = "Numero du rapport de visite:";
            // 
            // lblCollabBD
            // 
            this.lblCollabBD.AutoSize = true;
            this.lblCollabBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "COL_MATRICULE", true));
            this.lblCollabBD.Location = new System.Drawing.Point(175, 73);
            this.lblCollabBD.Name = "lblCollabBD";
            this.lblCollabBD.Size = new System.Drawing.Size(0, 13);
            this.lblCollabBD.TabIndex = 5;
            // 
            // lblCollab
            // 
            this.lblCollab.AutoSize = true;
            this.lblCollab.Location = new System.Drawing.Point(14, 73);
            this.lblCollab.Name = "lblCollab";
            this.lblCollab.Size = new System.Drawing.Size(132, 13);
            this.lblCollab.TabIndex = 4;
            this.lblCollab.Text = "Matricule du collaborateur:";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(14, 112);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(33, 13);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "Motif:";
            // 
            // lblPraticienBD
            // 
            this.lblPraticienBD.AutoSize = true;
            this.lblPraticienBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "PRA_NUM", true));
            this.lblPraticienBD.Location = new System.Drawing.Point(175, 153);
            this.lblPraticienBD.Name = "lblPraticienBD";
            this.lblPraticienBD.Size = new System.Drawing.Size(0, 13);
            this.lblPraticienBD.TabIndex = 9;
            // 
            // lblPraticien
            // 
            this.lblPraticien.AutoSize = true;
            this.lblPraticien.Location = new System.Drawing.Point(14, 153);
            this.lblPraticien.Name = "lblPraticien";
            this.lblPraticien.Size = new System.Drawing.Size(51, 13);
            this.lblPraticien.TabIndex = 8;
            this.lblPraticien.Text = "Praticien:";
            // 
            // lblBilanBD
            // 
            this.lblBilanBD.AutoSize = true;
            this.lblBilanBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "RAP_BILAN", true));
            this.lblBilanBD.Location = new System.Drawing.Point(175, 191);
            this.lblBilanBD.Name = "lblBilanBD";
            this.lblBilanBD.Size = new System.Drawing.Size(0, 13);
            this.lblBilanBD.TabIndex = 11;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(14, 191);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(84, 13);
            this.lblBilan.TabIndex = 10;
            this.lblBilan.Text = "Bilan du rapport:";
            // 
            // lblDateSaisieBD
            // 
            this.lblDateSaisieBD.AutoSize = true;
            this.lblDateSaisieBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "RAP_DATE_SAISIE", true));
            this.lblDateSaisieBD.Location = new System.Drawing.Point(175, 230);
            this.lblDateSaisieBD.Name = "lblDateSaisieBD";
            this.lblDateSaisieBD.Size = new System.Drawing.Size(0, 13);
            this.lblDateSaisieBD.TabIndex = 13;
            // 
            // lblDateSaisie
            // 
            this.lblDateSaisie.AutoSize = true;
            this.lblDateSaisie.Location = new System.Drawing.Point(14, 230);
            this.lblDateSaisie.Name = "lblDateSaisie";
            this.lblDateSaisie.Size = new System.Drawing.Size(128, 13);
            this.lblDateSaisie.TabIndex = 12;
            this.lblDateSaisie.Text = "Date de saisie du rapport:";
            // 
            // lblCoeffConfianceBD
            // 
            this.lblCoeffConfianceBD.AutoSize = true;
            this.lblCoeffConfianceBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "RAP_COEFFCONFIANCE", true));
            this.lblCoeffConfianceBD.Location = new System.Drawing.Point(175, 267);
            this.lblCoeffConfianceBD.Name = "lblCoeffConfianceBD";
            this.lblCoeffConfianceBD.Size = new System.Drawing.Size(0, 13);
            this.lblCoeffConfianceBD.TabIndex = 15;
            // 
            // lblCoeffConfiance
            // 
            this.lblCoeffConfiance.AutoSize = true;
            this.lblCoeffConfiance.Location = new System.Drawing.Point(14, 267);
            this.lblCoeffConfiance.Name = "lblCoeffConfiance";
            this.lblCoeffConfiance.Size = new System.Drawing.Size(125, 13);
            this.lblCoeffConfiance.TabIndex = 14;
            this.lblCoeffConfiance.Text = "Coefficient de confiance:";
            // 
            // cbMotif
            // 
            this.cbMotif.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapport, "MOT_NUM", true));
            this.cbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(178, 109);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(121, 21);
            this.cbMotif.TabIndex = 16;
            // 
            // gSB_Motif
            // 
            this.gSB_Motif.DataSetName = "GSB_Motif";
            this.gSB_Motif.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsMotif
            // 
            this.bsMotif.DataMember = "MOTIF";
            this.bsMotif.DataSource = this.gSB_Motif;
            // 
            // mOTIFTableAdapter
            // 
            this.mOTIFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Swiss_visite.Datasets.GSB_MotifTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(245, 292);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(172, 23);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer les modifications";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // CompteRendus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 327);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.lblCoeffConfianceBD);
            this.Controls.Add(this.lblCoeffConfiance);
            this.Controls.Add(this.lblDateSaisieBD);
            this.Controls.Add(this.lblDateSaisie);
            this.Controls.Add(this.lblBilanBD);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.lblPraticienBD);
            this.Controls.Add(this.lblPraticien);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.lblCollabBD);
            this.Controls.Add(this.lblCollab);
            this.Controls.Add(this.lblRapport);
            this.Controls.Add(this.cbRapport);
            this.Name = "CompteRendus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte Rendus";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_CompteRendus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Motif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRapport;
        private Datasets.GSB_CompteRendus gSB_CompteRendus;
        private Datasets.GSB_CompteRendusTableAdapters.RAPPORT_VISITETableAdapter rAPPORT_VISITETableAdapter;
        private Datasets.GSB_CompteRendusTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.Label lblCollabBD;
        private System.Windows.Forms.Label lblCollab;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblPraticienBD;
        private System.Windows.Forms.Label lblPraticien;
        private System.Windows.Forms.Label lblBilanBD;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lblDateSaisieBD;
        private System.Windows.Forms.Label lblDateSaisie;
        private System.Windows.Forms.Label lblCoeffConfianceBD;
        private System.Windows.Forms.Label lblCoeffConfiance;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.ComboBox cbMotif;
        private Datasets.GSB_Motif gSB_Motif;
        private System.Windows.Forms.BindingSource bsMotif;
        private Datasets.GSB_MotifTableAdapters.MOTIFTableAdapter mOTIFTableAdapter;
        private Datasets.GSB_MotifTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}