using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class FlatBreadCrust : CrustClass
    {
        PizzaClass currentPizza;

        public FlatBreadCrust(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override string getDescription()
        {
            return currentPizza.getDescription() + " with a Flat Bread crust";
        }

        public override double getCost()
        {
            return 2.25 + currentPizza.getCost();
        }
    }

}
