using System;
using System.Windows.Forms;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCInfo : UserControl
    {
        public UCInfo()
        {
            InitializeComponent();
        }

        private void linkLabelIconArchive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelIconArchive.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.iconarchive.com/show/crystal-clear-icons-by-everaldo.html");
        }
    }
}