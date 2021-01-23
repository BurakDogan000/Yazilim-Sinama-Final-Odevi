using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace istakipProgrami
{
    class VTBaglan
    {
        public SqlConnection bagla()
        {
            SqlConnection bagla = new SqlConnection(@"Data Source=GHOST;Initial Catalog=YazlimSinamaFinalDb;Integrated Security=True");
            bagla.Open();
            return bagla;
        }
    }
}
