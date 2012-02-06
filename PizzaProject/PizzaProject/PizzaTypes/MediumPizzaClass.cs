using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class MediumPizzaClass : PizzaClass
    {
        public MediumPizzaClass()
        {
            description = "Medium Pizze";
            this.setSize("medium");
        }

        public override double getCost()
        {
            return 12.50;
        }
    }
}
