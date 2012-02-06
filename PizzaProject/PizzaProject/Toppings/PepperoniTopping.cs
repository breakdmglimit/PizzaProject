using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class PepperoniTopping : ToppingClass
    {
        PizzaClass currentPizza;

        public PepperoniTopping(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override string getDescription()
        {
            return currentPizza.getDescription() + ", Pepperoni";
        }

        public override double getCost()
        {
            return 1.25 + currentPizza.getCost();
        }
    }

}
