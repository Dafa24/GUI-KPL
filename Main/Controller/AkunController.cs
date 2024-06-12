using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Main.Model.modelAkun;

namespace Main.Controller
{
    internal class AkunController
    {
        public List<Akun> ReadJSON()
        {
            string filePathDataAkun = "D:\\GUI-KPL\\Main\\Data\\dataAkun.json";
            List<Akun> DataAkun = new List<Akun>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataAkun);
                DataAkun = JsonSerializer.Deserialize<List<Akun>>(configJsonData);
            }
            catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
            return DataAkun;

        }
        public Akun validateLogin(string Username, string Password)
        {
            List<Akun> DataAkun = ReadJSON();
            for (int i = 0; i < DataAkun.Count; i++)
            {
                if ((Username == DataAkun[i].Username) && (Password == DataAkun[i].Password))
                {
                    return DataAkun[i];
                }
            }
            return null;
        }
        public void WriteJSON(List<Akun> DATAAKUN)
        {
            string filePathDataAkun = "D:\\GUI-KPL\\Main\\Data\\dataAkun.json";

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(DATAAKUN, options);
            File.WriteAllText(filePathDataAkun, jsonString);
        }

    }
}
