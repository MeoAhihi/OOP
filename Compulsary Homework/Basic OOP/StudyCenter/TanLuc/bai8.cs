using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanLuc1
{
    internal class CD
    {
        private int id;
        private string name;
        private int number;
        private int value;

        public int setId(int id)
        {
            //if (id < 0 || id == null) { id = 999999; }
            //else { this.id = id; }
            this.id = 0;
            if (this.id != null)
            {
                this.id += 1;
            }
            return this.id;
        }
        public void setName(string name)
        {
            if (name == null || name == "") { name = "Undefined"; }
            else { this.name = name; }
        }
        public void setNumber(int number)
        {
            if (number < 0 || number == null) { number = 0; }
            else { this.number = number; }
        }
        public void setValue(int value)
        {
            if (value < 0 || value == null) { value = 0;}
            else { this.value = value; }
        }

        public int getId(int id)
        {
            return id;
        }
        public string getName(string name)
        {
            return name;
        }
        public int getNumber(int number)
        {
            return number;
        }
        public int getValue(int value)
        {
            return value;
        }

        public CD(string name, int number, int value)
        {
            this.id = id;
            setName(name);
            setNumber(number);
            setValue(value);
        }
        public CD()
        {
        }

        public override string? ToString()
        {
            return String.Format("CD: {0, -3} {1, -20} {2, -14} {3, -11}",
                this.id, this.name, this.number, this.value);
        }
    }
}
