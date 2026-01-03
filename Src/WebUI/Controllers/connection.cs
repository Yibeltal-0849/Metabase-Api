using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.WebUI.Controllers
{
   public class connection
    {
        static public  string _connectionstring;

        public connection(IConfiguration configuration)
        {
            _connectionstring = configuration.GetConnectionString("XOKADatabase");

        }
    }
}
