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
        PizzaClass currentPizza;
        public Form1()
        {
            
            InitializeComponent();
            groupBox3.Visible = false;
            button6.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            //PizzaClass pizza = new MediumPizzaClass();
            //pizza = new DeepDish(pizza);
            //pizza = new SunDriedTomatoes(pizza);
            //pizza = new SpinchTopping(pizza);
          //  label1.Text = pizza.getDescription();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public PizzaClass makePizza(String size)
        {

            if (size == "small")
            {
                PizzaClass newPizza = new SmallPizzaClass();
                return newPizza;
            }

            else if (size == "medium")
            {
                PizzaClass newPizza = new MediumPizzaClass();
                return newPizza;

            }

            else if (size == "large")
            {
                PizzaClass newPizza = new LargePizzaClass();
                return newPizza;

            }

            else
            {
                PizzaClass newPizza = new SmallPizzaClass();
                return newPizza;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PizzaClass pizza;
            String var = "";
            if (radioButton1.Checked == true)
            {
                var = "small";
            }
            else if (radioButton2.Checked == true)
            {
                var = "medium";
            }
            else if (radioButton3.Checked == true)
            {
                var = "large";
            }
            else
            {
                this.Close();
            }

            pizza = makePizza(var);

            if (radioButton4.Checked == true)
            {
                pizza = new NormalCrust(pizza);
            }
            else if (radioButton5.Checked == true)
            {
                pizza = new FlatBreadCrust(pizza);
            }
            else if (radioButton6.Checked == true)
            {
                pizza = new DeepDish(pizza);
            }
            else
            {
                this.Close();
            }
            currentPizza = pizza;
            part2();

        }

        public void part2()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button1.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
            groupBox3.Visible = true;
            button6.Visible = true;

            updateDisplay();

        }

        public void updateDisplay()
        {
            label2.Text = "Current Pizza: " + currentPizza.getDescription();
            label3.Text = "Cost: " + currentPizza.getCost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentPizza = new OlivesTopping(currentPizza);
            updateDisplay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentPizza = new PepperoniTopping(currentPizza);
            updateDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentPizza = new SpinchTopping(currentPizza);
            updateDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentPizza = new SunDriedTomatoes(currentPizza);
            updateDisplay();
        }

     
        

    }
}
