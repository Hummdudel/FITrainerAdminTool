namespace FITrainerAdminTool.TableClasses
{
    public class Modul
    {
        private int id;
        private string name;

        public Modul(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Modul(string name)
        {
            this.name = name;
        }
        
        public Modul(){}

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}