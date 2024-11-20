using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool.DBClasses
{
    public class DBUser : Database
    {
        private User user;
        private string queryAll = "CALL Read_All_Users();";
        private string queryUsernamen = "CALL Read_Usernamen();";

        public string QueryAll => queryAll;

        public string QueryUsernamen => queryUsernamen;
        
        
    }
}