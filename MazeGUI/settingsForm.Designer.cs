namespace MazeGUI
{
    partial class formSettings
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pbWallColor = new System.Windows.Forms.PictureBox();
            this.btnWallColor = new System.Windows.Forms.Button();
            this.pbPathColor = new System.Windows.Forms.PictureBox();
            this.btnPathColor = new System.Windows.Forms.Button();
            this.pbSolvePathColor = new System.Windows.Forms.PictureBox();
            this.btnSolvePathColor = new System.Windows.Forms.Button();
            this.pbSolutionColor = new System.Windows.Forms.PictureBox();
            this.btnSolutionColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPathColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolvePathColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolutionColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWallColor
            // 
            this.pbWallColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWallColor.Location = new System.Drawing.Point(32, 31);
            this.pbWallColor.Name = "pbWallColor";
            this.pbWallColor.Size = new System.Drawing.Size(20, 20);
            this.pbWallColor.TabIndex = 0;
            this.pbWallColor.TabStop = false;
            // 
            // btnWallColor
            // 
            this.btnWallColor.Location = new System.Drawing.Point(59, 29);
            this.btnWallColor.Name = "btnWallColor";
            this.btnWallColor.Size = new System.Drawing.Size(117, 23);
            this.btnWallColor.TabIndex = 1;
            this.btnWallColor.Text = "Set Wall Color";
            this.btnWallColor.UseVisualStyleBackColor = true;
            this.btnWallColor.Click += new System.EventHandler(this.btnWallColor_Click);
            // 
            // pbPathColor
            // 
            this.pbPathColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPathColor.Location = new System.Drawing.Point(32, 60);
            this.pbPathColor.Name = "pbPathColor";
            this.pbPathColor.Size = new System.Drawing.Size(20, 20);
            this.pbPathColor.TabIndex = 0;
            this.pbPathColor.TabStop = false;
            // 
            // btnPathColor
            // 
            this.btnPathColor.Location = new System.Drawing.Point(59, 58);
            this.btnPathColor.Name = "btnPathColor";
            this.btnPathColor.Size = new System.Drawing.Size(117, 23);
            this.btnPathColor.TabIndex = 1;
            this.btnPathColor.Text = "Set Path Color";
            this.btnPathColor.UseVisualStyleBackColor = true;
            this.btnPathColor.Click += new System.EventHandler(this.btnPathColor_Click);
            // 
            // pbSolvePathColor
            // 
            this.pbSolvePathColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSolvePathColor.Location = new System.Drawing.Point(32, 89);
            this.pbSolvePathColor.Name = "pbSolvePathColor";
            this.pbSolvePathColor.Size = new System.Drawing.Size(20, 20);
            this.pbSolvePathColor.TabIndex = 0;
            this.pbSolvePathColor.TabStop = false;
            // 
            // btnSolvePathColor
            // 
            this.btnSolvePathColor.Location = new System.Drawing.Point(59, 87);
            this.btnSolvePathColor.Name = "btnSolvePathColor";
            this.btnSolvePathColor.Size = new System.Drawing.Size(117, 23);
            this.btnSolvePathColor.TabIndex = 1;
            this.btnSolvePathColor.Text = "Set Solve Path Color";
            this.btnSolvePathColor.UseVisualStyleBackColor = true;
            this.btnSolvePathColor.Click += new System.EventHandler(this.btnSolvePathColor_Click);
            // 
            // pbSolutionColor
            // 
            this.pbSolutionColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSolutionColor.Location = new System.Drawing.Point(32, 118);
            this.pbSolutionColor.Name = "pbSolutionColor";
            this.pbSolutionColor.Size = new System.Drawing.Size(20, 20);
            this.pbSolutionColor.TabIndex = 0;
            this.pbSolutionColor.TabStop = false;
            // 
            // btnSolutionColor
            // 
            this.btnSolutionColor.Location = new System.Drawing.Point(59, 116);
            this.btnSolutionColor.Name = "btnSolutionColor";
            this.btnSolutionColor.Size = new System.Drawing.Size(117, 23);
            this.btnSolutionColor.TabIndex = 1;
            this.btnSolutionColor.Text = "Set Solution Color";
            this.btnSolutionColor.UseVisualStyleBackColor = true;
            this.btnSolutionColor.Click += new System.EventHandler(this.btnSolutionColor_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(90, 187);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 53);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // formSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 259);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSolutionColor);
            this.Controls.Add(this.pbSolutionColor);
            this.Controls.Add(this.btnSolvePathColor);
            this.Controls.Add(this.pbSolvePathColor);
            this.Controls.Add(this.btnPathColor);
            this.Controls.Add(this.pbPathColor);
            this.Controls.Add(this.btnWallColor);
            this.Controls.Add(this.pbWallColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Maze Generator Settings";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.formSettings_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.pbWallColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPathColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolvePathColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolutionColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbWallColor;
        private System.Windows.Forms.Button btnWallColor;
        private System.Windows.Forms.PictureBox pbPathColor;
        private System.Windows.Forms.Button btnPathColor;
        private System.Windows.Forms.PictureBox pbSolvePathColor;
        private System.Windows.Forms.Button btnSolvePathColor;
        private System.Windows.Forms.PictureBox pbSolutionColor;
        private System.Windows.Forms.Button btnSolutionColor;
        private System.Windows.Forms.Button btnOK;
    }
}