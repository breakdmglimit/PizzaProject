using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class LargePizzaClass : PizzaClass
    {
        public LargePizzaClass(String size)
        {
            description = "Large Pizze";
            this.setSize(size);
        }

        public override double getCost()
        {
            return 14.95;
        }
    }
}
