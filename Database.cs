using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Student_database
{
    internal class Database:List<Students>
    {
        public override string ToString()
        {
            string text = "";
            foreach (Students student in this)
                text += student + Environment.NewLine;
            return text;
        }

        public static Database operator + (Database database, Students students)
        {
            database.Add(students);
            return database;
        }

        public void SaveEmployeesInJSON(string file)
        {

            string jsonTypeNameAll = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(file, jsonTypeNameAll);
        }

        public Database RestoreListFromJSON(string file)
        {
            Clear();
            string json = File.ReadAllText(file);
            return JsonConvert.DeserializeObject<Database>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

        }
    }
}
