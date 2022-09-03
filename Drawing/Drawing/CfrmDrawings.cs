using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class CfrmDrawings : Form
    {
        public CfrmDrawings()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //prepare a panel for drwaings
            Graphics g = pnlDrawings.CreateGraphics();

            //create a pen width thickness of 2
            Pen penBlack = new Pen(Color.Black, 2);

            //use the pen to draw a line on the pannel
            //the line start at x1 = 0, y1 =0 and ends at x2 = 100,y2 = 100
            g.DrawLine(penBlack, 0, 0, 100,100);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
