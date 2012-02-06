using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class SmallPizzaClass : PizzaClass
    {
        public SmallPizzaClass()
        {
            description = "Small Pizze";
            this.setSize("Small");
        }

        public override double getCost()
        {
            return 9.20;
        }
    }
}
