using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MazeGUI
{
    public partial class formSettings : Form
    {
        public Color cWallColor;
        public Color cPathColor;
        public Color cSolvePathColor;
        public Color cSolutionColor;


        public formSettings()
        {
            InitializeComponent();
        }


        private void formSettings_Layout(object sender, LayoutEventArgs e)
        {
            if (cWallColor != null)
                pbWallColor.BackColor = cWallColor;
            if (cPathColor != null)
                pbPathColor.BackColor = cPathColor;
            if (cSolvePathColor != null)
                pbSolvePathColor.BackColor = cSolvePathColor;
            if (cSolutionColor != null)
                pbSolutionColor.BackColor = cSolutionColor;
        }

        private void btnWallColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbWallColor.BackColor = colorDialog1.Color;
        }

        private void btnPathColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbPathColor.BackColor = cPathColor = colorDialog1.Color;
        }

        private void btnSolvePathColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbSolvePathColor.BackColor = cSolvePathColor = colorDialog1.Color;
        }

        private void btnSolutionColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pbSolutionColor.BackColor = cSolutionColor = colorDialog1.Color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cWallColor = pbWallColor.BackColor;
            cPathColor = pbPathColor.BackColor;
            cSolvePathColor = pbSolvePathColor.BackColor;
            cSolutionColor = pbSolutionColor.BackColor;
            this.Hide();
             
            

        }



    }
}
