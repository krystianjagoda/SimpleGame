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
            this.labelPosition = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(478, 9);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(44, 13);
            this.labelpos.TabIndex = 1;
            this.labelpos.Text = "Position";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(528, 9);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(14, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "X";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 10;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(5, 5);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(400, 400);
            this.canvas.TabIndex = 3;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // SimpleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 478);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelpos);
            this.KeyPreview = true;
            this.Name = "SimpleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelpos;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Panel canvas;
    }
}

