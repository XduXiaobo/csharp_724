using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp_724.HeaderFiles_Phidget;
using csharp_724.Interface;
namespace csharp_724
{
    public partial class Form1 : Form
    {
        public int value_motorselect;
        

        public Form1()
        {
            
            InitializeComponent();
            
            var mc = new motor_Phidget();

        }



        private void comboBox_motorselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_motorselect.SelectedIndex == 0)
            {
                value_motorselect=1;
                debug_richTextBox.Text="0";
            }
            else if (comboBox_motorselect.SelectedIndex == 1)
                    {
                value_motorselect=2;
                debug_richTextBox.Text="1";
            }
            else
            {
                debug_richTextBox.Text="111";
            }
        }
        interface Ibutton1_Click
        {

        }
        private void button1_Click  (object sender, EventArgs e)
        {
            //var mc = (Object)null;
            Phidgets mP = new Phidgets();
            Zaber mZ = new Zaber();
            bool a;
            if (value_motorselect==1) {
                a = mP.motor_initialise();
                debug_richTextBox.Text="1";
            }
            else if (value_motorselect==2)
            {
                a = mZ.motor_initialise();
                debug_richTextBox.Text="2";
            }
            else {
                debug_richTextBox.Text="3";
            }
            //switch (value_motorselect)
            //{
            //    case 1:
            //        var mc = new motor_Phidget(); break;
            //    default:
            //       var mc = new motor_Phidget(); break;
            //}


        }
    }
}
