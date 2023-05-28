using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP1
{
    public class Mike : IParent
    {
        public void Car(string Benz)
        {
            Console.WriteLine("Want Benz");
        }
        public void House(string House)
        {
            Console.WriteLine("Want House");
        }
    }
              
    
}
