using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public abstract class PizzaClass
    {
        public String description = "";
        public static String size = "";

        public virtual String getDescription()
        {
            return description;
        }

        public abstract double getCost();

        public String getSize()
        {
            return size;
        }

        public void setSize(String newSize)
        {
            size = newSize;
        }
    }
}
