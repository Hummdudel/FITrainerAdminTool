using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCKartendetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVKartendetails = new System.Windows.Forms.DataGridView();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelReset = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonDeleteKartendetail = new System.Windows.Forms.Button();
            this.buttonUpdateKartendetail = new System.Windows.Forms.Button();
            this.buttonCreateKartendetail = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboBoxUsername = new System.Windows.Forms.ComboBox();
            this.comboBoxKartenID = new System.Windows.Forms.ComboBox();
            this.comboBoxLernstufe = new System.Windows.Forms.ComboBox();
            this.labelKartenID = new System.Windows.Forms.Label();
            this.labelLernstufe = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKartendetails)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVKartendetails
            // 
            this.DGVKartendetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKartendetails.Location = new System.Drawing.Point(10, 35);
            this.DGVKartendetails.Name = "DGVKartendetails";
            this.DGVKartendetails.Size = new System.Drawing.Size(360, 510);
            this.DGVKartendetails.TabIndex = 2;
            this.DGVKartendetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKartendetails_CellClick);
            // 
            // labelDelete
            // 
            this.labelDelete.Location = new System.Drawing.Point(520, 645);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(70, 15);
            this.labelDelete.TabIndex = 37;
            this.labelDelete.Text = "Delete";
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(430, 645);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(70, 15);
            this.labelUpdate.TabIndex = 36;
            this.labelUpdate.Text = "Update";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCreate
            // 
            this.labelCreate.Location = new System.Drawing.Point(340, 645);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(70, 15);
            this.labelCreate.TabIndex = 35;
            this.labelCreate.Text = "Create";
            this.labelCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReset
            // 
            this.labelReset.Location = new System.Drawing.Point(10, 645);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(70, 15);
            this.labelReset.TabIndex = 34;
            this.labelReset.Text = "Reset";
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(110, 600);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUsername.Size = new System.Drawing.Size(100, 15);
            this.labelUsername.TabIndex = 33;
            this.labelUsername.Text = "Username";
            // 
            // buttonDeleteKartendetail
            // 
            this.buttonDeleteKartendetail.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_remove;
            this.buttonDeleteKartendetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteKartendetail.Location = new System.Drawing.Point(520, 575);
            this.buttonDeleteKartendetail.Name = "buttonDeleteKartendetail";
            this.buttonDeleteKartendetail.Size = new System.Drawing.Size(70, 70);
            this.buttonDeleteKartendetail.TabIndex = 32;
            this.buttonDeleteKartendetail.UseVisualStyleBackColor = true;
            this.buttonDeleteKartendetail.Click += new System.EventHandler(this.buttonDeleteKartendetail_Click);
            // 
            // buttonUpdateKartendetail
            // 
            this.buttonUpdateKartendetail.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_update;
            this.buttonUpdateKartendetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateKartendetail.Location = new System.Drawing.Point(430, 575);
            this.buttonUpdateKartendetail.Name = "buttonUpdateKartendetail";
            this.buttonUpdateKartendetail.Size = new System.Drawing.Size(70, 70);
            this.buttonUpdateKartendetail.TabIndex = 31;
            this.buttonUpdateKartendetail.UseVisualStyleBackColor = true;
            this.buttonUpdateKartendetail.Click += new System.EventHandler(this.buttonUpdateKartendetail_Click);
            // 
            // buttonCreateKartendetail
            // 
            this.buttonCreateKartendetail.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_add;
            this.buttonCreateKartendetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateKartendetail.Location = new System.Drawing.Point(340, 575);
            this.buttonCreateKartendetail.Name = "buttonCreateKartendetail";
            this.buttonCreateKartendetail.Size = new System.Drawing.Size(70, 70);
            this.buttonCreateKartendetail.TabIndex = 30;
            this.buttonCreateKartendetail.UseVisualStyleBackColor = true;
            this.buttonCreateKartendetail.Click += new System.EventHandler(this.buttonCreateKartendetail_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_reload;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Location = new System.Drawing.Point(10, 575);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 70);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // comboBoxUsername
            // 
            this.comboBoxUsername.FormattingEnabled = true;
            this.comboBoxUsername.Location = new System.Drawing.Point(110, 575);
            this.comboBoxUsername.Name = "comboBoxUsername";
            this.comboBoxUsername.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUsername.TabIndex = 44;
            // 
            // comboBoxKartenID
            // 
            this.comboBoxKartenID.FormattingEnabled = true;
            this.comboBoxKartenID.Location = new System.Drawing.Point(110, 620);
            this.comboBoxKartenID.Name = "comboBoxKartenID";
            this.comboBoxKartenID.Size = new System.Drawing.Size(50, 21);
            this.comboBoxKartenID.TabIndex = 45;
            // 
            // comboBoxLernstufe
            // 
            this.comboBoxLernstufe.FormattingEnabled = true;
            this.comboBoxLernstufe.Location = new System.Drawing.Point(260, 620);
            this.comboBoxLernstufe.Name = "comboBoxLernstufe";
            this.comboBoxLernstufe.Size = new System.Drawing.Size(50, 21);
            this.comboBoxLernstufe.TabIndex = 46;
            // 
            // labelKartenID
            // 
            this.labelKartenID.Location = new System.Drawing.Point(110, 645);
            this.labelKartenID.Name = "labelKartenID";
            this.labelKartenID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelKartenID.Size = new System.Drawing.Size(60, 15);
            this.labelKartenID.TabIndex = 47;
            this.labelKartenID.Text = "Karten-ID";
            // 
            // labelLernstufe
            // 
            this.labelLernstufe.Location = new System.Drawing.Point(260, 645);
            this.labelLernstufe.Name = "labelLernstufe";
            this.labelLernstufe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLernstufe.Size = new System.Drawing.Size(60, 15);
            this.labelLernstufe.TabIndex = 48;
            this.labelLernstufe.Text = "Lernstufe";
            // 
            // labelHeadline
            // 
            this.labelHeadline.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeadline.Location = new System.Drawing.Point(10, 5);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(138, 25);
            this.labelHeadline.TabIndex = 49;
            this.labelHeadline.Text = "Kartendetails";
            // 
            // UCKartendetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelLernstufe);
            this.Controls.Add(this.labelKartenID);
            this.Controls.Add(this.comboBoxLernstufe);
            this.Controls.Add(this.comboBoxKartenID);
            this.Controls.Add(this.comboBoxUsername);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonDeleteKartendetail);
            this.Controls.Add(this.buttonUpdateKartendetail);
            this.Controls.Add(this.buttonCreateKartendetail);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.DGVKartendetails);
            this.Name = "UCKartendetails";
            this.Size = new System.Drawing.Size(1180, 785);
            ((System.ComponentModel.ISupportInitialize)(this.DGVKartendetails)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelHeadline;

        private System.Windows.Forms.ComboBox comboBoxUsername;
        private System.Windows.Forms.ComboBox comboBoxKartenID;
        private System.Windows.Forms.ComboBox comboBoxLernstufe;
        private System.Windows.Forms.Label labelKartenID;
        private System.Windows.Forms.Label labelLernstufe;

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonDeleteKartendetail;
        private System.Windows.Forms.Button buttonUpdateKartendetail;
        private System.Windows.Forms.Button buttonCreateKartendetail;
        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.DataGridView DGVKartendetails;

        #endregion
    }
}