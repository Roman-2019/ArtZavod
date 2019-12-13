using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtZavod
{
    class Status : Detail
    {
        //private readonly List<CarDetail> ListCarDetail = new List<CarDetail>();
        //public List<CarDetail> ListCarDetail = new List<CarDetail>();

        //public void Add(CarDetail cars)
        //{
        //    this.ListCarDetail.Add(cars);
        //}
        
        protected override void MadeDetail()
        {
            Console.WriteLine("We are have many detail:");
            Console.WriteLine("Factory made {0} wheel, {1} rudder, {2} engine, {3} seat",CarDetail.Wheel,CarDetail.Rudder,CarDetail.Engine,CarDetail.Seat);
            Console.WriteLine("If you whant continue press Spacebar or Esc to finish");
            tmp0 = CarDetail.Wheel;
            tmp1 = CarDetail.Rudder;
            tmp2 = CarDetail.Engine;
            tmp3 = CarDetail.Seat;
            Menu.MainMenu();
        }
    }
}
