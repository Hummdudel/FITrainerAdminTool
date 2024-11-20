using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCModule
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
            this.DGVModule = new System.Windows.Forms.DataGridView();
            this.textBoxModul = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCreateModul = new System.Windows.Forms.Button();
            this.buttonUpdateModul = new System.Windows.Forms.Button();
            this.buttonDeleteModul = new System.Windows.Forms.Button();
            this.labelModul = new System.Windows.Forms.Label();
            this.labelReset = new System.Windows.Forms.Label();
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVModule)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVModule
            // 
            this.DGVModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVModule.Location = new System.Drawing.Point(10, 35);
            this.DGVModule.Name = "DGVModule";
            this.DGVModule.Size = new System.Drawing.Size(268, 510);
            this.DGVModule.TabIndex = 0;
            this.DGVModule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVModule_CellClick);
            // 
            // textBoxModul
            // 
            this.textBoxModul.Location = new System.Drawing.Point(110, 575);
            this.textBoxModul.Name = "textBoxModul";
            this.textBoxModul.Size = new System.Drawing.Size(200, 20);
            this.textBoxModul.TabIndex = 1;
            // 
            // buttonReset
            // 
            this.buttonReset.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_reload;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Location = new System.Drawing.Point(10, 575);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 70);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCreateModul
            // 
            this.buttonCreateModul.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_add;
            this.buttonCreateModul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateModul.Location = new System.Drawing.Point(340, 575);
            this.buttonCreateModul.Name = "buttonCreateModul";
            this.buttonCreateModul.Size = new System.Drawing.Size(70, 70);
            this.buttonCreateModul.TabIndex = 3;
            this.buttonCreateModul.UseVisualStyleBackColor = true;
            this.buttonCreateModul.Click += new System.EventHandler(this.buttonCreateModul_Click);
            // 
            // buttonUpdateModul
            // 
            this.buttonUpdateModul.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_update;
            this.buttonUpdateModul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateModul.Location = new System.Drawing.Point(430, 575);
            this.buttonUpdateModul.Name = "buttonUpdateModul";
            this.buttonUpdateModul.Size = new System.Drawing.Size(70, 70);
            this.buttonUpdateModul.TabIndex = 4;
            this.buttonUpdateModul.UseVisualStyleBackColor = true;
            this.buttonUpdateModul.Click += new System.EventHandler(this.buttonUpdateModul_Click);
            // 
            // buttonDeleteModul
            // 
            this.buttonDeleteModul.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_remove;
            this.buttonDeleteModul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteModul.Location = new System.Drawing.Point(520, 575);
            this.buttonDeleteModul.Name = "buttonDeleteModul";
            this.buttonDeleteModul.Size = new System.Drawing.Size(70, 70);
            this.buttonDeleteModul.TabIndex = 5;
            this.buttonDeleteModul.UseVisualStyleBackColor = true;
            this.buttonDeleteModul.Click += new System.EventHandler(this.buttonDeleteModul_Click);
            // 
            // labelModul
            // 
            this.labelModul.Location = new System.Drawing.Point(110, 600);
            this.labelModul.Name = "labelModul";
            this.labelModul.Size = new System.Drawing.Size(100, 15);
            this.labelModul.TabIndex = 6;
            this.labelModul.Text = "Modul";
            // 
            // labelReset
            // 
            this.labelReset.Location = new System.Drawing.Point(10, 645);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(70, 15);
            this.labelReset.TabIndex = 7;
            this.labelReset.Text = "Reset";
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCreate
            // 
            this.labelCreate.Location = new System.Drawing.Point(340, 645);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(70, 15);
            this.labelCreate.TabIndex = 8;
            this.labelCreate.Text = "Create";
            this.labelCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(430, 645);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(70, 15);
            this.labelUpdate.TabIndex = 9;
            this.labelUpdate.Text = "Update";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDelete
            // 
            this.labelDelete.Location = new System.Drawing.Point(520, 645);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(70, 15);
            this.labelDelete.TabIndex = 10;
            this.labelDelete.Text = "Delete";
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadline
            // 
            this.labelHeadline.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeadline.Location = new System.Drawing.Point(10, 5);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(83, 25);
            this.labelHeadline.TabIndex = 28;
            this.labelHeadline.Text = "Module";
            // 
            // UCModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.labelModul);
            this.Controls.Add(this.buttonDeleteModul);
            this.Controls.Add(this.buttonUpdateModul);
            this.Controls.Add(this.buttonCreateModul);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxModul);
            this.Controls.Add(this.DGVModule);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCModule";
            this.Size = new System.Drawing.Size(1180, 785);
            ((System.ComponentModel.ISupportInitialize)(this.DGVModule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelHeadline;

        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelUpdate;

        private System.Windows.Forms.Label labelDelete;

        private System.Windows.Forms.Label labelModul;

        private System.Windows.Forms.Button buttonCreateModul;
        private System.Windows.Forms.Button buttonUpdateModul;
        private System.Windows.Forms.Button buttonDeleteModul;

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.TextBox textBoxModul;

        private System.Windows.Forms.DataGridView DGVModule;

        #endregion
    }
}