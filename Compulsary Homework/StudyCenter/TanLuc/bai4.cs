using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanLuc
{
    internal class Vehicle
    {
        private string carOwner;
        private string carType;
        private int carValue;
        private int xylanh;
        private int tax;

        public void setCarOwner(string carOwner)
        {
            this.carOwner = carOwner;
        }
        public void setCarType(string carType)
        {
            this.carType = carType;
        }
        public void setCarValue(int carValue)
        {
            if (carValue < 0) { carValue = 0; }
            else
            {
                this.carValue = carValue;
            }
        }
        public void setXylanh(int xylanh)

        {
            if (xylanh < 0) { xylanh = 0; }
            else
            {
                this.xylanh = xylanh;
            }
            
        }

        public string getCarOwner(string carOwner)
        {
            return this.carOwner;
        }
        public string getCarType(string carType)
        {
            return this.carType;
        }
        public int getCarValue(int carValue)
        {
            return this.carValue;
        }
        public int getXylanh(int xylanh)
        {
            return this.xylanh;
        }
        public int getTax(int tax)
        {
            this.tax = tax;
            if (100 > xylanh) 
            {
                tax = carValue * 1 / 100;
            }
            if (100 <= xylanh & 200 >= xylanh)
            {
                tax = carValue * 3 / 100;
            }
            if (200 < xylanh)
            {
                tax = carValue * 5 / 100;
            }
            return tax;
            
        }

        public Vehicle(string carOwner, string carType, int xylanh, int carValue)
        {
            setCarOwner(carOwner);
            setCarType(carType);
            setCarValue(carValue);
            setXylanh(xylanh);
        }
        public Vehicle()
        {
        }

        public override string ToString()
        {
            return String.Format("{0, -3} {1, -20} {2, -14} {3, -11} {4, 5}",
                this.carOwner, this.carType, this.xylanh, this.carValue, getTax(tax));
        }
    }
}
