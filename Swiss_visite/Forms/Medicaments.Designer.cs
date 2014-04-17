namespace Swiss_visite.Forms
{
    partial class Medicaments
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
            this.lblMedic = new System.Windows.Forms.Label();
            this.cbMedic = new System.Windows.Forms.ComboBox();
            this.bsMedicaments = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_Medicaments = new Swiss_visite.Datasets.GSB_Medicaments();
            this.mEDICAMENTTableAdapter = new Swiss_visite.Datasets.GSB_MedicamentsTableAdapters.MEDICAMENTTableAdapter();
            this.tableAdapterManager = new Swiss_visite.Datasets.GSB_MedicamentsTableAdapters.TableAdapterManager();
            this.lblDepotLegal = new System.Windows.Forms.Label();
            this.lblDepotLegalBD = new System.Windows.Forms.Label();
            this.lblComposBD = new System.Windows.Forms.Label();
            this.lblCompos = new System.Windows.Forms.Label();
            this.lblEffetsBD = new System.Windows.Forms.Label();
            this.lblEffets = new System.Windows.Forms.Label();
            this.lblContreIndicBD = new System.Windows.Forms.Label();
            this.lblContreIndic = new System.Windows.Forms.Label();
            this.lblPrixBD = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDateSortieBD = new System.Windows.Forms.Label();
            this.lblDateSortie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Medicaments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedic
            // 
            this.lblMedic.AutoSize = true;
            this.lblMedic.Location = new System.Drawing.Point(22, 9);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(68, 13);
            this.lblMedic.TabIndex = 0;
            this.lblMedic.Text = "Medicament:";
            // 
            // cbMedic
            // 
            this.cbMedic.DataSource = this.bsMedicaments;
            this.cbMedic.DisplayMember = "MED_NOMCOMMERCIAL";
            this.cbMedic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedic.FormattingEnabled = true;
            this.cbMedic.Location = new System.Drawing.Point(153, 6);
            this.cbMedic.Name = "cbMedic";
            this.cbMedic.Size = new System.Drawing.Size(221, 21);
            this.cbMedic.TabIndex = 1;
            this.cbMedic.ValueMember = "MED_DEPOTLEGAL";
            // 
            // bsMedicaments
            // 
            this.bsMedicaments.DataMember = "MEDICAMENT";
            this.bsMedicaments.DataSource = this.gSB_Medicaments;
            // 
            // gSB_Medicaments
            // 
            this.gSB_Medicaments.DataSetName = "GSB_Medicaments";
            this.gSB_Medicaments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mEDICAMENTTableAdapter
            // 
            this.mEDICAMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MEDICAMENTTableAdapter = this.mEDICAMENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Swiss_visite.Datasets.GSB_MedicamentsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblDepotLegal
            // 
            this.lblDepotLegal.AutoSize = true;
            this.lblDepotLegal.Location = new System.Drawing.Point(22, 65);
            this.lblDepotLegal.Name = "lblDepotLegal";
            this.lblDepotLegal.Size = new System.Drawing.Size(64, 13);
            this.lblDepotLegal.TabIndex = 2;
            this.lblDepotLegal.Text = "Depot legal:";
            // 
            // lblDepotLegalBD
            // 
            this.lblDepotLegalBD.AutoSize = true;
            this.lblDepotLegalBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_DEPOTLEGAL", true));
            this.lblDepotLegalBD.Location = new System.Drawing.Point(128, 65);
            this.lblDepotLegalBD.Name = "lblDepotLegalBD";
            this.lblDepotLegalBD.Size = new System.Drawing.Size(0, 13);
            this.lblDepotLegalBD.TabIndex = 3;
            // 
            // lblComposBD
            // 
            this.lblComposBD.AutoSize = true;
            this.lblComposBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_COMPOSITION", true));
            this.lblComposBD.Location = new System.Drawing.Point(128, 106);
            this.lblComposBD.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblComposBD.Name = "lblComposBD";
            this.lblComposBD.Size = new System.Drawing.Size(0, 13);
            this.lblComposBD.TabIndex = 5;
            // 
            // lblCompos
            // 
            this.lblCompos.AutoSize = true;
            this.lblCompos.Location = new System.Drawing.Point(22, 106);
            this.lblCompos.Name = "lblCompos";
            this.lblCompos.Size = new System.Drawing.Size(67, 13);
            this.lblCompos.TabIndex = 4;
            this.lblCompos.Text = "Composition:";
            // 
            // lblEffetsBD
            // 
            this.lblEffetsBD.AutoSize = true;
            this.lblEffetsBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_EFFETS", true));
            this.lblEffetsBD.Location = new System.Drawing.Point(128, 165);
            this.lblEffetsBD.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblEffetsBD.Name = "lblEffetsBD";
            this.lblEffetsBD.Size = new System.Drawing.Size(0, 13);
            this.lblEffetsBD.TabIndex = 7;
            // 
            // lblEffets
            // 
            this.lblEffets.AutoSize = true;
            this.lblEffets.Location = new System.Drawing.Point(22, 165);
            this.lblEffets.Name = "lblEffets";
            this.lblEffets.Size = new System.Drawing.Size(37, 13);
            this.lblEffets.TabIndex = 6;
            this.lblEffets.Text = "Effets:";
            // 
            // lblContreIndicBD
            // 
            this.lblContreIndicBD.AutoSize = true;
            this.lblContreIndicBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_CONTREINDIC", true));
            this.lblContreIndicBD.Location = new System.Drawing.Point(128, 236);
            this.lblContreIndicBD.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblContreIndicBD.Name = "lblContreIndicBD";
            this.lblContreIndicBD.Size = new System.Drawing.Size(0, 13);
            this.lblContreIndicBD.TabIndex = 9;
            // 
            // lblContreIndic
            // 
            this.lblContreIndic.AutoSize = true;
            this.lblContreIndic.Location = new System.Drawing.Point(22, 236);
            this.lblContreIndic.Name = "lblContreIndic";
            this.lblContreIndic.Size = new System.Drawing.Size(90, 13);
            this.lblContreIndic.TabIndex = 8;
            this.lblContreIndic.Text = "Contre-Indication:";
            // 
            // lblPrixBD
            // 
            this.lblPrixBD.AutoSize = true;
            this.lblPrixBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_PRIXECHANTILLON", true));
            this.lblPrixBD.Location = new System.Drawing.Point(128, 310);
            this.lblPrixBD.Name = "lblPrixBD";
            this.lblPrixBD.Size = new System.Drawing.Size(0, 13);
            this.lblPrixBD.TabIndex = 11;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(22, 310);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(97, 13);
            this.lblPrix.TabIndex = 10;
            this.lblPrix.Text = "Prix Echantillon (€):";
            // 
            // lblDateSortieBD
            // 
            this.lblDateSortieBD.AutoSize = true;
            this.lblDateSortieBD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMedicaments, "MED_DATESORTIE", true));
            this.lblDateSortieBD.Location = new System.Drawing.Point(128, 345);
            this.lblDateSortieBD.Name = "lblDateSortieBD";
            this.lblDateSortieBD.Size = new System.Drawing.Size(0, 13);
            this.lblDateSortieBD.TabIndex = 13;
            // 
            // lblDateSortie
            // 
            this.lblDateSortie.AutoSize = true;
            this.lblDateSortie.Location = new System.Drawing.Point(22, 345);
            this.lblDateSortie.Name = "lblDateSortie";
            this.lblDateSortie.Size = new System.Drawing.Size(63, 13);
            this.lblDateSortie.TabIndex = 12;
            this.lblDateSortie.Text = "Date Sortie:";
            // 
            // Medicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 408);
            this.Controls.Add(this.lblDateSortieBD);
            this.Controls.Add(this.lblDateSortie);
            this.Controls.Add(this.lblPrixBD);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblContreIndicBD);
            this.Controls.Add(this.lblContreIndic);
            this.Controls.Add(this.lblEffetsBD);
            this.Controls.Add(this.lblEffets);
            this.Controls.Add(this.lblComposBD);
            this.Controls.Add(this.lblCompos);
            this.Controls.Add(this.lblDepotLegalBD);
            this.Controls.Add(this.lblDepotLegal);
            this.Controls.Add(this.cbMedic);
            this.Controls.Add(this.lblMedic);
            this.Name = "Medicaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicaments";
            ((System.ComponentModel.ISupportInitialize)(this.bsMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Medicaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedic;
        private System.Windows.Forms.ComboBox cbMedic;
        private Datasets.GSB_Medicaments gSB_Medicaments;
        private System.Windows.Forms.BindingSource bsMedicaments;
        private Datasets.GSB_MedicamentsTableAdapters.MEDICAMENTTableAdapter mEDICAMENTTableAdapter;
        private Datasets.GSB_MedicamentsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblDepotLegal;
        private System.Windows.Forms.Label lblDepotLegalBD;
        private System.Windows.Forms.Label lblComposBD;
        private System.Windows.Forms.Label lblCompos;
        private System.Windows.Forms.Label lblEffetsBD;
        private System.Windows.Forms.Label lblEffets;
        private System.Windows.Forms.Label lblContreIndicBD;
        private System.Windows.Forms.Label lblContreIndic;
        private System.Windows.Forms.Label lblPrixBD;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDateSortieBD;
        private System.Windows.Forms.Label lblDateSortie;
    }
}