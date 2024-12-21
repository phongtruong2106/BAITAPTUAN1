using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPTUAN1.Tuan2
{
    internal class Bai11
    {
        private int i = 5;
        private List<int> list= [1,2,3,4,5,6];
        public void Forea()
        {
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void For1()
        {
            for(i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void bWhile()
        {
            while (i <= 5)
            {
                Console.WriteLine("So: " + i);
                i++;
            }
        }

        public void BDoWhile()
        {
            do
            {
                Console.WriteLine("SoDoWhile: " + i);
                i++;
            }
            while (i <= 5);
        }
    }
}
