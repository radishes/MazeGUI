using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mazes;
using Mazes.Algorithms;

namespace MazeGUI
{
    public partial class Form1 : Form
    {
        bool createInProgress = false;
        bool solveInProgress = false;
        Bitmap mazeBmp = null;
        Mazes.Maze maze;
        Mazes.MazeState lastMazeState;
        Solver solver;
        Mazes.Point firstCell;
        Mazes.Point prevCell;

        Color solvePathColor = Color.White;

         

        public Form1()
        {
            InitializeComponent();
        }

        private ToolTip TTFactory()
        {
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.ShowAlways = true;
            return tt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TTFactory().SetToolTip(this.lblMazeWidth, "Width of maze to create.");
            TTFactory().SetToolTip(this.lblMazeHeight, "Height of maze to create.");
            TTFactory().SetToolTip(this.lblTunnelCellWidth, "Width of maze tunnels.");
            TTFactory().SetToolTip(this.lblWallCellWidth, "Width of maze walls.");

            TTFactory().SetToolTip(this.lblStartX, "X coordinate of starting point. Applies to maze solving and creation. Can also be set by left-clicking on the maze.");
            TTFactory().SetToolTip(this.lblStartY, "Y coordinate of starting point. Applies to maze solving and creation. Can also be set by left-clicking on the maze.");

            TTFactory().SetToolTip(this.lblEndX, "X coordinate of solution point. Applies to maze solving only, not creation. Can also be set by right-clicking on the maze.");
            TTFactory().SetToolTip(this.lblEndY, "Y coordinate of solution point. Applies to maze solving only, not creation. Can also be set by right-clicking on the maze.");

            TTFactory().SetToolTip(this.gbAlgorithm, "Different maze generation algorithms will produce different styles of maze.");
            TTFactory().SetToolTip(this.lblVariant, "An algorithm may include more than one variant.");
            TTFactory().SetToolTip(this.gbSpeed, "Speed of maze generation or solving.");
        }


        public Color GetPixel(Mazes.Point p)
        {
            try
            { return this.mazeBmp.GetPixel(p.X, p.Y); }
            catch
            {
                return Color.Pink;
            }
        }



        public bool PeekPixel(Mazes.Point p)
        {
            Color color;
            try
            {
                color = this.mazeBmp.GetPixel(p.X, p.Y);
            }
            catch
            {
                return false;
            }
            bool r = (color.Name == "ff000000");

            //toolbarLabel1.Text = color.ToString() + "     PeekPixel = " + r;
            return r;
        }

        public bool SetPixel(Mazes.Point p, Color color)
        {
            try
            {
                this.mazeBmp.SetPixel(p.X, p.Y, color);
                return true;
            }
            catch { return false; }
            
        }

        public bool SetRect(Rect r)
        {
            return SetRect(r, Color.White);
        }

        public bool SetRect(Rect r, Color color)
        {
            for (int x = r.p.X; x < r.offset.X + r.p.X; x++)
                for (int y = r.p.Y; y < r.offset.Y + r.p.Y; y++)
                    try
                    {
                        this.mazeBmp.SetPixel(x, y, color);
                    }
                    catch
                    {
                        return false;
                    }
            return true;
        }

        private void mazePanel_Paint(object sender, PaintEventArgs e)
        {
            if (this.mazeBmp != null)
                e.Graphics.DrawImage(this.mazeBmp, new System.Drawing.Point(0, 0));
        }

