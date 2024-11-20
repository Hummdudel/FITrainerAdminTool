using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FITrainerAdminTool.UserControls;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FITrainerAdminTool
{
    public partial class MainForm : MaterialForm
    {
        // Singleton
        public static MainForm instance;
        
        private readonly MaterialSkinManager materialSkinManager;

        private UCHome ucHome = new UCHome();

        public MainForm()
        {
            InitializeComponent();

            instance = this;
            
            ChangeUserControl(ucHome);
        }

        public void ChangeUserControl(UserControl newUserControl)
        {
            panelContainer.Controls.Clear();
            newUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(newUserControl);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            ChangeUserControl(ucHome);
        }

        private void buttonLernkarten_Click (object sender, EventArgs e)
        {
            UCLernkarten ucLernkarten = new UCLernkarten(this);
            ChangeUserControl(ucLernkarten);
        }

        private void buttonModule_Click(object sender, EventArgs e)
        {
            UCModule ucModule = new UCModule();
            ChangeUserControl(ucModule);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            UCUser ucUser = new UCUser();
            ChangeUserControl(ucUser);
        }

        private void buttonKartendetails_Click(object sender, EventArgs e)
        {
            UCKartendetails ucKartendetails = new UCKartendetails();
            ChangeUserControl(ucKartendetails);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            UCInfo ucInfo = new UCInfo();
            ChangeUserControl(ucInfo);
        }
    }
}