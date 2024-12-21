using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPTUAN1
{
    internal class Bai2
    {
        private float soa = 200;
        private float sob = 100;
        private float kqCong;
        private float kqTru;
        private float kqNhan;
        private float kqChia;
        private string kqss;
        private string kqssC;
        private void Cong()
        {
            kqCong = soa + sob;
        }
        private void Tru()
        {
            kqTru = soa - sob;
        }
        private void Nhan() 
        { 
            kqNhan = soa * sob;
        }
        private void Chia()
        {
            kqChia = soa / sob;
        }

        private void SSKQCT()
        {
            if(kqChia > kqTru)
            {
                kqss = "phep ss OK";
            }
            else if(kqChia < kqTru)
            {
                kqss = "phep ss not OK";
            }
        }
        private void SSKQCN()
        {
            if (kqCong > kqNhan)
            {
                kqssC = "phep ss not OK";
                
            }
            else if (kqCong < kqNhan)
            {
                kqssC = "phep ss OK";
            }
        }
        public void Print()
        {
            this.Cong();
            this.Tru();
            this.Chia();
            this.Nhan();
            Console.WriteLine(" cong: " + kqCong + "\n Nhan: " + kqNhan + "\n Chia: " + kqChia + "\n tru: " + kqTru);
            this.SSKQCT();
            this.SSKQCN();  
            Console.WriteLine(" ChiaTru: " + kqss + "\n CongNhan: " + kqssC);
        }
    }
}
