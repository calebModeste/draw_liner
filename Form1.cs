using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02
{
    public partial class Form1 : Form
    {   private Point ptemps;
        private Color colortake;
        private int taille;


        
        public Form1()
        {
            InitializeComponent();

            

        }

        private void Scroll(object sender, EventArgs e)
        {
            System.Windows.Forms.TrackBar myTB;
            myTB = (System.Windows.Forms.TrackBar)sender;
            this.taille= myTB.Value;
        }

        private void rouge_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Red;
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult dr;
            ColorDialog dlg = new ColorDialog();
            dr = dlg.ShowDialog();

            this.colortake=dlg.Color;

            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Green;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Yellow;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Blue;
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Gray;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.Black;
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            this.colortake = Color.White;
            
            
        }

        private void draw_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();

                Pen p = new Pen(this.colortake, this.taille);
                //           Rectangle r = new Rectangle(e.X, e.Y, 250, 130);
                //           g.DrawRectangle(p, r);
                Point pt1 = ptemps;
                Point pt2 = new Point(e.X, e.Y);
                
                g.DrawLine(p, pt1, pt2);
                ptemps = new Point(e.X, e.Y);
  
            }
            
        }

        private void draw_MouseDown(object sender, MouseEventArgs e)
        {
            ptemps = new Point(e.X, e.Y);
            
        }



    }
}
