using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;
using Newtonsoft.Json;

namespace FITrainerAdminTool
{
    public class FileOperations
    {
        public static void ExportAsCSV(string filePath, string[] tableData)
        {
            try
            {
                File.WriteAllLines(filePath, tableData);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ExportLernkartenToJson(string filePath)
        {
            List<Lernkarte> lernkartenListe = new List<Lernkarte>();
            lernkartenListe = DBLernkarten.ReadLernkartenListJSON();
            string output = JsonConvert.SerializeObject(lernkartenListe);
            File.WriteAllText(filePath, output);
        }

        public static void ImportLernkartenFromJson(string filePath)
        {
            string input = File.ReadAllText(filePath);
            List<Lernkarte> deserializedLernkarten = JsonConvert.DeserializeObject<List<Lernkarte>>(input);

            foreach (var karte in deserializedLernkarten)
            {
                DBLernkarten.CreateEntity(karte, true);
            }
        }
    }
}