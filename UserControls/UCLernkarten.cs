using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCLernkarten : UserControl
    {
        private MainForm mainForm;
        private DBLernkarten dbLernkarten = new DBLernkarten();
        private Lernkarte lernkarte = new Lernkarte();
        private static bool showLernkartenForAdminCheck = false;

        public UCLernkarten(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            
            if (showLernkartenForAdminCheck)
            {
                ReadLernkartenForAdminCheck();
            }
            else
            {
                ReadLernkarten();
            }
        }

        public Lernkarte Lernkarte => lernkarte;

        public void ReadLernkarten()
        {
            DGVLernkarten.DataSource = Database.ReadTable(dbLernkarten.QueryAll).Tables[0];
            ResizeColumns();
        }

        public void ReadLernkartenForAdminCheck()
        {
            DGVLernkarten.DataSource = Database.ReadTable(dbLernkarten.QueryAdminCheck).Tables[0];
            ResizeColumns();
        }

        public async void ResizeColumns()
        {
            await Task.Delay(10);
            DGVLernkarten.Columns["ID"].Width = 25;
            DGVLernkarten.Columns["Frage"].Width = 400;
            DGVLernkarten.Columns["Antwort"].Width = 400;
            DGVLernkarten.Columns["Modul"].Width = 120;
            DGVLernkarten.Columns["Erstellt von"].Width = 75;
            DGVLernkarten.Columns["Admin-Check"].Width = 40;
            DGVLernkarten.Columns["Öffentlich"].Width = 40;
        }

        private void DGVLernkarten_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UCLernkartenformular ucLernkartenformular = new UCLernkartenformular();
            
            lernkarte.Id = Convert.ToInt32(DGVLernkarten.CurrentRow.Cells["ID"].Value);
            lernkarte.Frage = DGVLernkarten.CurrentRow.Cells["Frage"].Value.ToString();
            lernkarte.Antwort = DGVLernkarten.CurrentRow.Cells["Antwort"].Value.ToString();
            lernkarte.Modulname = DGVLernkarten.CurrentRow.Cells["Modul"].Value.ToString();
            lernkarte.Username = DGVLernkarten.CurrentRow.Cells["Erstellt von"].Value.ToString();
            lernkarte.AdminCheck = Convert.ToBoolean(DGVLernkarten.CurrentRow.Cells["Admin-Check"].Value);
            lernkarte.Oeffentlich = Convert.ToBoolean(DGVLernkarten.CurrentRow.Cells["Öffentlich"].Value);
            
            ucLernkartenformular.SetData(lernkarte);
            
            mainForm.ChangeUserControl(ucLernkartenformular);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string fileName = openFileDialog1.FileName;

                try
                {
                    FileOperations.ImportLernkartenFromJson(fileName);
                    MessageBox.Show("Die Lernkarten aus der Json-Datei wurden erfolgreich importiert.");
                    ReadLernkarten();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;

                try
                {
                    FileOperations.ExportLernkartenToJson(fileName);
                    MessageBox.Show("Die Lernkarten wurden erfolgreich als Json-Datei exportiert.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonAdminCheck_Click(object sender, EventArgs e)
        {
            ReadLernkartenForAdminCheck();
            showLernkartenForAdminCheck = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadLernkarten();
            showLernkartenForAdminCheck = false;
        }
    }
}