using DBLayer;
using LocalDevicesDetection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDevicesDetection.Repositories
{
    public class PoznatiUredajiRepository
    {
        public static List<PoznatiUredaji> GetUredaj()
        {
            var uredaji = new List<PoznatiUredaji>();

            string sql = "SELECT * FROM Dopusteni_uredaji";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                PoznatiUredaji uredaj = CreateObject(reader);
                uredaji.Add(uredaj);
            }

            reader.Close();
            DB.CloseConnection();

            return uredaji;
        }

        private static PoznatiUredaji CreateObject(SqlDataReader reader)
        {
            string id_uredaja = reader["ID_uredaja"].ToString();
            string prezime = reader["Prezime_vlasnika"].ToString();
            string ime = reader["Ime_vlasnika"].ToString();
            string uloga = reader["Uloga"].ToString();

            var uredaj = new PoznatiUredaji
            {
                ID = id_uredaja,
                Prezime = prezime,
                Ime = ime,
                Uloga = uloga
            };

            return uredaj;
        }

    }
}
