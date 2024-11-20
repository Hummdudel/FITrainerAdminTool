namespace FITrainerAdminTool.TableClasses
{
    public class User
    {
        private int id;
        private string mail;
        private string name;
        private string passwort;

        public User(int id, string mail, string name, string passwort)
        {
            this.id = id;
            this.mail = mail;
            this.name = name;
            this.passwort = passwort;
        }

        public User(string mail, string name, string passwort)
        {
            this.mail = mail;
            this.name = name;
            this.passwort = passwort;
        }
        
        public User(){}

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Mail
        {
            get => mail;
            set => mail = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Passwort
        {
            get => passwort;
            set => passwort = value;
        }
    }
}