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
        Point last_point;
        public Form1()
        {
            InitializeComponent();
        }


        private void Push_me_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Push_me.Location = new Point((this.Size.Width - 50)/2, (this.Size.Height - 25)/2);
            last_point = Push_me.Location;
        }
        delegate int Sr(int p, int sr);
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Sr sr = (p, srr) => p >= 0 ? p+100 <= srr ? p : srr-100 : 0;

            Push_me.Location = new Point(sr(Push_me.Location.X-(last_point.X - e.Location.X)*2,this.Size.Width) ,
                sr(Push_me.Location.Y-( last_point.Y - e.Location.Y )*2,this.Size.Height));


            last_point = e.Location;
        }
    }
}
