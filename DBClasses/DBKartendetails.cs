using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.DBClasses
{
    public class DBKartendetails : Database
    {
        private Kartendetail kartendetail;
        private string queryAll = "CALL Read_All_Kartendetails();";

        public string QueryAll => queryAll;
    }
}