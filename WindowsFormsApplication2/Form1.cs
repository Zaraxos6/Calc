using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        string operation;
        Double First_Var;
        Double Second_Var;
        public Form1()
        {
            InitializeComponent();
            Box.Text = "0";
            

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (Box.Text == "0")
                Box.Clear(); 
                Button b = (Button)sender; 
            Box.Text = Box.Text + b.Text;

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Operation_click(object sender, EventArgs e)
        {
            First_Var = Double.Parse(Box.Text);
            Button b = (Button)sender;
            operation = b.Text;
            Box.Clear();


        }

        private void sum_click(object sender, EventArgs e)
        {
            Second_Var = Double.Parse(Box.Text);

            if (operation == "+")
                Box.Text = (First_Var + Second_Var).ToString();
            else if (operation == "/")
                Box.Text = (First_Var / Second_Var).ToString();
            else if (operation == "*")
                Box.Text = (First_Var * Second_Var).ToString();
            else if (operation == "-")
                Box.Text = (First_Var - Second_Var).ToString();
            else
                Box.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Box.Clear();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Box.Clear();
            First_Var = 0;
            Second_Var = 0;
        }
    }
}
