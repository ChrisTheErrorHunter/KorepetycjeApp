using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korepetycje
{
    class BazaDanych
    {
        MySqlConnection conn;
        public BazaDanych()
        {
            string connetionString = "server=localhost;user id=root;database=korepetycje;SSL Mode=None";
            conn = new MySqlConnection(connetionString);
        }

        public MySqlConnection Polaczenie
        {
            get
            {
                return conn;
            }
        }

        public static string CzytajString(MySqlDataReader dataReader, int column)
        {
            if (!dataReader.IsDBNull(column))
            {
                return dataReader.GetString(column);
            }
            else return "";
        }

        public static string CzytajBoolJakoText(MySqlDataReader dataReader, int column)
        {
            if (!dataReader.IsDBNull(column))
            {
                if (dataReader.GetBoolean(column))
                {
                    return "tak";
                }
                else
                {
                    return "nie";
                }
            }
            else return "";
        }

        public static bool CzytajBool(MySqlDataReader dataReader, int column)
        {
            if (!dataReader.IsDBNull(column))
            {
                return dataReader.GetBoolean(column);
            }
            else return false;
        }

    }
}
