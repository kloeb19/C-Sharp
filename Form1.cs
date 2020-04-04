using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Kathleen Loeb 03/20/2019
namespace SmartHome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle1.Checked)
            {
                Toggle1.Image = Properties.Resources.ToggleOn;
                Light1.Image = Properties.Resources.LightOn;
            }
            else
            { Toggle1.Image = Properties.Resources.ToggleOff;
                Light1.Image = Properties.Resources.LightOff;
            }

        }
        private void checkBox2_CheckedChanged(Object sender, EventArgs e)
        {
            if (Light1.Checked)
                Light1.Image = Properties.Resources.LightOn;
            else
                Light1.Image = Properties.Resources.LightOff;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle2.Checked)
            {
                Toggle2.Image = Properties.Resources.ToggleOn;
                Light2.Image = Properties.Resources.LightOn;
            }
            else
            {
                Toggle2.Image = Properties.Resources.ToggleOff;
                Light2.Image = Properties.Resources.LightOff;
            }

        }
        private void checkBox4_CheckedChanged(Object sender, EventArgs e)
        {
            if (Light2.Checked)
                Light2.Image = Properties.Resources.LightOn;
            else
                Light2.Image = Properties.Resources.LightOff;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle3.Checked)
            {
                Toggle3.Image = Properties.Resources.ToggleOn;
                Light3.Image = Properties.Resources.LightOn;
            }
            else
            {
                Toggle3.Image = Properties.Resources.ToggleOff;
                Light3.Image = Properties.Resources.LightOff;
            }

        }
        private void checkBox6_CheckedChanged(Object sender, EventArgs e)
        {

        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle4.Checked)
            {
                Toggle4.Image = Properties.Resources.ToggleOn;
                Light4.Image = Properties.Resources.LightOn;
            }
            else
            {
                Toggle4.Image = Properties.Resources.ToggleOff;
                Light4.Image = Properties.Resources.LightOff;
            }

        }
        private void checkBox8_CheckedChanged(Object sender, EventArgs e)
        {
            if (Light4.Checked)
                Light4.Image = Properties.Resources.LightOn;
            else
                Light4.Image = Properties.Resources.LightOff;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle5.Checked)
            {
                Toggle5.Image = Properties.Resources.ToggleOn;
                Light5.Image = Properties.Resources.LightOn;
            }
            else
            {
                Toggle5.Image = Properties.Resources.ToggleOff;
                Light5.Image = Properties.Resources.LightOff;
            }

        }
        private void checkBox10_CheckedChanged(Object sender, EventArgs e)
        {
            if (Light5.Checked)
                Light5.Image = Properties.Resources.LightOn;
            else
                Light5.Image = Properties.Resources.LightOff;
        }
      
        private void checkBox11_CheckedChanged(Object sender, EventArgs e)
        {
            if (Play.Enabled)
            {
                Light1.Image = Properties.Resources.LightOn;
                Toggle1.Image = Properties.Resources.ToggleOn;
                Light2.Image = Properties.Resources.LightOn;
                Toggle2.Image = Properties.Resources.ToggleOn;
                Light3.Image = Properties.Resources.LightOn;
                Toggle3.Image = Properties.Resources.ToggleOn;
                Light4.Image = Properties.Resources.LightOn;
                Toggle4.Image = Properties.Resources.ToggleOn;
                Light5.Image = Properties.Resources.LightOn;
                Toggle5.Image = Properties.Resources.ToggleOn;
            }
           
        }
        private void checkBox12_CheckedChanged(Object sender, EventArgs e)
        { if(PLay2.Enabled)
            {
                Light1.Image = Properties.Resources.LightOff;
                Toggle1.Image = Properties.Resources.ToggleOff;
                Light2.Image = Properties.Resources.LightOff;
                Toggle2.Image = Properties.Resources.ToggleOff;
                Light3.Image = Properties.Resources.LightOff;
                Toggle3.Image = Properties.Resources.ToggleOff;
                Light4.Image = Properties.Resources.LightOff;
                Toggle4.Image = Properties.Resources.ToggleOff;
                Light5.Image = Properties.Resources.LightOff;
                Toggle5.Image = Properties.Resources.ToggleOff;
            }
        }

        private void checkBox13_CheckedChanged(Object sender, EventArgs e)
        {
            if (Play3.Enabled)
            {
                Light1.Image = Properties.Resources.LightOn;
                Toggle1.Image = Properties.Resources.ToggleOn;
                Light2.Image = Properties.Resources.LightOn;
                Toggle2.Image = Properties.Resources.ToggleOn;
                Light3.Image = Properties.Resources.LightOn;
                Toggle3.Image = Properties.Resources.ToggleOn;
                
            }

        }

        private void checkBox14_CheckedChanged(Object sender, EventArgs e)
        {
            if (Play3.Enabled)
            {
                Light1.Image = Properties.Resources.LightOff;
                Toggle1.Image = Properties.Resources.ToggleOff;
                Light2.Image = Properties.Resources.LightOff;
                Toggle2.Image = Properties.Resources.ToggleOff;
                Light3.Image = Properties.Resources.LightOff;
                Toggle3.Image = Properties.Resources.ToggleOff;
             
            }
        }

        private void checkBox15_CheckedChanged(Object sender, EventArgs e)
        {
            if (Play4.Enabled)
            {
                Light4.Image = Properties.Resources.LightOn;
                Toggle4.Image = Properties.Resources.ToggleOn;
                Light5.Image = Properties.Resources.LightOn;
                Toggle5.Image = Properties.Resources.ToggleOn;

            }

        }

        private void checkBox16_CheckedChanged(Object sender, EventArgs e)
        {
            if (Play6.Enabled)
            {
              
                Light4.Image = Properties.Resources.LightOff;
                Toggle4.Image = Properties.Resources.ToggleOff;
                Light5.Image = Properties.Resources.LightOff;
                Toggle5.Image = Properties.Resources.ToggleOff;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
