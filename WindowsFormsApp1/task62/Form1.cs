using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task62
{
    public partial class Form1 : Form
    {
        Label label16 = new Label();
        string[] get16 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        string rgb = "#CDCDCD";

        void Change()
        {
            rgb = Clipboard.GetText();
            button1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            rgb = "#"+get16[trackBar1.Value / 16] + get16[trackBar1.Value % 16] +
                get16[trackBar2.Value / 16] + get16[trackBar2.Value % 16] +
                get16[trackBar3.Value / 16] + get16[trackBar3.Value % 16];
            label16.Text = rgb;
            Clipboard.SetText(rgb);

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Change();




        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            label16.Location = new Point(e.Location.X+150, e.Location.Y+150);
            label16.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label16.Location = new Point(-100,-100);
            label16.Text = rgb;
            Controls.Add(label16);
            Change();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label16.Location = new Point(-100, -100);
        }
    }
}
