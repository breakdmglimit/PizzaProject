using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class SmallPizzaClass : PizzaClass
    {
        public SmallPizzaClass(String size)
        {
            description = "Small Pizze";
            this.setSize(size);
        }

        public override double getCost()
        {
            return 9.20;
        }
    }
}
