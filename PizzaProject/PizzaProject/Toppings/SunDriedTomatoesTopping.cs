using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class SunDriedTomatoes : ToppingClass
    {
        PizzaClass currentPizza;

        public SunDriedTomatoes(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override string getDescription()
        {
            return currentPizza.getDescription() + ", Sun Dried Tomatoes";
        }

        public override double getCost()
        {
            return .85 + currentPizza.getCost();
        }
    }

}
