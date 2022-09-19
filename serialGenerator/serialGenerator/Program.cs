using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialGenerator
{
    internal class Program
    {

        static void adatbazisMuveltek()
        {
            int id;

            Connect c = new Connect();
            c.querySelect();
            try
            {
                Console.Write("Válassz id-t amit törölni akarsz: ");
                id = int.Parse(Console.ReadLine());
                c.queryDelete(id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

            c.querySelect();

        }

       
        static void Main(string[] args)
        {
            adatbazisMuveltek();


        }
    }
}
