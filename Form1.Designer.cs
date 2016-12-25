namespace SimpleGame
{
    partial class SimpleGame
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
            this.labelpos = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.Panel();
            this.debugBox = new System.Windows.Forms.GroupBox();
            this.labelAngle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStopGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPositionAbs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPositionRel = new System.Windows.Forms.Label();
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.canvas.SuspendLayout();
            this.debugBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(8, 16);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(89, 13);
            this.labelpos.TabIndex = 1;
            this.labelpos.Text = "Relative Position:";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 20;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.canvas.Controls.Add(this.debugBox);
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(600, 600);
            this.canvas.TabIndex = 3;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // debugBox
            // 
            this.debugBox.BackColor = System.Drawing.Color.Transparent;
            this.debugBox.Controls.Add(this.labelAngle);
            this.debugBox.Controls.Add(this.label5);
            this.debugBox.Controls.Add(this.buttonStopGame);
            this.debugBox.Controls.Add(this.label3);
            this.debugBox.Controls.Add(this.numericUpDown1);
            this.debugBox.Controls.Add(this.labelSpeed);
            this.debugBox.Controls.Add(this.label4);
            this.debugBox.Controls.Add(this.labelPositionAbs);
            this.debugBox.Controls.Add(this.label2);
            this.debugBox.Controls.Add(this.labelSize);
            this.debugBox.Controls.Add(this.label1);
            this.debugBox.Controls.Add(this.labelpos);
            this.debugBox.Controls.Add(this.labelPositionRel);
            this.debugBox.Location = new System.Drawing.Point(438, 3);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(150, 200);
            this.debugBox.TabIndex = 3;
            this.debugBox.TabStop = false;
            this.debugBox.Visible = false;
            this.debugBox.Enter += new System.EventHandler(this.debugBox_Enter);
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(101, 87);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(14, 13);
            this.labelAngle.TabIndex = 13;
            this.labelAngle.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Angle:";
            // 
            // buttonStopGame
            // 
            this.buttonStopGame.BackColor = System.Drawing.Color.Firebrick;
            this.buttonStopGame.Location = new System.Drawing.Point(63, 171);
            this.buttonStopGame.Name = "buttonStopGame";
            this.buttonStopGame.Size = new System.Drawing.Size(81, 24);
            this.buttonStopGame.TabIndex = 11;
            this.buttonStopGame.Text = "Stop";
            this.buttonStopGame.UseVisualStyleBackColor = false;
            this.buttonStopGame.Click += new System.EventHandler(this.buttonStopGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "GameSpeed:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(96, 145);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(101, 64);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(24, 13);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "X,Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed:";
            // 
            // labelPositionAbs
            // 
            this.labelPositionAbs.AutoSize = true;
            this.labelPositionAbs.Location = new System.Drawing.Point(101, 40);
            this.labelPositionAbs.Name = "labelPositionAbs";
            this.labelPositionAbs.Size = new System.Drawing.Size(24, 13);
            this.labelPositionAbs.TabIndex = 6;
            this.labelPositionAbs.Text = "X,Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Absolute Position:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(101, 125);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(24, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "X,Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size:";
            // 
            // labelPositionRel
            // 
            this.labelPositionRel.AutoSize = true;
            this.labelPositionRel.Location = new System.Drawing.Point(101, 16);
            this.labelPositionRel.Name = "labelPositionRel";
            this.labelPositionRel.Size = new System.Drawing.Size(24, 13);
            this.labelPositionRel.TabIndex = 2;
            this.labelPositionRel.Text = "X,Y";
            // 
            // timerGameTick
            // 
            this.timerGameTick.Interval = 10;
            this.timerGameTick.Tick += new System.EventHandler(this.timerGameTick_Tick);
            // 
            // SimpleGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.canvas);
            this.KeyPreview = true;
            this.Name = "SimpleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleGame";
            this.canvas.ResumeLayout(false);
            this.debugBox.ResumeLayout(false);
            this.debugBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.GroupBox debugBox;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPositionAbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPositionRel;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerGameTick;
        private System.Windows.Forms.Button buttonStopGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAngle;
    }
}

