using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaProject
{
    public class OlivesTopping : ToppingClass
    {
        PizzaClass currentPizza;

        public OlivesTopping(PizzaClass currPizza)
        {
            this.currentPizza = currPizza;
        }

        public override string getDescription()
        {
            return currentPizza.getDescription() + ", Olives";
        }

        public override double getCost()
        {
            return .65 + currentPizza.getCost();
        }
    }

}
