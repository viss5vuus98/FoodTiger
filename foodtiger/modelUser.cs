using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodtiger
{
    class modelUser
    {
        public Dictionary<string, string> userInfo = new Dictionary<string, string>() {
            {"id", ""},{ "email", ""},{"password", ""}
        };//ID email password
         
        List<int> favorite  = new List<int>();//favorite

    }
}
