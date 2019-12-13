using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtZavod
{
     class GetRandom : Detail
    {
        public int rand;

        protected override void MadeDetail()
        {
            Random rnd = new Random();
            rand = rnd.Next(0, 4);
            Console.WriteLine("- {0}", rand);
            if (rand == 0) { tmp0++; }
            else if (rand == 1) { tmp1++; }
            else if (rand == 2) { tmp2++; }
            else { tmp3++; }

            CarDetail.Wheel = tmp0;
            CarDetail.Rudder = tmp1;
            CarDetail.Engine = tmp2;
            CarDetail.Seat = tmp3;
            //ps[0] = tmp0;
            return;
        }
    }
}
