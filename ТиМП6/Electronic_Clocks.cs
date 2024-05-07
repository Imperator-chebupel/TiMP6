using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ТиМП6
{
    public class Electronic_Clocks
    {

        private int Hour;
        private int Minute;

        public Electronic_Clocks() 
        {
            Hour = 0;
            Minute = 0;
        }

        public virtual string Change_Electronic_Time(int H_number, int M_number)
        {
            this.Minute += (M_number % 60);
            if (this.Minute /60 > 0)
            {
                this.Hour += (this.Minute / 60);
            }
            this.Minute = Minute % 60;
            this.Hour += (H_number%24);
            this.Hour = Hour % 24;
            return "Время: " + Hour.ToString() + ":" + Minute.ToString("00") + "\n" + "Поворот часовой стрелки на " + H_number*30 + " минутной на " + M_number * 6 + "\n";
        }
    }
}
