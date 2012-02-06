using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class NormalCrust : CrustClass
    {
        PizzaClass currentPizza;

        public NormalCrust(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override String getDescription()
        {
            return currentPizza.getDescription() + " with a Normal Crust";
        }

        public override double getCost()
        {
            return 2.25 + currentPizza.getCost();
        }
    }

}
