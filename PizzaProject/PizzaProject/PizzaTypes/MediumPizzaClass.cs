using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class MediumPizzaClass : PizzaClass
    {
        public MediumPizzaClass(String size)
        {
            description = "Medium Pizze";
            this.setSize(size);
        }

        public override double getCost()
        {
            return 12.50;
        }
    }
}
