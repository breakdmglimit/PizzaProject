using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class SpinchTopping : ToppingClass
    {
        PizzaClass currentPizza;

        public SpinchTopping(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override string getDescription()
        {
            return currentPizza.getDescription() + ", Spinch";
        }

        public override double getCost()
        {
            return .75 + currentPizza.getCost();
        }
    }

}
