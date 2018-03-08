using SeniorDesign.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Up:
                    // Speed up
                    Setup.Send("1");
                    break;
                case Keys.Down:
                    // Speed up
                    Setup.Send("0");
                    break;
                case Keys.Left:
                    // Speed up
                    Setup.Send("1");
                    break;
                case Keys.Right:
                    // Speed up
                    Setup.Send("1");
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setup.Send("1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setup.Send("0");
        }
    }
}
