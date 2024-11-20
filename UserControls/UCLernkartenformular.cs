using System;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCLernkartenformular : UserControl
    {
        private Lernkarte lernkarte = new Lernkarte();

        public UCLernkartenformular()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        public void SetData(Lernkarte lernkarte)
        {
            textBoxFrage.Text = lernkarte.Frage;
            textBoxAntwort.Text = lernkarte.Antwort;
            comboBoxModul.Text = lernkarte.Modulname;
            comboBoxUser.Text = lernkarte.Username;
            checkBoxAdminCheck.Checked = lernkarte.AdminCheck;
            checkBoxOeffentlich.Checked = lernkarte.Oeffentlich;

            this.lernkarte = lernkarte;
        }

        public void TransmitData()
        {
            lernkarte.Frage = textBoxFrage.Text;
            lernkarte.Antwort = textBoxAntwort.Text;
            lernkarte.Modulname = comboBoxModul.Text;
            lernkarte.Username = comboBoxUser.Text;
            lernkarte.AdminCheck = checkBoxAdminCheck.Checked;
            lernkarte.Oeffentlich = checkBoxOeffentlich.Checked;
        }

        public void FillComboBoxes()
        {
            DBModule dbModule = new DBModule();
            DBUser dbUser = new DBUser();
            
            string[] installModul = DBModule.ReadColumn(dbModule.QueryModulnamen);
            comboBoxModul.Items.AddRange(installModul);
            Controls.Add(comboBoxModul);

            string[] installUser = DBUser.ReadColumn(dbUser.QueryUsernamen);
            comboBoxUser.Items.AddRange(installUser);
            Controls.Add(comboBoxUser);
        }
        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            UCLernkarten ucLernkarten = new UCLernkarten(MainForm.instance);
            MainForm.instance.ChangeUserControl(ucLernkarten);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetData(lernkarte);
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFrage.Text = "";
            textBoxAntwort.Text = "";
            checkBoxAdminCheck.Checked = false;
            checkBoxOeffentlich.Checked = false;
        }
        
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.CreateEntity(lernkarte);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.UpdateEntity(lernkarte);
        }
        
        private void ShowSecurityQuery()
        {
            DialogResult result = MessageBox.Show(
                "Soll die Lernkarte wirklich gelöscht werden?",
                "Bitte bestätigen:",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.OK)
            {
                Database.DeleteEntity(lernkarte);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ShowSecurityQuery();
        }
    }
}