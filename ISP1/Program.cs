using ISP1;
using System;

namespace ISP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //INTERFACE SEGREGATION PRINCIPAL (ISP)

            //Interface Segregation Principle(ISP) state that no class should be forced to implement any method(s) of an interface they don’t use.
            //Secondly, instead of creating large or you can say fat interfaces,
            //create multiple smaller interfaces with the aim that the we
            //should only think about the methods that are of interest to them.

            Console.WriteLine("David will get access to following properties");

            David dav= new David();
            dav.Car("Want");
            dav.School("want");
            dav.Hotel("Want");
            dav.House("Want");

            Console.WriteLine("Mike will get access to the following properties"); 

            Mike mK=new Mike();
            mK.Car("Want");
            mK.House("Want");




        }


    }
}
