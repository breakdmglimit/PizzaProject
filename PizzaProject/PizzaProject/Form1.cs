using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            PizzaClass pizza = new MediumPizzaClass();
            pizza = new DeepDish(pizza);
            pizza = new SunDriedTomatoes(pizza);
            pizza = new SpinchTopping(pizza);
            label1.Text = pizza.getDescription();

        }

        

    }
}
