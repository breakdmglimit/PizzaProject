using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class LargePizzaClass : PizzaClass
    {
        public LargePizzaClass()
        {
            description = "Large Pizze";
            this.setSize("Large");
        }

        public override double getCost()
        {
            return 14.95;
        }
    }
}
