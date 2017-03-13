using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Calculator calc;
        private string op;
   
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
            op = "";
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void execute()
        {
            /*
            if (op == "" || textResult.Text == "")
            {
                if (textResult.Text != "" ) calc.setCur(double.Parse(textResult.Text));
                return;
            }
            */
            switch (op)
            {
                case "+": calc.add(double.Parse(textResult.Text)); break;
                case "-": calc.sub(double.Parse(textResult.Text)); break;
                case "*": calc.mult(double.Parse(textResult.Text)); break;
                case "/": calc.div(double.Parse(textResult.Text)); break;
                default: break;
            }
            op = "";
        }

        private void writeHistory() {

            PanelHistory.Controls.Add(new Label());
            ((Label)PanelHistory.Controls[PanelHistory.Controls.Count - 1]).Font.Size.;
           ((Label)PanelHistory.Controls[PanelHistory.Controls.Count-1]).Text = textResult2.Text + textResult.Text + "=" + calc.cur.Val.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag == "Op")
            {
                switch (((Button)sender).Text)
                {
                    case "erase": break;
                    case "CE": textResult.Text = ""; break;
                    case "C": textResult.Text = ""; textResult2.Text = ""; calc.setCur(0) ; break;
                    case "=": execute(); writeHistory(); textResult2.Text = ""; textResult.Text = calc.cur.Val.ToString(); break;
                    default: break;
                }
            }
            else if (((Button)sender).Tag == "AlgebraOp")
            {
                if (op != "") execute();
                else if (textResult.Text != "") calc.setCur(double.Parse(textResult.Text));
                else return;
                textResult2.Text += textResult.Text;
                textResult.Text = "";
                op = ((Button)sender).Text;
                textResult2.Text += op;

            }
            else if (((Button)sender).Tag == "MemOp")
            {
                switch (((Button)sender).Text)
                {
                    case "MC": break;
                    case "M+": break;
                    case "M-": break;
                    case "MR": break;
                    case "MS": break;
                    case "M": break;
                    default: break;
                }
            }
            else if (((Button)sender).Tag == "OneOperandOp")
            {
                switch (((Button)sender).Text) {
                    case ".": break;
                    case "+-": break;
                    default: break;
                }
            }
            else
            {
                textResult.Text += ((Button)sender).Text;
            }
        }

        private void textResult2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_Click(object sender, EventArgs e)
        {

        }
    }
}
