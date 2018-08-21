using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicletas
{
    class Conexion
    {
        SqlConnection con = new SqlConnection("server=USUARIO_PC\\SQLSERVER; Initial Catalog=Bicicletas; Integrated Security=true");
        //prueba de 
    }
}
