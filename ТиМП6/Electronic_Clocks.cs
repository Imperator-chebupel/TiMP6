using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Electronic_Clocks
    {

        public virtual string Change_Electronic_Time(int H_number, int M_number)
        {
            int Hour_ = (H_number%24) ;
            //if (AM_PM)
                //Hour_ += 12;
            int Minute_ = (M_number % 60);
            return "Время: " + Hour_.ToString() + ":" + Minute_.ToString("00") + "\n";
        }
    }
}
