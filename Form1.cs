using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabPage FirstTab = tabControl1.TabPages[0];
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {

                FirstTab.BackColor = colorDialog1.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                fontDialog1.ShowEffects = true;
                fontDialog1.ShowApply = true;   
            if (fontDialog1.ShowDialog() == DialogResult.OK) {


                label2.Font = fontDialog1.Font;
            }
        }
    }
}
