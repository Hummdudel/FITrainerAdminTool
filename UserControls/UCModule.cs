using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCModule : UserControl
    {
        private DBModule dbModule = new DBModule();
        private Modul modul = new Modul();
        
        public UCModule()
        {
            InitializeComponent();
            ReadModule();
        }
        
        public void ReadModule()
        {
            DGVModule.DataSource = Database.ReadTable(dbModule.QueryAll).Tables[0];
            ResizeColumns();
        }

        public async void ResizeColumns()
        {
            await Task.Delay(10);
            DGVModule.Columns["ID"].Width = 25;
            DGVModule.Columns["Modul"].Width = 200;
        }

        private void DGVModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modul.Id = Convert.ToInt32(DGVModule.CurrentRow.Cells["ID"].Value);
            modul.Name = DGVModule.CurrentRow.Cells["Modul"].Value.ToString();
            textBoxModul.Text = modul.Name;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxModul.Text = modul.Name;
        }

        private void buttonCreateModul_Click(object sender, EventArgs e)
        {
            modul.Name = textBoxModul.Text;
            Database.CreateEntity(modul);
            ReadModule();
        }

        private void buttonUpdateModul_Click(object sender, EventArgs e)
        {
            modul.Name = textBoxModul.Text;
            Database.UpdateEntity(modul);
            ReadModule();
        }
        
        private void ShowSecurityQuery()
        {
            DialogResult result = MessageBox.Show(
                $"Soll das Modul {modul.Name} wirklich gelöscht werden?",
                "Bitte bestätigen:",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.OK)
            {
                Database.DeleteEntity(modul);
                ReadModule();
            }
        }

        private void buttonDeleteModul_Click(object sender, EventArgs e)
        {
            ShowSecurityQuery();
        }
    }
}