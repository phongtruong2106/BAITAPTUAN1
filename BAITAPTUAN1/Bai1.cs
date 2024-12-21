using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPTUAN1
{
    internal class Bai1
    {
        
            float a = 5;
            float b = 7;
            float kq;
            public  void Cong()
            {
                kq = a + b;
                Console.WriteLine(kq);
            }

            public void Tru()
            {
                kq = a - b;
                Console.WriteLine(kq);
            }
            public void Nhan()
            {
                kq = a * b;
                Console.WriteLine(kq);
            }
            public void Chia()
            {
                kq = a / b;
                Console.WriteLine(kq);
            }
        

    }
}
