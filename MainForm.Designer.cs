namespace FITrainerAdminTool
{
    partial class MainForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonLernkarten = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonModule = new System.Windows.Forms.Button();
            this.buttonKartendetails = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelLernkarten = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelModule = new System.Windows.Forms.Label();
            this.labelKartendetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(120, 65);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1180, 785);
            this.panelContainer.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_home_2;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Location = new System.Drawing.Point(10, 100);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(100, 100);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonLernkarten
            // 
            this.buttonLernkarten.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_file_manager;
            this.buttonLernkarten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLernkarten.Location = new System.Drawing.Point(10, 220);
            this.buttonLernkarten.Name = "buttonLernkarten";
            this.buttonLernkarten.Size = new System.Drawing.Size(100, 100);
            this.buttonLernkarten.TabIndex = 2;
            this.buttonLernkarten.UseVisualStyleBackColor = true;
            this.buttonLernkarten.Click += new System.EventHandler(this.buttonLernkarten_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_login_manager;
            this.buttonUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUser.Location = new System.Drawing.Point(10, 350);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(100, 100);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonModule
            // 
            this.buttonModule.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_view_tree;
            this.buttonModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonModule.Location = new System.Drawing.Point(10, 480);
            this.buttonModule.Name = "buttonModule";
            this.buttonModule.Size = new System.Drawing.Size(100, 100);
            this.buttonModule.TabIndex = 4;
            this.buttonModule.UseVisualStyleBackColor = true;
            this.buttonModule.Click += new System.EventHandler(this.buttonModule_Click);
            // 
            // buttonKartendetails
            // 
            this.buttonKartendetails.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_edit;
            this.buttonKartendetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonKartendetails.Location = new System.Drawing.Point(10, 610);
            this.buttonKartendetails.Name = "buttonKartendetails";
            this.buttonKartendetails.Size = new System.Drawing.Size(100, 100);
            this.buttonKartendetails.TabIndex = 5;
            this.buttonKartendetails.UseVisualStyleBackColor = true;
            this.buttonKartendetails.Click += new System.EventHandler(this.buttonKartendetails_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Mimetype_readme;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInfo.Location = new System.Drawing.Point(10, 744);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(100, 100);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelLernkarten
            // 
            this.labelLernkarten.Location = new System.Drawing.Point(10, 320);
            this.labelLernkarten.Name = "labelLernkarten";
            this.labelLernkarten.Size = new System.Drawing.Size(100, 12);
            this.labelLernkarten.TabIndex = 8;
            this.labelLernkarten.Text = "Lernkarten";
            this.labelLernkarten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(10, 450);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(100, 12);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "User";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModule
            // 
            this.labelModule.Location = new System.Drawing.Point(10, 580);
            this.labelModule.Name = "labelModule";
            this.labelModule.Size = new System.Drawing.Size(100, 12);
            this.labelModule.TabIndex = 10;
            this.labelModule.Text = "Module";
            this.labelModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKartendetails
            // 
            this.labelKartendetails.Location = new System.Drawing.Point(10, 710);
            this.labelKartendetails.Name = "labelKartendetails";
            this.labelKartendetails.Size = new System.Drawing.Size(100, 12);
            this.labelKartendetails.TabIndex = 11;
            this.labelKartendetails.Text = "Kartendetails";
            this.labelKartendetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.labelKartendetails);
            this.Controls.Add(this.labelLernkarten);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelModule);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonKartendetails);
            this.Controls.Add(this.buttonModule);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonLernkarten);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panelContainer);
            this.Name = "MainForm";
            this.Text = "FI-Trainer Admin Tool";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelKartendetails;

        private System.Windows.Forms.Label labelLernkarten;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelModule;

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonLernkarten;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonModule;
        private System.Windows.Forms.Button buttonKartendetails;
        private System.Windows.Forms.Button buttonInfo;

        private System.Windows.Forms.Panel panelContainer;

        #endregion
    }
}