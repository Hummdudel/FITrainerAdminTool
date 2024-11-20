using System.ComponentModel;

namespace FITrainerAdminTool.UserControls
{
    partial class UCInfo
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDanksagung = new System.Windows.Forms.Label();
            this.labelIcons = new System.Windows.Forms.Label();
            this.linkLabelIconArchive = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(480, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(220, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "FI-Trainer Admin Tool";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(555, 250);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(70, 12);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version 1.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entwickelt in C# von Lars Lachmann";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDanksagung
            // 
            this.labelDanksagung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanksagung.Location = new System.Drawing.Point(440, 400);
            this.labelDanksagung.Name = "labelDanksagung";
            this.labelDanksagung.Size = new System.Drawing.Size(300, 48);
            this.labelDanksagung.TabIndex = 3;
            this.labelDanksagung.Text = "Vielen Dank an Herrn Sahin für die Grundlagen in OOP und C# sowie für die großart" + "ige fachliche und mentale Unterstützung während des Projekts!";
            this.labelDanksagung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIcons
            // 
            this.labelIcons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIcons.Location = new System.Drawing.Point(440, 460);
            this.labelIcons.Name = "labelIcons";
            this.labelIcons.Size = new System.Drawing.Size(300, 32);
            this.labelIcons.TabIndex = 4;
            this.labelIcons.Text = "Vielen Dank für die Icons (Crystal Clear Icons Pack) von Everaldo (LGPL OpenSourc" + "e)!";
            this.labelIcons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelIconArchive
            // 
            this.linkLabelIconArchive.Location = new System.Drawing.Point(440, 490);
            this.linkLabelIconArchive.Name = "linkLabelIconArchive";
            this.linkLabelIconArchive.Size = new System.Drawing.Size(300, 13);
            this.linkLabelIconArchive.TabIndex = 5;
            this.linkLabelIconArchive.TabStop = true;
            this.linkLabelIconArchive.Text = "www.iconarchive.com";
            this.linkLabelIconArchive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelIconArchive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelIconArchive_LinkClicked);
            // 
            // UCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelIconArchive);
            this.Controls.Add(this.labelIcons);
            this.Controls.Add(this.labelDanksagung);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelName);
            this.Name = "UCInfo";
            this.Size = new System.Drawing.Size(1180, 785);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.LinkLabel linkLabelIconArchive;

        private System.Windows.Forms.Label labelIcons;

        private System.Windows.Forms.Label labelDanksagung;

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelName;

        #endregion
    }
}