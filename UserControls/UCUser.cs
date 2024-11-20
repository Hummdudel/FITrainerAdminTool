using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.UserControls
{
    public partial class UCUser : UserControl
    {
        private DBUser dbUser = new DBUser();
        private User user = new User();
        
        public UCUser()
        {
            InitializeComponent();
            ReadUsers();
        }

        public void SetData(User user)
        {
            textBoxMail.Text = user.Mail;
            textBoxName.Text = user.Name;
            textBoxPasswort.Text = user.Passwort;

            this.user = user;
        }
        
        public void TransmitData()
        {
            user.Mail = textBoxMail.Text;
            user.Name = textBoxName.Text;
            user.Passwort = textBoxPasswort.Text;
        }

        public void ReadUsers()
        {
            DGVUser.DataSource = Database.ReadTable(dbUser.QueryAll).Tables[0];
            ResizeColumns();
        }
        
        public async void ResizeColumns()
        {
            await Task.Delay(10);
            DGVUser.Columns["ID"].Width = 25;
            DGVUser.Columns["Mail"].Width = 200;
            DGVUser.Columns["Name"].Width = 150;
            DGVUser.Columns["Passwort"].Width = 400;
        }

        private void DGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user.Id = Convert.ToInt32(DGVUser.CurrentRow.Cells["ID"].Value);
            user.Mail = DGVUser.CurrentRow.Cells["Mail"].Value.ToString();
            user.Name = DGVUser.CurrentRow.Cells["Name"].Value.ToString();
            user.Passwort = DGVUser.CurrentRow.Cells["Passwort"].Value.ToString();

            SetData(user);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetData(user);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMail.Text = "";
            textBoxName.Text = "";
            textBoxPasswort.Text = "";
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.CreateEntity(user);
            ReadUsers();
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            TransmitData();
            Database.UpdateEntity(user);
            ReadUsers();
        }
        
        private void ShowSecurityQuery()
        {
            DialogResult result = MessageBox.Show(
                $"Soll der User {user.Name} wirklich gelöscht werden?",
                "Bitte bestätigen:",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.OK)
            {
                Database.DeleteEntity(user);
                ReadUsers();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            ShowSecurityQuery();
        }
    }
}