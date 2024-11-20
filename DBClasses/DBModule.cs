using System;
using FITrainerAdminTool.TableClasses;
using MySqlConnector;

namespace FITrainerAdminTool.DBClasses
{
    public class DBModule : Database
    {
        private Modul modul;
        private string queryAll = "CALL Read_All_Module();";
        private string queryModulnamen = "CALL Read_Modulnamen();";

        public string QueryAll => queryAll;

        public string QueryModulnamen => queryModulnamen;
    }
}