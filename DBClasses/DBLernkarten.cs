using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FITrainerAdminTool.TableClasses;
using MySqlConnector;

namespace FITrainerAdminTool.DBClasses
{
    public class DBLernkarten : Database
    {
        private Lernkarte lernkarte;
        private static string queryAll = "CALL Read_All_Lernkarten();";
        private string queryKartenID = "CALL Read_KartenID();";
        private string queryAdminCheck = "CALL Read_Lernkarten_for_AdminCheck();";
        static List<Lernkarte> lernkartenStringListForJSON = new List<Lernkarte>();
        // static List<string> lernkartenStringList = new List<string>();

        public string QueryAll => queryAll;

        public string QueryKartenId => queryKartenID;

        public string QueryAdminCheck => queryAdminCheck;

        public static List<Lernkarte> ReadLernkartenListJSON()
        {
            DBConnect();
            
            try
            {
                command = new MySqlCommand(queryAll, dbConnection);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]) ;
                    string frage = reader["Frage"].ToString();
                    string antwort = reader["Antwort"].ToString();
                    string modul = reader["Modul"].ToString();
                    string username = reader["Erstellt von"].ToString();
                    bool adminCheck = Convert.ToBoolean(reader["Admin-Check"]);
                    bool oeffentlich = Convert.ToBoolean(reader["Öffentlich"]);


                    Lernkarte lernkarte = new Lernkarte(id, frage, antwort, modul, username, adminCheck, oeffentlich);
                    lernkartenStringListForJSON.Add(lernkarte);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            
            return lernkartenStringListForJSON;
        }
        
        // Future Enhancement: Import + Export as CSV file
        
        /*public static string[] ReadLernkartenIntoStringArray()
        {
            
            string line = "";
            
            lernkartenStringList.Add("ID,Frage,Antwort,Modul,Erstellt von,Admin-Check,Öffentlich");
            
            DBConnect();
            
            try
            {
                command = new MySqlCommand(queryAll, dbConnection);
                
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    line += reader["ID"].ToString() + ",";
                    line += reader["Frage"].ToString() + ",";
                    line += reader["Antwort"].ToString() + ",";
                    line += reader["Modul"].ToString() + ",";
                    line += reader["Erstellt von"].ToString() + ",";
                    line += reader["Admin-Check"].ToString() + ",";
                    line += reader["Öffentlich"].ToString() + ",";

                    lernkartenStringList.Add(line);
                    line = "";
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
            
            return lernkartenStringList.ToArray();
        }

        public static void Run()
        {
            
            string[] array = ReadLernkartenIntoStringArray();
            
            foreach (var line in array)
            {
                MessageBox.Show(line);
            }
        }*/
    }
}