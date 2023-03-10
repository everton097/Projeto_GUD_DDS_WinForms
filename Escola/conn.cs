using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Escola
{
    public class conn
    {
        public MySqlConnection getconnection()
        {
            string conexao = "server=localhost; userID=root; password=0970; database=escola";

            return new MySqlConnection(conexao);
        }
    }
}
