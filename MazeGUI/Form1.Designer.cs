namespace MazeGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonCreateMaze = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolbarLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbAlgorithm = new System.Windows.Forms.GroupBox();
            this.lblVariant = new System.Windows.Forms.Label();
            this.comboVariant = new System.Windows.Forms.ComboBox();
            this.comboAlgorithm = new System.Windows.Forms.ComboBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWallCellWidth = new System.Windows.Forms.Label();
            this.lblMazeHeight = new System.Windows.Forms.Label();
            this.lblTunnelCellWidth = new System.Windows.Forms.Label();
            this.tbWallWidth = new System.Windows.Forms.TextBox();
            this.lblMazeWidth = new System.Windows.Forms.Label();
            this.tbTunnelWidth = new System.Windows.Forms.TextBox();
            this.tbMazeHeight = new System.Windows.Forms.TextBox();
            this.tbMazeWidth = new System.Windows.Forms.TextBox();
            this.tbStartX = new System.Windows.Forms.TextBox();
            this.tbStartY = new System.Windows.Forms.TextBox();
            this.lblStartX = new System.Windows.Forms.Label();
            this.lblStartY = new System.Windows.Forms.Label();
            this.mazePanel = new System.Windows.Forms.PictureBox();
            this.trackbarSpeed = new System.Windows.Forms.TrackBar();
            this.buttonPause = new System.Windows.Forms.Button();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.btnFastest = new System.Windows.Forms.Button();
            this.buttonSolveMaze = new System.Windows.Forms.Button();
            this.tbEndX = new System.Windows.Forms.TextBox();
            this.tbEndY = new System.Windows.Forms.TextBox();
            this.lblEndX = new System.Windows.Forms.Label();
            this.lblEndY = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMazeToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.gbAlgorithm.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarSpeed)).BeginInit();
            this.gbSpeed.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateMaze
            // 
            this.buttonCreateMaze.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCreateMaze.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateMaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMaze.Location = new System.Drawing.Point(10, 404);
            this.buttonCreateMaze.Name = "buttonCreateMaze";
            this.buttonCreateMaze.Size = new System.Drawing.Size(94, 54);
            this.buttonCreateMaze.TabIndex = 2;
            this.buttonCreateMaze.Text = "Create a New Maze";
            this.buttonCreateMaze.UseVisualStyleBackColor = false;
            this.buttonCreateMaze.Click += new System.EventHandler(this.buttonCreateMaze_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.MaximumSize = new System.Drawing.Size(225, 50);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(225, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolbarLabel1
            // 
            this.toolbarLabel1.Name = "toolbarLabel1";
            this.toolbarLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolbarLabel1.Text = "Ready";
            // 
            // gbAlgorithm
            // 
            this.gbAlgorithm.Controls.Add(this.lblVariant);
            this.gbAlgorithm.Controls.Add(this.comboVariant);
            this.gbAlgorithm.Controls.Add(this.comboAlgorithm);
            this.gbAlgorithm.Controls.Add(this.lblPercentage);
            this.gbAlgorithm.Controls.Add(this.textBox1);
            this.gbAlgorithm.Location = new System.Drawing.Point(12, 220);
            this.gbAlgorithm.Name = "gbAlgorithm";
            this.gbAlgorithm.Size = new System.Drawing.Size(193, 180);
            this.gbAlgorithm.TabIndex = 4;
            this.gbAlgorithm.TabStop = false;
            this.gbAlgorithm.Text = "Algorithm";
            // 
            // lblVariant
            // 
            this.lblVariant.AutoSize = true;
            this.lblVariant.Location = new System.Drawing.Point(7, 49);
            this.lblVariant.Name = "lblVariant";
            this.lblVariant.Size = new System.Drawing.Size(40, 13);
            this.lblVariant.TabIndex = 3;
            this.lblVariant.Text = "Variant";
            // 
            // comboVariant
            // 
            this.comboVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVariant.FormattingEnabled = true;
            this.comboVariant.Location = new System.Drawing.Point(4, 65);
            this.comboVariant.Name = "comboVariant";
            this.comboVariant.Size = new System.Drawing.Size(185, 21);
            this.comboVariant.TabIndex = 2;
            this.comboVariant.Layout += new System.Windows.Forms.LayoutEventHandler(this.combos_Layout);
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Items.AddRange(new object[] {
            "Growing Tree",
            "Something Else"});
            this.comboAlgorithm.Location = new System.Drawing.Point(4, 19);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(185, 21);
            this.comboAlgorithm.TabIndex = 2;
            this.comboAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithm_SelectedIndexChanged);
            this.comboAlgorithm.Layout += new System.Windows.Forms.LayoutEventHandler(this.combos_Layout);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(34, 101);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(62, 13);
            this.lblPercentage.TabIndex = 2;
            this.lblPercentage.Text = "Percentage";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "25";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWallCellWidth);
            this.groupBox2.Controls.Add(this.lblMazeHeight);
            this.groupBox2.Controls.Add(this.lblTunnelCellWidth);
            this.groupBox2.Controls.Add(this.tbWallWidth);
            this.groupBox2.Controls.Add(this.lblMazeWidth);
            this.groupBox2.Controls.Add(this.tbTunnelWidth);
            this.groupBox2.Controls.Add(this.tbMazeHeight);
            this.groupBox2.Controls.Add(this.tbMazeWidth);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dimensions";
            // 
            // lblWallCellWidth
            // 
            this.lblWallCellWidth.AutoSize = true;
            this.lblWallCellWidth.Location = new System.Drawing.Point(45, 108);
            this.lblWallCellWidth.Name = "lblWallCellWidth";
            this.lblWallCellWidth.Size = new System.Drawing.Size(79, 13);
            this.lblWallCellWidth.TabIndex = 2;
            this.lblWallCellWidth.Text = "Wall Cell Width";
            // 
            // lblMazeHeight
            // 
            this.lblMazeHeight.AutoSize = true;
            this.lblMazeHeight.Location = new System.Drawing.Point(46, 52);
            this.lblMazeHeight.Name = "lblMazeHeight";
            this.lblMazeHeight.Size = new System.Drawing.Size(67, 13);
            this.lblMazeHeight.TabIndex = 2;
            this.lblMazeHeight.Text = "Maze Height";
            // 
            // lblTunnelCellWidth
            // 
            this.lblTunnelCellWidth.AutoSize = true;
            this.lblTunnelCellWidth.Location = new System.Drawing.Point(45, 84);
            this.lblTunnelCellWidth.Name = "lblTunnelCellWidth";
            this.lblTunnelCellWidth.Size = new System.Drawing.Size(91, 13);
            this.lblTunnelCellWidth.TabIndex = 2;
            this.lblTunnelCellWidth.Text = "Tunnel Cell Width";
            // 
            // tbWallWidth
            // 
            this.tbWallWidth.Location = new System.Drawing.Point(4, 105);
            this.tbWallWidth.Name = "tbWallWidth";
            this.tbWallWidth.Size = new System.Drawing.Size(43, 20);
            this.tbWallWidth.TabIndex = 1;
            this.tbWallWidth.Text = "4";
            // 
            // lblMazeWidth
            // 
            this.lblMazeWidth.AutoSize = true;
            this.lblMazeWidth.Location = new System.Drawing.Point(46, 28);
            this.lblMazeWidth.Name = "lblMazeWidth";
            this.lblMazeWidth.Size = new System.Drawing.Size(64, 13);
            this.lblMazeWidth.TabIndex = 2;
            this.lblMazeWidth.Text = "Maze Width";
            // 
            // tbTunnelWidth
            // 
            this.tbTunnelWidth.Location = new System.Drawing.Point(4, 81);
            this.tbTunnelWidth.Name = "tbTunnelWidth";
            this.tbTunnelWidth.Size = new System.Drawing.Size(43, 20);
            this.tbTunnelWidth.TabIndex = 1;
            this.tbTunnelWidth.Text = "12";
            // 
            // tbMazeHeight
            // 
            this.tbMazeHeight.Location = new System.Drawing.Point(5, 48);
            this.tbMazeHeight.Name = "tbMazeHeight";
            this.tbMazeHeight.Size = new System.Drawing.Size(42, 20);
            this.tbMazeHeight.TabIndex = 1;
            this.tbMazeHeight.Text = "600";
            this.tbMazeHeight.Leave += new System.EventHandler(this.tbMazeSize_Leave);
            // 
            // tbMazeWidth
            // 
            this.tbMazeWidth.Location = new System.Drawing.Point(5, 24);
            this.tbMazeWidth.Name = "tbMazeWidth";
            this.tbMazeWidth.Size = new System.Drawing.Size(42, 20);
            this.tbMazeWidth.TabIndex = 1;
            this.tbMazeWidth.Text = "600";
            this.tbMazeWidth.Leave += new System.EventHandler(this.tbMazeSize_Leave);
            // 
            // tbStartX
            // 
            this.tbStartX.Location = new System.Drawing.Point(16, 173);
            this.tbStartX.Name = "tbStartX";
            this.tbStartX.Size = new System.Drawing.Size(43, 20);
            this.tbStartX.TabIndex = 1;
            this.tbStartX.Text = "300";
            // 
            // tbStartY
            // 
            this.tbStartY.Location = new System.Drawing.Point(16, 197);
            this.tbStartY.Name = "tbStartY";
            this.tbStartY.Size = new System.Drawing.Size(43, 20);
            this.tbStartY.TabIndex = 1;
            this.tbStartY.Text = "300";
            // 
            // lblStartX
            // 
            this.lblStartX.AutoSize = true;
            this.lblStartX.Location = new System.Drawing.Point(60, 176);
            this.lblStartX.Name = "lblStartX";
            this.lblStartX.Size = new System.Drawing.Size(39, 13);
            this.lblStartX.TabIndex = 2;
            this.lblStartX.Text = "Start X";
            // 
            // lblStartY
            // 
            this.lblStartY.AutoSize = true;
            this.lblStartY.Location = new System.Drawing.Point(60, 200);
            this.lblStartY.Name = "lblStartY";
            this.lblStartY.Size = new System.Drawing.Size(39, 13);
            this.lblStartY.TabIndex = 2;
            this.lblStartY.Text = "Start Y";
            // 
            // mazePanel
            // 
            this.mazePanel.BackColor = System.Drawing.Color.Black;
            this.mazePanel.Location = new System.Drawing.Point(226, 25);
            this.mazePanel.Name = "mazePanel";
            this.mazePanel.Size = new System.Drawing.Size(600, 600);
            this.mazePanel.TabIndex = 6;
            this.mazePanel.TabStop = false;
            this.mazePanel.Click += new System.EventHandler(this.mazePanel_Click);
            this.mazePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mazePanel_Paint);
            // 
            // trackbarSpeed
            // 
            this.trackbarSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarSpeed.Location = new System.Drawing.Point(3, 16);
            this.trackbarSpeed.Maximum = 25;
            this.trackbarSpeed.Minimum = 1;
            this.trackbarSpeed.Name = "trackbarSpeed";
            this.trackbarSpeed.Size = new System.Drawing.Size(211, 81);
            this.trackbarSpeed.TabIndex = 7;
            this.trackbarSpeed.Value = 12;
            this.trackbarSpeed.Scroll += new System.EventHandler(this.trackbarSpeed_Scroll);
            this.trackbarSpeed.Layout += new System.Windows.Forms.LayoutEventHandler(this.trackbarSpeed_Layout);
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPause.Location = new System.Drawing.Point(113, 404);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(94, 54);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "Pause Creation";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPauseCreate_Click);
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.btnFastest);
            this.gbSpeed.Controls.Add(this.trackbarSpeed);
            this.gbSpeed.Location = new System.Drawing.Point(3, 525);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(217, 100);
            this.gbSpeed.TabIndex = 8;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speed";
            // 
            // btnFastest
            // 
            this.btnFastest.Location = new System.Drawing.Point(53, 62);
            this.btnFastest.Name = "btnFastest";
            this.btnFastest.Size = new System.Drawing.Size(111, 24);
            this.btnFastest.TabIndex = 8;
            this.btnFastest.Text = "Just Finish It";
            this.btnFastest.UseVisualStyleBackColor = true;
            this.btnFastest.Click += new System.EventHandler(this.btnFastest_Click);
            // 
            // buttonSolveMaze
            // 
            this.buttonSolveMaze.Location = new System.Drawing.Point(10, 468);
            this.buttonSolveMaze.Name = "buttonSolveMaze";
            this.buttonSolveMaze.Size = new System.Drawing.Size(94, 54);
            this.buttonSolveMaze.TabIndex = 9;
            this.buttonSolveMaze.Text = "Start Solving Maze";
            this.buttonSolveMaze.UseVisualStyleBackColor = true;
            this.buttonSolveMaze.Click += new System.EventHandler(this.buttonSolveMaze_Click);
            // 
            // tbEndX
            // 
            this.tbEndX.Location = new System.Drawing.Point(110, 176);
            this.tbEndX.Name = "tbEndX";
            this.tbEndX.Size = new System.Drawing.Size(38, 20);
            this.tbEndX.TabIndex = 1;
            this.tbEndX.Text = "0";
            // 
            // tbEndY
            // 
            this.tbEndY.Location = new System.Drawing.Point(110, 200);
            this.tbEndY.Name = "tbEndY";
            this.tbEndY.Size = new System.Drawing.Size(38, 20);
            this.tbEndY.TabIndex = 1;
            this.tbEndY.Text = "0";
            // 
            // lblEndX
            // 
            this.lblEndX.AutoSize = true;
            this.lblEndX.Location = new System.Drawing.Point(154, 179);
            this.lblEndX.Name = "lblEndX";
            this.lblEndX.Size = new System.Drawing.Size(36, 13);
            this.lblEndX.TabIndex = 2;
            this.lblEndX.Text = "End X";
            // 
            // lblEndY
            // 
            this.lblEndY.AutoSize = true;
            this.lblEndY.Location = new System.Drawing.Point(154, 203);
            this.lblEndY.Name = "lblEndY";
            this.lblEndY.Size = new System.Drawing.Size(36, 13);
            this.lblEndY.TabIndex = 2;
            this.lblEndY.Text = "End Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pause Solving";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSolveMaze_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMazeToFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMazeToFileToolStripMenuItem
            // 
            this.saveMazeToFileToolStripMenuItem.Name = "saveMazeToFileToolStripMenuItem";
            this.saveMazeToFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveMazeToFileToolStripMenuItem.Text = "&Save Maze to File...";
            this.saveMazeToFileToolStripMenuItem.Click += new System.EventHandler(this.saveMazeToFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(850, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSolveMaze);
            this.Controls.Add(this.gbSpeed);
            this.Controls.Add(this.mazePanel);
            this.Controls.Add(this.lblEndY);
            this.Controls.Add(this.lblStartY);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbAlgorithm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblEndX);
            this.Controls.Add(this.lblStartX);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonCreateMaze);
            this.Controls.Add(this.tbEndY);
            this.Controls.Add(this.tbStartY);
            this.Controls.Add(this.tbEndX);
            this.Controls.Add(this.tbStartX);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Maze Generator!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbAlgorithm.ResumeLayout(false);
            this.gbAlgorithm.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarSpeed)).EndInit();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateMaze;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolbarLabel1;
        private System.Windows.Forms.GroupBox gbAlgorithm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWallCellWidth;
        private System.Windows.Forms.Label lblMazeHeight;
        private System.Windows.Forms.Label lblTunnelCellWidth;
        private System.Windows.Forms.TextBox tbWallWidth;
        private System.Windows.Forms.Label lblMazeWidth;
        private System.Windows.Forms.TextBox tbTunnelWidth;
        private System.Windows.Forms.TextBox tbMazeHeight;
        private System.Windows.Forms.TextBox tbMazeWidth;
        private System.Windows.Forms.TextBox tbStartX;
        private System.Windows.Forms.TextBox tbStartY;
        private System.Windows.Forms.Label lblStartX;
        private System.Windows.Forms.Label lblStartY;
        private System.Windows.Forms.PictureBox mazePanel;
        private System.Windows.Forms.TrackBar trackbarSpeed;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.ComboBox comboVariant;
        private System.Windows.Forms.ComboBox comboAlgorithm;
        private System.Windows.Forms.Label lblVariant;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.Button buttonSolveMaze;
        private System.Windows.Forms.TextBox tbEndX;
        private System.Windows.Forms.TextBox tbEndY;
        private System.Windows.Forms.Label lblEndX;
        private System.Windows.Forms.Label lblEndY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFastest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMazeToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

