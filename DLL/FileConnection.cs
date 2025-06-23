using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Xml;
using System.Runtime;
using System.Xml.Serialization;


namespace DLL
{
    public class FileConnection
    {
        public FileConnection() { }
        public SQLiteDataReader DBConnection(string table)
        {
            var conn = new SQLiteConnection("Data Source=C:\\Users\\PC\\Source\\Repos\\SchoolApp\\SchoolApp\\schoolDatabase.db");


                conn.Open();
            var command = new SQLiteCommand("SELECT * FROM " + table, conn);
            var reader = command.ExecuteReader();

            return reader;

        }
        public void XMLRead(string xmlPath) {
            MySettings settings = new MySettings();
            string path = "MySettings.xml";
            XmlSerializer x = new XmlSerializer(typeof(MySettings));
            StreamReader reader = new StreamReader(path);
            settings = (TVSettings)x.Deserialize(reader);

        }
    }
}
 
