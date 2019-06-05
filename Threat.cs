using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threat_test
{
    class Threat
    {
        public int uid;
        public string application;
        public int level;
        public int thread;
        public string dtrecv;
        public string dtsend;
        public string threatfn;
        public string errmess;

        public Threat()
        {
            errmess = "";
            application = "";
            dtrecv = "";
            dtsend = "";
            threatfn = "";
            uid = 0;
            level = 0;
            thread = 0;
        }

    }
}
