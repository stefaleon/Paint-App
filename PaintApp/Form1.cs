﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints;
        bool pencilDown;

        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            pencilDown = false;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point aPoint = new Point(e.X, e.Y);
            listOfPoints.Add(aPoint);
            pencilDown = true;
            this.statusStrip1.Items[0].Text = "MouseDown";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pencilDown = false;
            this.statusStrip1.Items[0].Text = "MouseUp";            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point newPoint = new Point(e.X, e.Y);
            Pen pencil = new Pen(Color.Blue);

            if (pencilDown)
            {
                this.statusStrip1.Items[0].Text = "MouseMove";
                g.DrawLine(pencil, (Point)listOfPoints[listOfPoints.Count - 1], newPoint);
                listOfPoints.Add(newPoint);
            }


        }
    }
}
