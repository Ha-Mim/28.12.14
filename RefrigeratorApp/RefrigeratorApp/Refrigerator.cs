using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        private double maxWeight;
        private double remainingWeight;
        private double currentWeight;

        public double MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        public double RemainingWeight
        {
            get { return MaxWeight-CurrentWeight; }
            
        }

       

        public double CurrentWeight
        {
            get { return currentWeight; }
            
        }

        public Refrigerator(double maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public void AddItems(double noOfItems,double weightPerUnit)
        {
            double itemTobeAdded = noOfItems*weightPerUnit;
            if (currentWeight + itemTobeAdded < MaxWeight)
            {
                currentWeight += itemTobeAdded;
            }
            else
            {
                throw new Exception("Overflow...");
            }
        }

       
        }
    }

