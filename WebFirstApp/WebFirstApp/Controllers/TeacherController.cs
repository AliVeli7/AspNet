using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFirstApp.Controllers
{
    public class TeacherController
    {
        public string Index()
        {
            return "Kamran";
        }

        public string TeacherId(int? id)
        {
            if (id==null)
            {
                return "ALL Teacher"; 
            }
            else
            {
                return id.ToString();
            }
        }
    }
}
