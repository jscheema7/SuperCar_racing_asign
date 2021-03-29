using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCar_racing
{
   public  class selectPlayer
    {
        Random rd = new Random();
        public int Num = 0;

        //need to get teh number 
        public void getNumber() {
            Num = rd.Next(1, 70);
        }
        public int betAmount(String Car,String CarNo,int Amount,int Budget) {
            if (Car.Equals(CarNo))
            {
                return Budget + Amount;
            }
            else {
                return Budget - Amount;
            }
        }
    }
}
