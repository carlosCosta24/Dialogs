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
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowApply = true;
            fontDialog1.Font = label2.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK) {


                label2.Font = fontDialog1.Font;
                label2.ForeColor = fontDialog1.Color;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            label2.Font = fontDialog1.Font;
            label2.ForeColor = fontDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"c:\C:\Users\carlos_costa\Downlaoads";
            saveFileDialog1.Title = "Save to ";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

                MessageBox.Show("The saving path is: " + saveFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\C:\Users\carlos_costa\Downlaoads";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|all files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            if (MessageBox.Show("Do you want to select multiple files?", "Multi option",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                openFileDialog1.Title = "Multi open from ";
                openFileDialog1.Multiselect = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {

                        MessageBox.Show(file);

                    }
                }
            }
            else {
                openFileDialog1.Title = "Single open from ";
                openFileDialog1.Multiselect = false;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {


                        MessageBox.Show(openFileDialog1.FileName);

                    
                }



            }

        }
    }
}
