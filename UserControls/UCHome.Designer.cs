using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCHome
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
            this.labelHeadline = new System.Windows.Forms.Label();
            this.linkLabelFITRainer = new System.Windows.Forms.LinkLabel();
            this.containerControl1 = new System.Windows.Forms.ContainerControl();
            this.labelKartendetails = new System.Windows.Forms.Label();
            this.labelModule = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelLernkarten = new System.Windows.Forms.Label();
            this.buttonKartendetails = new System.Windows.Forms.Button();
            this.buttonModule = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonLernkarten = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.containerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeadline
            // 
            this.labelHeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.Location = new System.Drawing.Point(0, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(1180, 103);
            this.labelHeadline.TabIndex = 0;
            this.labelHeadline.Text = "Willkommen zum Admin-Tool für den Fachinformatik-Trainer!";
            this.labelHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelFITRainer
            // 
            this.linkLabelFITRainer.Location = new System.Drawing.Point(523, 120);
            this.linkLabelFITRainer.Name = "linkLabelFITRainer";
            this.linkLabelFITRainer.Size = new System.Drawing.Size(134, 15);
            this.linkLabelFITRainer.TabIndex = 1;
            this.linkLabelFITRainer.TabStop = true;
            this.linkLabelFITRainer.Text = "Hier geht es zum FI-Trainer";
            this.linkLabelFITRainer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFITRainer_LinkClicked);
            // 
            // containerControl1
            // 
            this.containerControl1.Controls.Add(this.labelKartendetails);
            this.containerControl1.Controls.Add(this.labelModule);
            this.containerControl1.Controls.Add(this.labelUser);
            this.containerControl1.Controls.Add(this.labelLernkarten);
            this.containerControl1.Controls.Add(this.buttonKartendetails);
            this.containerControl1.Controls.Add(this.buttonModule);
            this.containerControl1.Controls.Add(this.buttonUser);
            this.containerControl1.Controls.Add(this.buttonLernkarten);
            this.containerControl1.Location = new System.Drawing.Point(375, 350);
            this.containerControl1.Name = "containerControl1";
            this.containerControl1.Size = new System.Drawing.Size(430, 85);
            this.containerControl1.TabIndex = 2;
            this.containerControl1.Text = "containerControl1";
            // 
            // labelKartendetails
            // 
            this.labelKartendetails.Location = new System.Drawing.Point(360, 70);
            this.labelKartendetails.Name = "labelKartendetails";
            this.labelKartendetails.Size = new System.Drawing.Size(70, 15);
            this.labelKartendetails.TabIndex = 46;
            this.labelKartendetails.Text = "Kartendetails";
            this.labelKartendetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModule
            // 
            this.labelModule.Location = new System.Drawing.Point(240, 70);
            this.labelModule.Name = "labelModule";
            this.labelModule.Size = new System.Drawing.Size(70, 15);
            this.labelModule.TabIndex = 45;
            this.labelModule.Text = "Module";
            this.labelModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(120, 70);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(70, 15);
            this.labelUser.TabIndex = 44;
            this.labelUser.Text = "User";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLernkarten
            // 
            this.labelLernkarten.Location = new System.Drawing.Point(0, 70);
            this.labelLernkarten.Name = "labelLernkarten";
            this.labelLernkarten.Size = new System.Drawing.Size(70, 15);
            this.labelLernkarten.TabIndex = 43;
            this.labelLernkarten.Text = "Lernkarten";
            this.labelLernkarten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKartendetails
            // 
            this.buttonKartendetails.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_edit;
            this.buttonKartendetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKartendetails.Location = new System.Drawing.Point(360, 0);
            this.buttonKartendetails.Name = "buttonKartendetails";
            this.buttonKartendetails.Size = new System.Drawing.Size(70, 70);
            this.buttonKartendetails.TabIndex = 42;
            this.buttonKartendetails.UseVisualStyleBackColor = true;
            this.buttonKartendetails.Click += new System.EventHandler(this.buttonKartendetails_Click);
            // 
            // buttonModule
            // 
            this.buttonModule.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_view_tree;
            this.buttonModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule.Location = new System.Drawing.Point(240, 0);
            this.buttonModule.Name = "buttonModule";
            this.buttonModule.Size = new System.Drawing.Size(70, 70);
            this.buttonModule.TabIndex = 41;
            this.buttonModule.UseVisualStyleBackColor = true;
            this.buttonModule.Click += new System.EventHandler(this.buttonModule_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_login_manager;
            this.buttonUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUser.Location = new System.Drawing.Point(120, 0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(70, 70);
            this.buttonUser.TabIndex = 40;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonLernkarten
            // 
            this.buttonLernkarten.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_file_manager;
            this.buttonLernkarten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLernkarten.Location = new System.Drawing.Point(0, 0);
            this.buttonLernkarten.Name = "buttonLernkarten";
            this.buttonLernkarten.Size = new System.Drawing.Size(70, 70);
            this.buttonLernkarten.TabIndex = 39;
            this.buttonLernkarten.UseVisualStyleBackColor = true;
            this.buttonLernkarten.Click += new System.EventHandler(this.buttonLernkarten_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verwaltung der Tabellen:";
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Mimetype_readme;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.Location = new System.Drawing.Point(555, 630);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(70, 70);
            this.buttonInfo.TabIndex = 40;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(555, 700);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(70, 15);
            this.labelInfo.TabIndex = 44;
            this.labelInfo.Text = "Info";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.containerControl1);
            this.Controls.Add(this.linkLabelFITRainer);
            this.Controls.Add(this.labelHeadline);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1180, 785);
            this.containerControl1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelInfo;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label labelModule;
        private System.Windows.Forms.Label labelKartendetails;

        private System.Windows.Forms.Label labelLernkarten;
        private System.Windows.Forms.Label labelUser;

        private System.Windows.Forms.Button buttonLernkarten;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonModule;
        private System.Windows.Forms.Button buttonKartendetails;

        private System.Windows.Forms.ContainerControl containerControl1;

        private System.Windows.Forms.LinkLabel linkLabelFITRainer;

        private System.Windows.Forms.Label labelHeadline;

        #endregion
    }
}