        private void buttonCreateMaze_Click(object sender, EventArgs e)
        {
            int wd, ht, tunnel, wall, sx, sy, algo, variant;
            try
            {
                wd = int.Parse(tbMazeWidth.Text);
                ht = int.Parse(tbMazeHeight.Text);
                tunnel = int.Parse(tbTunnelWidth.Text);
                wall = int.Parse(tbWallWidth.Text);
                sx = int.Parse(tbStartX.Text);
                sy = int.Parse(tbStartY.Text);
                algo = comboAlgorithm.SelectedIndex;
                variant = comboVariant.SelectedIndex;
            }
            catch
            {
                return;
            }
            if (ht <= 0 || ht > 10000 || wd <= 0 || wd > 10000
                 || tunnel <= 0 || tunnel > 2000 || wall <= 0 || wall > 2000
                 || sx < 0 || sx > wd || sy < 0 || sy > ht )
                return;

            if (solver != null)
                solver.exploredPoints.Clear();
            mazeBmp = new Bitmap(wd, ht);
            mazePanel.Invalidate();
            this.prevCell = new Mazes.Point(-1, -1);
            SetRect(new Rect(0,0, mazeBmp.Width, mazeBmp.Height), Color.Black);
            this.maze = new Mazes.Maze(new Mazes.Point(0, 0), new Mazes.Point(wd, ht), new Mazes.Point(sx, sy),
                        tunnel, wall, algo, variant, this.PeekPixel, this.SetRect);
            createInProgress = true;
            timer1.Start();
        }


        private void buttonPauseCreate_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled && createInProgress)
            {
                createInProgress = false;
                timer1.Stop();
            }
            else
            {
                createInProgress = true;
                timer1.Start();
            }
        }


        private void buttonSolveMaze_Click(object sender, EventArgs e)
        {
            if (mazeBmp == null)
            {
                MessageBoxError("No maze to solve! Create a maze first.");
                return;
            }
            if (createInProgress)
            {
                MessageBoxError("Maze creation is currently in progress. Only completed or paused mazes may be solved.");
                return;
            }

            int sx, sy, ex, ey;
            try
            {
                sx = int.Parse(tbStartX.Text);
                sy = int.Parse(tbStartY.Text);
                ex = int.Parse(tbEndX.Text);
                ey = int.Parse(tbEndY.Text);
            }
            catch
            {
                MessageBoxError("One or more of the parameters is not a valid number. Check your parameters and try again.");
                return;
            }

            if (sx < 0 || sx > mazeBmp.Width || sy < 0 || sy > mazeBmp.Height
                || ex < 0 || ex > mazeBmp.Width || ey < 0 || ey > mazeBmp.Height)
            {
                MessageBoxError("One or more of the parameters is outside of the maze boundaries. Check your parameters and try again.");
                return;
            }

            Mazes.Point p1 = new Mazes.Point(sx, sy);
            Mazes.Point p2 = new Mazes.Point(ex, ey);

            solver = new Solver(p1, p2, this.GetPixel, this.SetPixel);

            solveInProgress = true;
            timer1.Start();

        }

        private void buttonPauseSolve_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled && solveInProgress)
            {
                solveInProgress = false;
                timer1.Stop();
            }
            else
            {
                solveInProgress = true;
                timer1.Start();
            }
        }


        private void mazePanel_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                tbStartX.Text = me.X.ToString();
                tbStartY.Text = me.Y.ToString();
            }
            else if (me.Button == MouseButtons.Right)
            {
                tbEndX.Text = me.X.ToString();
                tbEndY.Text = me.Y.ToString();
            }
        }

