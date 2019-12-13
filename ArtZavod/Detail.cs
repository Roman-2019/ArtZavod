using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtZavod
{
    abstract  class Detail: IDetal
    {
                public int tmp0;
        public int tmp1;
        public int tmp2;
        public int tmp3;
        //public int [] ps = new int [4] { 0,0,0,0};

        public void Made()
        {
            MadeDetail();

        }
        protected virtual void MadeDetail()
        {
            Console.WriteLine("++++++++");
        }
    }
}
