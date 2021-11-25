using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
     * Реализовать класс, в котором указанные значения представлены в виде свойств. 
     * Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки 
     * начальных значений, а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного 
     * класса. Осуществить использование объекта в программе.
     */
    class Angle
    {
        // autofield
        public int Gradus { get; set; }

        // private attributes
        private int min;
        private int sec;

        // get / set for "min". Test if user input is not correct
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (min > 61 || min < 0)
                {
                    Console.WriteLine("Incorrect input...");
                }
                else
                {
                    min = value;
                }
            }
        }
        // get / set for "Sec". Test if user input is not correct
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (sec > 61 || sec < 0)
                {
                    Console.WriteLine("Incorrect input...");
                }
                else
                {
                    sec = value;
                }
            }
        }

        // constructor for class with default values
        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        // Grad Min Sec -> Radians method
        public double ToRadians()
        {
            double radians = Math.PI / 180 * (Gradus + Min / 60 + Sec / 3600);
            return radians;
        }

        // override method ToString() for printing ability
        public override string ToString()
        {
            return $"{Gradus}° {Min}\' {Sec}\" - {this.ToRadians()} rad";
        }
        
        // set ability to sum values of two angles
        public static Angle operator +(Angle a1, Angle a2)
        {
            int resSec = ((a1.sec + a2.sec) > 60) ?
                (a1.sec + a2.sec) % 60 :
                (a1.sec + a2.sec);
            int resMin = ((a1.min + a2.min + (a1.sec + a2.sec) / 60) > 60) ?
                (a1.min + a2.min + (a1.sec + a2.sec) / 60) % 60 :
                (a1.min + a2.min + (a1.sec + a2.sec) / 60);
            int resGrad = a1.Gradus + a2.Gradus + (a1.min + a2.min + (a1.sec + a2.sec) / 60) / 60;
            Angle result = new Angle(resGrad, resMin, resSec);
            return result;
        }
    }
}
