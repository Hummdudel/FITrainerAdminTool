using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCLernkarten
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
            this.DGVLernkarten = new System.Windows.Forms.DataGridView();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.labelExport = new System.Windows.Forms.Label();
            this.labelImport = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonAdminCheck = new System.Windows.Forms.Button();
            this.labelAdminCheck = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLernkarten)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLernkarten
            // 
            this.DGVLernkarten.AllowUserToOrderColumns = true;
            this.DGVLernkarten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLernkarten.Location = new System.Drawing.Point(10, 80);
            this.DGVLernkarten.Name = "DGVLernkarten";
            this.DGVLernkarten.Size = new System.Drawing.Size(1160, 699);
            this.DGVLernkarten.TabIndex = 0;
            this.DGVLernkarten.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLernkarten_CellClick);
            // 
            // labelHeadline
            // 
            this.labelHeadline.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeadline.Location = new System.Drawing.Point(10, 5);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(115, 25);
            this.labelHeadline.TabIndex = 27;
            this.labelHeadline.Text = "Lernkarten";
            // 
            // buttonImport
            // 
            this.buttonImport.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_arrow_down;
            this.buttonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonImport.Location = new System.Drawing.Point(930, 5);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(70, 70);
            this.buttonImport.TabIndex = 31;
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_arrow_up;
            this.buttonExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExport.Location = new System.Drawing.Point(1060, 5);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(70, 70);
            this.buttonExport.TabIndex = 32;
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // labelExport
            // 
            this.labelExport.Location = new System.Drawing.Point(1133, 60);
            this.labelExport.Name = "labelExport";
            this.labelExport.Size = new System.Drawing.Size(37, 15);
            this.labelExport.TabIndex = 34;
            this.labelExport.Text = "Export";
            // 
            // labelImport
            // 
            this.labelImport.Location = new System.Drawing.Point(1005, 60);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(36, 15);
            this.labelImport.TabIndex = 35;
            this.labelImport.Text = "Import";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\IT\\Download\\";
            this.saveFileDialog1.Tag = "";
            // 
            // buttonAdminCheck
            // 
            this.buttonAdminCheck.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_lists;
            this.buttonAdminCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdminCheck.Location = new System.Drawing.Point(700, 5);
            this.buttonAdminCheck.Name = "buttonAdminCheck";
            this.buttonAdminCheck.Size = new System.Drawing.Size(70, 70);
            this.buttonAdminCheck.TabIndex = 36;
            this.buttonAdminCheck.UseVisualStyleBackColor = true;
            this.buttonAdminCheck.Click += new System.EventHandler(this.buttonAdminCheck_Click);
            // 
            // labelAdminCheck
            // 
            this.labelAdminCheck.Location = new System.Drawing.Point(775, 49);
            this.labelAdminCheck.Name = "labelAdminCheck";
            this.labelAdminCheck.Size = new System.Drawing.Size(70, 26);
            this.labelAdminCheck.TabIndex = 37;
            this.labelAdminCheck.Text = "Karten für Admin-Check";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_file_manager;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(570, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(645, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "alle Karten";
            // 
            // UCLernkarten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAdminCheck);
            this.Controls.Add(this.buttonAdminCheck);
            this.Controls.Add(this.labelImport);
            this.Controls.Add(this.labelExport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.DGVLernkarten);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLernkarten";
            this.Size = new System.Drawing.Size(1180, 785);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLernkarten)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonAdminCheck;
        private System.Windows.Forms.Label labelAdminCheck;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Label labelImport;

        private System.Windows.Forms.Label labelExport;

        private System.Windows.Forms.Button buttonExport;

        private System.Windows.Forms.Button buttonImport;

        private System.Windows.Forms.Label labelHeadline;

        private System.Windows.Forms.DataGridView DGVLernkarten;

        #endregion
    }
}