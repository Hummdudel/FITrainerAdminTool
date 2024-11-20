using System;
using System.Windows.Forms;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void linkLabelFITRainer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelFITRainer.LinkVisited = true;
            System.Diagnostics.Process.Start("https://fi-trainer.de");
        }

        private void buttonLernkarten_Click(object sender, EventArgs e)
        {
            UCLernkarten ucLernkarten = new UCLernkarten(MainForm.instance);
            MainForm.instance.ChangeUserControl(ucLernkarten);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            UCUser ucUser = new UCUser();
            MainForm.instance.ChangeUserControl(ucUser);
        }

        private void buttonModule_Click(object sender, EventArgs e)
        {
            UCModule ucModule = new UCModule();
            MainForm.instance.ChangeUserControl(ucModule);
        }

        private void buttonKartendetails_Click(object sender, EventArgs e)
        {
            UCKartendetails ucKartendetails = new UCKartendetails();
            MainForm.instance.ChangeUserControl(ucKartendetails);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            UCInfo ucInfo = new UCInfo();
            MainForm.instance.ChangeUserControl(ucInfo);
        }
    }
}