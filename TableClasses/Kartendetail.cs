namespace FITrainerAdminTool.TableClasses
{
    public class Kartendetail
    {
        private int kartennr;
        private string username;
        private int lernstufe;

        public Kartendetail(int kartennr, string username, int lernstufe)
        {
            this.kartennr = kartennr;
            this.username = username;
            this.lernstufe = lernstufe;
        }
        
        public Kartendetail(){}

        public int Kartennr
        {
            get => kartennr;
            set => kartennr = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public int Lernstufe
        {
            get => lernstufe;
            set => lernstufe = value;
        }
    }
}