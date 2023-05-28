using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP1
{
    public class David : IParent,IHotel,IHouse
    {
        public void Car(string Benz)
        {
            Console.WriteLine("Want Benz");
        }
        public void House(string House)
        {
            Console.WriteLine("Want House");
        }
        public void School(string School)
        {
            Console.WriteLine("Want School");
        }
        public void Hotel(string Hotel)
        {
            Console.WriteLine("want Hotel");
        }
    }
}
