namespace FITrainerAdminTool.TableClasses
{
    public class Lernkarte
    {
        
        private int id;
        private string frage;
        private string antwort;
        private string modulname;
        private string username;
        private bool adminCheck;
        private bool oeffentlich;

        public Lernkarte(int id, string frage, string antwort, string modulname, string username, bool adminCheck, bool oeffentlich)
        {
            this.id = id;
            this.frage = frage;
            this.antwort = antwort;
            this.modulname = modulname;
            this.username = username;
            this.adminCheck = adminCheck;
            this.oeffentlich = oeffentlich;
        }

        public Lernkarte(string frage, string antwort, string modulname, string username, bool adminCheck, bool oeffentlich)
        {
            this.frage = frage;
            this.antwort = antwort;
            this.modulname = modulname;
            this.username = username;
            this.adminCheck = adminCheck;
            this.oeffentlich = oeffentlich;
        }
        
        public Lernkarte(){}

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Frage
        {
            get => frage;
            set => frage = value;
        }

        public string Antwort
        {
            get => antwort;
            set => antwort = value;
        }

        public string Modulname
        {
            get => modulname;
            set => modulname = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public bool AdminCheck
        {
            get => adminCheck;
            set => adminCheck = value;
        }

        public bool Oeffentlich
        {
            get => oeffentlich;
            set => oeffentlich = value;
        }
    }
}