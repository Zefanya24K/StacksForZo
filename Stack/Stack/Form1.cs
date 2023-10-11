using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack<string> stack = new Stack<string>();
        Stack<string> reversedStack = new Stack<string>();
        Stack<string> currentStack;
        public Form1()
        {
            InitializeComponent();
            currentStack = stack;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                currentStack.Pop();
                lbStack.Items.RemoveAt(0);

            }
            else
            {
                MessageBox.Show("The stack is empty.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtInsert.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                stack.Push(value);
                reversedStack = new Stack<string>(stack);
                currentStack = stack;
                lbStack.Items.Insert(0, value);
            }
            else
            {
                MessageBox.Show("Please enter a value to push onto the stack.");
            }
            txtInsert.Clear();
        }

        private void lbStack_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                string top = currentStack.Peek();
                MessageBox.Show("Top element: " + top);
            }
            else
            {
                MessageBox.Show("The stack is empty.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbStack.Items.Clear();
            foreach (var item in currentStack)
            {
                lbStack.Items.Add(item);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            currentStack = (currentStack == stack) ? reversedStack : stack;
            lbStack.Items.Clear();
            foreach (var item in currentStack)
            {
                lbStack.Items.Insert(0, item);
            }

        }
    }
}

