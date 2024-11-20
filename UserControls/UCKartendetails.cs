using System;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCKartendetails : UserControl
    {
        private DBKartendetails dbKartendetails = new DBKartendetails();
        private Kartendetail kartendetail = new Kartendetail();
        
        public UCKartendetails()
        {
            InitializeComponent();
            ReadKartendetails();
            FillComboBoxes();
        }

        public void SetData(Kartendetail kartendetail)
        {
            comboBoxUsername.Text = kartendetail.Username;
            comboBoxKartenID.Text = kartendetail.Kartennr.ToString();
            comboBoxLernstufe.Text = kartendetail.Lernstufe.ToString();

            this.kartendetail = kartendetail;
        }
        
        public void TransmitData()
        {
            kartendetail.Kartennr = Convert.ToInt32(comboBoxKartenID.Text);
            kartendetail.Username = comboBoxUsername.Text;
            kartendetail.Lernstufe = Convert.ToInt32(comboBoxLernstufe.Text);
        }

        public void FillComboBoxes()
        {
            DBUser dbUser = new DBUser();
            DBLernkarten dbLernkarten = new DBLernkarten();
            
            string[] installUsername = DBUser.ReadColumn(dbUser.QueryUsernamen);
            comboBoxUsername.Items.AddRange(installUsername);
            Controls.Add(comboBoxUsername);

            string[] installKartenID = DBKartendetails.ReadColumn(dbLernkarten.QueryKartenId);
            comboBoxKartenID.Items.AddRange(installKartenID);
            Controls.Add(comboBoxKartenID);

            string[] installLernstufe = { "0", "1", "2", "3", "4" };
            comboBoxLernstufe.Items.AddRange(installLernstufe);
            Controls.Add(comboBoxLernstufe);
        }

        public void ReadKartendetails()
        {
            DGVKartendetails.DataSource = Database.ReadTable(dbKartendetails.QueryAll).Tables[0];
        }

        private void DGVKartendetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kartendetail.Username = DGVKartendetails.CurrentRow.Cells["Username"].Value.ToString();
            kartendetail.Kartennr =
                Convert.ToInt32(DGVKartendetails.CurrentRow.Cells["Karten-ID"].Value);
            kartendetail.Lernstufe = Convert.ToInt32(DGVKartendetails.CurrentRow.Cells["Lernstufe"].Value);
            
            SetData(kartendetail);
        }

        private void buttonCreateKartendetail_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.CreateEntity(kartendetail);
            ReadKartendetails();
        }

        private void buttonUpdateKartendetail_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.UpdateEntity(kartendetail);
            ReadKartendetails();
        }
        
        private void ShowSecurityQuery()
        {
            DialogResult result = MessageBox.Show(
                $"Soll das Kartendetail wirklich gelöscht werden?",
                "Bitte bestätigen:",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.OK)
            {
                Database.DeleteEntity(kartendetail);
                ReadKartendetails();
            }
        }

        private void buttonDeleteKartendetail_Click(object sender, EventArgs e)
        {
            ShowSecurityQuery();
        }
    }
}