using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class DeepDish : CrustClass
    {
        PizzaClass currentPizza;

        public DeepDish(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override String getDescription()
        {
            return currentPizza.getDescription() + " with a Deep Dish crust";
        }

        public override double getCost()
        {
            return 2.25 + currentPizza.getCost();
        }
    }

}
