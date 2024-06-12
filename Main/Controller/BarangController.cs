using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Main.Model.modelAkun;
using static Main.Model.modelBarang;

namespace Main.Controller
{
    internal class BarangController
    {
        public List<Barang> ReadJSON()
        {
            string filePathDataBarang = "D:\\GUI-KPL\\Main\\Data\\dataBarang.json";
            List<Barang> DataBarang = new List<Barang>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataBarang);
                DataBarang = JsonSerializer.Deserialize<List<Barang>>(configJsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return DataBarang;

        }
        public void WriteJSON(List<Akun> DATAAKUN)
        {
            string filePathDataBarang = "D:\\GUI-KPL\\Main\\Data\\dataBarang.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(DATAAKUN, options);
            File.WriteAllText(filePathDataBarang, jsonString);
        }
    }
}
