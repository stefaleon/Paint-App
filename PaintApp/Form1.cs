using System;
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
    }
}
