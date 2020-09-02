using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JADASystec.DataAccess.Repositories.Base
{
    public abstract class Repository
    {
        private readonly string _ConnectionString;

        public string ConnectionString
        {
            get { return _ConnectionString; }           
        }

        public Repository()
        {
            _ConnectionString = "Data Source = (local); Initial Catalog = JADASystec_PuntoDeVenta; user = sa; password = 123456; Timeout = 0;";
        }
    }
}
