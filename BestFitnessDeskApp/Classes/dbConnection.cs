using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BestFitnessDeskApp.Classes
{
    public class dbConnection
    {
        public static string connectionString
        {
            get { return "Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True"; }
        }
    }
}
