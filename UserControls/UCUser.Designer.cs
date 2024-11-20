using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCUser
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
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelReset = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVUser
            // 
            this.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUser.Location = new System.Drawing.Point(10, 35);
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.Size = new System.Drawing.Size(818, 510);
            this.DGVUser.TabIndex = 1;
            this.DGVUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUser_CellClick);
            // 
            // labelDelete
            // 
            this.labelDelete.Location = new System.Drawing.Point(520, 745);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(70, 15);
            this.labelDelete.TabIndex = 20;
            this.labelDelete.Text = "Delete";
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(430, 745);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(70, 15);
            this.labelUpdate.TabIndex = 19;
            this.labelUpdate.Text = "Update";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCreate
            // 
            this.labelCreate.Location = new System.Drawing.Point(340, 745);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(70, 15);
            this.labelCreate.TabIndex = 18;
            this.labelCreate.Text = "Create";
            this.labelCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelReset
            // 
            this.labelReset.Location = new System.Drawing.Point(10, 645);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(70, 15);
            this.labelReset.TabIndex = 17;
            this.labelReset.Text = "Reset";
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMail
            // 
            this.labelMail.Location = new System.Drawing.Point(110, 600);
            this.labelMail.Name = "labelMail";
            this.labelMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMail.Size = new System.Drawing.Size(100, 15);
            this.labelMail.TabIndex = 16;
            this.labelMail.Text = "Mail";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_remove;
            this.buttonDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteUser.Location = new System.Drawing.Point(520, 675);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(70, 70);
            this.buttonDeleteUser.TabIndex = 15;
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_update;
            this.buttonUpdateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateUser.Location = new System.Drawing.Point(430, 675);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(70, 70);
            this.buttonUpdateUser.TabIndex = 14;
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            this.buttonUpdateUser.Click += new System.EventHandler(this.buttonUpdateUser_Click);
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_add;
            this.buttonCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateUser.Location = new System.Drawing.Point(340, 675);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(70, 70);
            this.buttonCreateUser.TabIndex = 13;
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_reload;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Location = new System.Drawing.Point(10, 575);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 70);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(110, 575);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(200, 20);
            this.textBoxMail.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(340, 600);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelName.Size = new System.Drawing.Size(100, 15);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(340, 575);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 21;
            // 
            // labelPasswort
            // 
            this.labelPasswort.Location = new System.Drawing.Point(340, 645);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPasswort.Size = new System.Drawing.Size(100, 15);
            this.labelPasswort.TabIndex = 24;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(340, 620);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(200, 20);
            this.textBoxPasswort.TabIndex = 23;
            // 
            // labelClear
            // 
            this.labelClear.Location = new System.Drawing.Point(10, 745);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 15);
            this.labelClear.TabIndex = 27;
            this.labelClear.Text = "Clear";
            this.labelClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_cancel;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.Location = new System.Drawing.Point(10, 675);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 70);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelHeadline
            // 
            this.labelHeadline.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeadline.Location = new System.Drawing.Point(10, 5);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(57, 25);
            this.labelHeadline.TabIndex = 28;
            this.labelHeadline.Text = "User";
            // 
            // UCUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonUpdateUser);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.DGVUser);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCUser";
            this.Size = new System.Drawing.Size(1180, 785);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelHeadline;

        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxPasswort;

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxMail;

        private System.Windows.Forms.DataGridView DGVUser;

        #endregion
    }
}