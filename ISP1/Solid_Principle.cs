using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP1
{
    public interface IParent
    {
        void Car(string Benz);
        void House(string TwoBedroomFlat);
    }
    interface IHouse
    {
        void School(string School);
    }
    interface IHotel
    {
        void Hotel(string Hotel);
    }
}
