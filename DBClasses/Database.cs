using System;
using System.Data;
using System.Windows.Forms;
using FITrainerAdminTool.TableClasses;
using MySqlConnector;

namespace FITrainerAdminTool.DBClasses
{
    public class Database
    {
        private static string dBConnectionString = 
            "datasource=127.0.0.1;port=3306;username=root;password=;database=fitrainer";
        protected static MySqlConnection dbConnection = null;
        protected static MySqlCommand command = null;
        protected static DataSet dataSet;
        protected static MySqlDataAdapter adapter;
        
        public static void DBConnect()
        {
            try
            {
                dbConnection = new MySqlConnection(dBConnectionString);
                dbConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        // CREATE

        public static void CreateEntity<T>(T input, bool import = false)
        {
            string sql = "";
            string message = "";
            
            DBConnect();

            try
            {
                if (input is Lernkarte)
                {
                    Lernkarte lernkarte = input as Lernkarte;

                    sql = "CALL Insert_Lernkarte(@frage, @antwort, @modulname, @username, @adminCheck, @oeffentlich);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@frage", lernkarte.Frage);
                    command.Parameters.AddWithValue("@antwort", lernkarte.Antwort);
                    command.Parameters.AddWithValue("@modulname", lernkarte.Modulname);
                    command.Parameters.AddWithValue("@username", lernkarte.Username);
                    command.Parameters.AddWithValue("@adminCheck", lernkarte.AdminCheck);
                    command.Parameters.AddWithValue("@oeffentlich", lernkarte.Oeffentlich);
                    message = "Die neue Lernkarte wurde erfolgreich angelegt.";
                }
                else if (input is User)
                {
                    User user = input as User;

                    sql = "CALL Insert_User(@mail, @username, @passwort);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@mail", user.Mail);
                    command.Parameters.AddWithValue("@username", user.Name);
                    command.Parameters.AddWithValue("@passwort", user.Passwort);
                    message = $"Der neue User {user.Name} wurde erfolgreich angelegt.";
                }
                else if (input is Modul)
                {
                    Modul modul = input as Modul;

                    sql = "CALL Insert_Modul(@modulname);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@modulname", modul.Name);
                    message = $"Das Modul {modul.Name} wurde erfolgreich angelegt.";
                }
                else if (input is Kartendetail)
                {
                    Kartendetail kartendetail = input as Kartendetail;

                    sql = "CALL Insert_Kartendetail(@kartennr, @username, @lernstufe);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@kartennr", kartendetail.Kartennr);
                    command.Parameters.AddWithValue("@username", kartendetail.Username);
                    command.Parameters.AddWithValue("lernstufe", kartendetail.Lernstufe);
                    message = "Das neue Kartendetail wurde erfolgreich angelegt.";
                }

                command.ExecuteNonQuery();
                if (!import)
                {
                    MessageBox.Show(message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        
        // READ

        public static DataSet ReadTable(string query)
        {
            DBConnect();

            try
            {
                command = new MySqlCommand(query, dbConnection);
                adapter = new MySqlDataAdapter(command);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                return dataSet;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }

            return null;
        }

        public static string[] ReadColumn(string query)
        {
            DBConnect();

            try
            {
                command = new MySqlCommand(query, dbConnection);
                adapter = new MySqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    DataTable table = dataSet.Tables[0];
                    string[] columnValues = new string[table.Rows.Count];

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        columnValues[i] = table.Rows[i][0].ToString();
                    }

                    return columnValues;
                }
                else
                {
                    return new string[0];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dbConnection.Close();
            }
        }
        
        // UPDATE

        public static void UpdateEntity<T>(T input)
        {
            string sql = "";
            string message = "";
            
            DBConnect();

            try
            {
                if (input is Lernkarte)
                {
                    Lernkarte lernkarte = input as Lernkarte;

                    sql =
                        "CALL Update_Lernkarte(@kartenid, @frage, @antwort, @modulname, @username, @adminCheck, @oeffentlich);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@kartenid", lernkarte.Id);
                    command.Parameters.AddWithValue("@frage", lernkarte.Frage);
                    command.Parameters.AddWithValue("@antwort", lernkarte.Antwort);
                    command.Parameters.AddWithValue("@modulname", lernkarte.Modulname);
                    command.Parameters.AddWithValue("@username", lernkarte.Username);
                    command.Parameters.AddWithValue("@adminCheck", lernkarte.AdminCheck);
                    command.Parameters.AddWithValue("@oeffentlich", lernkarte.Oeffentlich);
                    message = "Die Lernkarte wurde erfolgreich geändert.";
                }
                else if (input is User)
                {
                    User user = input as User;

                    sql = "CALL Update_User(@userid, @mail, @username, @passwort);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@userid", user.Id);
                    command.Parameters.AddWithValue("@mail", user.Mail);
                    command.Parameters.AddWithValue("@username", user.Name);
                    command.Parameters.AddWithValue("@passwort", user.Passwort);
                    message = "Der User wurde erfolgreich geändert.";
                }
                else if (input is Modul)
                {
                    Modul modul = input as Modul;

                    sql = "CALL Update_Modul(@modulid, @modulname);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@modulid", modul.Id);
                    command.Parameters.AddWithValue("@modulname", modul.Name);
                    message = "Das Modul wurde erfolgreich geändert.";
                }
                else if (input is Kartendetail)
                {
                    Kartendetail kartendetail = input as Kartendetail;

                    sql = "CALL Update_Kartendetail(@kartennr, @username, @lernstufe);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@kartennr", kartendetail.Kartennr);
                    command.Parameters.AddWithValue("@username", kartendetail.Username);
                    command.Parameters.AddWithValue("@lernstufe", kartendetail.Lernstufe);
                    message = "Das Kartendetail wurde erfolgreich geändert.";
                }

                command.ExecuteNonQuery();
                MessageBox.Show(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        
        // DELETE

        public static void DeleteEntity<T>(T input)
        {
            string sql = "";
            string message = "";
            
            DBConnect();

            try
            {
                if (input is Lernkarte)
                {
                    Lernkarte lernkarte = input as Lernkarte;

                    sql = "CALL Delete_Lernkarte(@kartenid);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@kartenid", lernkarte.Id);
                    message = "Die Lernkarte wurde erfolgreich gelöscht.";
                }
                else if (input is User)
                {
                    User user = input as User;

                    sql = "CALL Delete_User(@userid);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@userid", user.Id);
                    message = $"Die User {user.Name} wurde erfolgreich gelöscht.";
                }
                else if (input is Modul)
                {
                    Modul modul = input as Modul;

                    sql = "CALL Delete_Modul(@modulid);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@modulid", modul.Id);
                    message = $"Das Modul {modul.Name} wurde erfolgreich gelöscht.";
                }
                else if (input is Kartendetail)
                {
                    Kartendetail kartendetail = input as Kartendetail;

                    sql = "CALL Delete_Kartendetail(@kartennr, @username);";
                    command = new MySqlCommand(sql, dbConnection);
                    command.Parameters.AddWithValue("@kartennr", kartendetail.Kartennr);
                    command.Parameters.AddWithValue("@username", kartendetail.Username);
                    message = $"Das Kartendetail wurde erfolgreich gelöscht.";
                }

                command.ExecuteNonQuery();
                MessageBox.Show(message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
    }
}