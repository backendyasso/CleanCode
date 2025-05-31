using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolData.AppMetaData
{
 public static class Router
    {

        public const string root = "api";
        public const string version = "v1";
        public const string concat = root+"/"+version+"/";

        public static class studentRouting
        {
            public const string prefix = concat + "Student";

            public const string List = prefix + "/List";


            public const string GetById = prefix + "/{Id}";

            public const string Create = prefix + "/Create";



        }

    }
}
