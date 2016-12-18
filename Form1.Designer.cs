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
            this.labelPositionAbs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPositionRel = new System.Windows.Forms.Label();
            this.canvas.SuspendLayout();
            this.debugBox.SuspendLayout();
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
            this.timerRefresh.Interval = 10;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canvas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.canvas.Controls.Add(this.debugBox);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(584, 561);
            this.canvas.TabIndex = 3;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // debugBox
            // 
            this.debugBox.Controls.Add(this.labelPositionAbs);
            this.debugBox.Controls.Add(this.label2);
            this.debugBox.Controls.Add(this.labelSize);
            this.debugBox.Controls.Add(this.label1);
            this.debugBox.Controls.Add(this.labelpos);
            this.debugBox.Controls.Add(this.labelPositionRel);
            this.debugBox.Location = new System.Drawing.Point(372, 3);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(200, 200);
            this.debugBox.TabIndex = 3;
            this.debugBox.TabStop = false;
            this.debugBox.Visible = false;
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
            this.labelSize.Location = new System.Drawing.Point(101, 65);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(24, 13);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "X,Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 65);
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
            // SimpleGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.canvas);
            this.KeyPreview = true;
            this.Name = "SimpleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleGame";
            this.canvas.ResumeLayout(false);
            this.debugBox.ResumeLayout(false);
            this.debugBox.PerformLayout();
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
    }
}

