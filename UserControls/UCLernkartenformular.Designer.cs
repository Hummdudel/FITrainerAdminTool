using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCLernkartenformular
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
            this.textBoxFrage = new System.Windows.Forms.TextBox();
            this.textBoxAntwort = new System.Windows.Forms.TextBox();
            this.labelFrage = new System.Windows.Forms.Label();
            this.labelAntwort = new System.Windows.Forms.Label();
            this.comboBoxModul = new System.Windows.Forms.ComboBox();
            this.labelModul = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelReset = new System.Windows.Forms.Label();
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.checkBoxAdminCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxOeffentlich = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelClear = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFrage
            // 
            this.textBoxFrage.Location = new System.Drawing.Point(10, 170);
            this.textBoxFrage.Multiline = true;
            this.textBoxFrage.Name = "textBoxFrage";
            this.textBoxFrage.Size = new System.Drawing.Size(370, 300);
            this.textBoxFrage.TabIndex = 0;
            // 
            // textBoxAntwort
            // 
            this.textBoxAntwort.Location = new System.Drawing.Point(420, 170);
            this.textBoxAntwort.Multiline = true;
            this.textBoxAntwort.Name = "textBoxAntwort";
            this.textBoxAntwort.Size = new System.Drawing.Size(370, 300);
            this.textBoxAntwort.TabIndex = 1;
            // 
            // labelFrage
            // 
            this.labelFrage.Location = new System.Drawing.Point(10, 140);
            this.labelFrage.Name = "labelFrage";
            this.labelFrage.Size = new System.Drawing.Size(50, 15);
            this.labelFrage.TabIndex = 2;
            this.labelFrage.Text = "Frage";
            // 
            // labelAntwort
            // 
            this.labelAntwort.Location = new System.Drawing.Point(424, 140);
            this.labelAntwort.Name = "labelAntwort";
            this.labelAntwort.Size = new System.Drawing.Size(50, 15);
            this.labelAntwort.TabIndex = 3;
            this.labelAntwort.Text = "Antwort";
            // 
            // comboBoxModul
            // 
            this.comboBoxModul.FormattingEnabled = true;
            this.comboBoxModul.Location = new System.Drawing.Point(10, 520);
            this.comboBoxModul.Name = "comboBoxModul";
            this.comboBoxModul.Size = new System.Drawing.Size(200, 21);
            this.comboBoxModul.TabIndex = 4;
            // 
            // labelModul
            // 
            this.labelModul.Location = new System.Drawing.Point(10, 495);
            this.labelModul.Name = "labelModul";
            this.labelModul.Size = new System.Drawing.Size(50, 15);
            this.labelModul.TabIndex = 5;
            this.labelModul.Text = "Modul";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(250, 520);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(200, 21);
            this.comboBoxUser.TabIndex = 6;
            // 
            // labelUser
            // 
            this.labelUser.Location = new System.Drawing.Point(250, 495);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(70, 15);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Erstellt von";
            // 
            // buttonReset
            // 
            this.buttonReset.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_reload;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Location = new System.Drawing.Point(10, 575);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(70, 70);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_add;
            this.buttonCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreate.Location = new System.Drawing.Point(250, 575);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(70, 70);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_remove;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Location = new System.Drawing.Point(430, 575);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(70, 70);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelReset
            // 
            this.labelReset.Location = new System.Drawing.Point(10, 645);
            this.labelReset.Name = "labelReset";
            this.labelReset.Size = new System.Drawing.Size(70, 15);
            this.labelReset.TabIndex = 15;
            this.labelReset.Text = "Reset";
            this.labelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCreate
            // 
            this.labelCreate.Location = new System.Drawing.Point(250, 645);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(70, 15);
            this.labelCreate.TabIndex = 16;
            this.labelCreate.Text = "Create";
            this.labelCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpdate
            // 
            this.labelUpdate.Location = new System.Drawing.Point(340, 645);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(70, 15);
            this.labelUpdate.TabIndex = 17;
            this.labelUpdate.Text = "Update";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDelete
            // 
            this.labelDelete.Location = new System.Drawing.Point(430, 645);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(70, 15);
            this.labelDelete.TabIndex = 18;
            this.labelDelete.Text = "Delete";
            this.labelDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBack
            // 
            this.labelBack.Location = new System.Drawing.Point(10, 70);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(70, 15);
            this.labelBack.TabIndex = 19;
            this.labelBack.Text = "Back";
            this.labelBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_App_restart;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(10, 35);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(70, 70);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_db_update;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(340, 575);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(70, 70);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // checkBoxAdminCheck
            // 
            this.checkBoxAdminCheck.Location = new System.Drawing.Point(490, 520);
            this.checkBoxAdminCheck.Name = "checkBoxAdminCheck";
            this.checkBoxAdminCheck.Size = new System.Drawing.Size(90, 20);
            this.checkBoxAdminCheck.TabIndex = 22;
            this.checkBoxAdminCheck.Text = "Admin-Check";
            this.checkBoxAdminCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxOeffentlich
            // 
            this.checkBoxOeffentlich.Location = new System.Drawing.Point(600, 520);
            this.checkBoxOeffentlich.Name = "checkBoxOeffentlich";
            this.checkBoxOeffentlich.Size = new System.Drawing.Size(80, 20);
            this.checkBoxOeffentlich.TabIndex = 23;
            this.checkBoxOeffentlich.Text = "Öffentlich";
            this.checkBoxOeffentlich.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.BackgroundImage = global::FITrainerAdminTool.Properties.Resources.Everaldo_Crystal_Clear_Action_cancel;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClear.Location = new System.Drawing.Point(100, 575);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 70);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelClear
            // 
            this.labelClear.Location = new System.Drawing.Point(100, 645);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 15);
            this.labelClear.TabIndex = 25;
            this.labelClear.Text = "Clear";
            this.labelClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeadline
            // 
            this.labelHeadline.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadline.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHeadline.Location = new System.Drawing.Point(10, 5);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(178, 25);
            this.labelHeadline.TabIndex = 26;
            this.labelHeadline.Text = "Lernkarten-Editor";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "zurück zur Übersicht";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCLernkartenformular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelClear);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxOeffentlich);
            this.Controls.Add(this.checkBoxAdminCheck);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.labelReset);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.labelModul);
            this.Controls.Add(this.comboBoxModul);
            this.Controls.Add(this.labelAntwort);
            this.Controls.Add(this.labelFrage);
            this.Controls.Add(this.textBoxAntwort);
            this.Controls.Add(this.textBoxFrage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLernkartenformular";
            this.Size = new System.Drawing.Size(1180, 735);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelHeadline;

        private System.Windows.Forms.Label labelClear;

        private System.Windows.Forms.Button buttonClear;

        private System.Windows.Forms.CheckBox checkBoxAdminCheck;
        private System.Windows.Forms.CheckBox checkBoxOeffentlich;

        private System.Windows.Forms.Button buttonUpdate;

        private System.Windows.Forms.Button buttonBack;

        private System.Windows.Forms.Label labelReset;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelDelete;

        private System.Windows.Forms.Label labelBack;

        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonCreate;

        private System.Windows.Forms.Button buttonReset;

        private System.Windows.Forms.Label labelModul;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label labelUser;

        private System.Windows.Forms.ComboBox comboBoxModul;

        private System.Windows.Forms.TextBox textBoxAntwort;
        private System.Windows.Forms.Label labelFrage;
        private System.Windows.Forms.Label labelAntwort;

        private System.Windows.Forms.TextBox textBoxFrage;

        #endregion
    }
}