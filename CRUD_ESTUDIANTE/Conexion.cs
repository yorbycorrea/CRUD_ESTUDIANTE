using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_ESTUDIANTE
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-7NJSLRM;DATABASE=crud_alumnos;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
