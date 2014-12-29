using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    class Vehicle
    {
       
        private double speed;
        private double min;
        private double max;

        public Vehicle(string name, string regNo)
        {
        }

        public double Speed
         {
            set { speed = value; }
            get { return speed; }
         }

       
        public double Max
        {
            set { max = value; }
        }

        
        public double Min
        {
            set { min = value; }
            get {return min;}
        }
        public double GetMinSpeed()
        {
            if (Min == 0)
            {
                return Speed;
            }
            else if (Speed < Min)
            {
                Min = Speed;
                return  Min;
            }
            else 
            {
                return Min;
            }
            
        }

        public double GetMaxSpeed()
        {
            if (Speed > max)
            {
                return Speed;
            }
            else
            {
                return max;
            }
        }

        public double GetAverageSpeed()
        {
            
            return (GetMaxSpeed() + GetMinSpeed())/2;
        }
    }
}
