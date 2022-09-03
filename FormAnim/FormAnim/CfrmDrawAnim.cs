using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormAnim
{
    public partial class CfrmDrawAnim : Form
    {
        int iWidth = 0;
        int iHeight = 0;
        public CfrmDrawAnim()
        {
            InitializeComponent();
        }
        //This method is called by the timer after every 100ms seconds
        private void tmrDraw_Tick(object sender, EventArgs e)
        {
            Graphics g = pnlDrawing.CreateGraphics();

            //clear the drawings in the panel to start new one
            g.Clear(Color.White);

            //the width is increased by one after every 100ms
            iWidth += 1;
            //the height is increase by one after every 100ms
            iHeight += 1;

            //draw an ellipse in the panel
            g.FillEllipse(new SolidBrush(Color.Blue), 100, 100, iWidth, iHeight);
        }
    }
}