/////
//////////////////////////////////////////////////
/////

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (createInProgress)
            {
                // update maze here
                MazeState ms = this.maze.Step();
                //toolbarLabel1.Text = ms.status.ToString() + "     " + ms.message;

                if (ms.status == 1)
                {
                    this.firstCell = maze.mazeData.tunnelling.First();
                    SetRect(new Rect(this.firstCell, maze.mazeData.tunnelWidthP()), Color.Orange);
                }

                if (ms.status >= 2 && ms.status <= 4)
                {
                    int c = maze.mazeData.tunnelling.Count();
                    if (c > 0)
                    {
                        SetRect(new Rect(maze.mazeData.lastCell, maze.mazeData.tunnelWidthP()), Color.Red);
                    }
                    if (c > 1)
                    {
                        SetRect(new Rect(this.prevCell, maze.mazeData.tunnelWidthP()), Color.White);
                        toolbarLabel1.Text = maze.mazeData.lastCell.ToString() + " / " + this.prevCell.ToString();
                    }
                    this.prevCell = maze.mazeData.lastCell;
                    mazePanel.Invalidate();
                }
                if (ms.status == 8)
                {
                    createInProgress = false;
                    timer1.Stop();
                }

                this.lastMazeState = ms;
            }


            if (solveInProgress)
            {
                int prevExp = solver.exploredPoints.Count;
                this.solver.SolveStep();

                for (int i = prevExp;  i < solver.exploredPoints.Count; i++)
                {
                    mazeBmp.SetPixel(solver.exploredPoints[i].p.X, solver.exploredPoints[i].p.Y, Color.Green);
                }

                if (solver.state == 4)
                {
                    //solver.
                }
                else if (solver.state == 8)
                {
                    solveInProgress = false;
                    timer1.Stop();
                }
                this.toolbarLabel1.Text = "alivePoints.Count: " + solver.alivePoints.Count();
                mazePanel.Invalidate();
            }
        }

        private void btnFastest_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            int loops = 0;
            if (createInProgress == true)
                while (this.lastMazeState.status >= 1 && this.lastMazeState.status <= 7 && loops++ <= 1000000)
                {
                    timer1_Tick(sender, e);
                }
            else if (solveInProgress == true)
            {
                while (this.solver.state >= 1 && this.solver.state <= 7 && loops++ <= 1000000)
                {
                    timer1_Tick(sender, e);
                }
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //mazePanel.Width = this.Width - mazePanel.Location.X+100;
            //mazePanel.Height = this.Height+100;
        }

        private void tbMazeSize_Leave(object sender, EventArgs e)
        {
            int width, height = 0;
            if (!int.TryParse(tbMazeWidth.Text, out width))
                return;
            if (!int.TryParse(tbMazeHeight.Text, out height))
                return;
            mazePanel.Width = width;
            mazePanel.Height = height;
            tbStartX.Text = Math.Ceiling((double)width / 2).ToString();
            tbStartY.Text = Math.Ceiling((double)height / 2).ToString();
        }

        private void trackbarSpeed_Scroll(object sender, EventArgs e)
        {
            double spd = trackbarSpeed.Value;
            if (spd <= 0)
            {
                timer1.Stop();
            }
            else
            {
                spd = 1 / spd;
            }
            if (trackbarSpeed.Value == trackbarSpeed.Maximum)
            {
                spd = 1;
            }
            else
            {
                spd = 2000 * spd;
            }

            try
            {
                timer1.Interval = (int)spd;
            }
            catch
            {
                timer1.Interval = 200;
            }
        }

        private void trackbarSpeed_Layout(object sender, LayoutEventArgs e)
        {
            trackbarSpeed_Scroll(sender, e);
        }

        private void combos_Layout(object sender, LayoutEventArgs e)
        {
            comboAlgorithm.SelectedIndex = 0;
            comboAlgorithm_SelectedIndexChanged(sender, e);
        }

        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboVariant.Items.Clear();
            int si = comboAlgorithm.SelectedIndex;
            if (si < 0)
                si = 0;
            toolbarLabel1.Text = si.ToString();

            if ((string)comboAlgorithm.Items[si] == (string)("Growing Tree"))
            {
                foreach (string variant in Mazes.Algorithms.GrowingTree.variants)
                {
                    comboVariant.Items.Add(variant);
                }
                comboVariant.SelectedIndex = 0;
            }
            

        }

        public static void MessageBoxError(string caption)
        {
            MessageBox.Show(caption, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void saveMazeToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string, open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                if (mazeBmp == null)
                    return;
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        mazeBmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        mazeBmp.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        mazeBmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 4:
                        mazeBmp.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
