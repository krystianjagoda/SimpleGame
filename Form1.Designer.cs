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
            this.label6 = new System.Windows.Forms.Label();
            this.labelAsteroids = new System.Windows.Forms.Label();
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
            this.labelBullets = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timerGameTick = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLevel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGameWindow = new System.Windows.Forms.TabPage();
            this.tabMainMenu = new System.Windows.Forms.TabPage();
            this.tabMenu2 = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabScore = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.canvas.SuspendLayout();
            this.debugBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabGameWindow.SuspendLayout();
            this.tabMainMenu.SuspendLayout();
            this.tabMenu2.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelpos
            // 
            this.labelpos.AutoSize = true;
            this.labelpos.Location = new System.Drawing.Point(49, 16);
            this.labelpos.Name = "labelpos";
            this.labelpos.Size = new System.Drawing.Size(41, 13);
            this.labelpos.TabIndex = 1;
            this.labelpos.Text = "Bullets:";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 30;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.BackColor = System.Drawing.Color.MediumAquamarine;
            this.canvas.Controls.Add(this.debugBox);
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Location = new System.Drawing.Point(3, 23);
            this.canvas.Margin = new System.Windows.Forms.Padding(0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(685, 676);
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
            this.debugBox.Controls.Add(this.button1);
            this.debugBox.Controls.Add(this.label6);
            this.debugBox.Controls.Add(this.labelAsteroids);
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
            this.debugBox.Controls.Add(this.labelBullets);
            this.debugBox.Location = new System.Drawing.Point(438, 3);
            this.debugBox.Name = "debugBox";
            this.debugBox.Size = new System.Drawing.Size(150, 200);
            this.debugBox.TabIndex = 3;
            this.debugBox.TabStop = false;
            this.debugBox.Visible = false;
            this.debugBox.Enter += new System.EventHandler(this.debugBox_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Asteroids:";
            // 
            // labelAsteroids
            // 
            this.labelAsteroids.AutoSize = true;
            this.labelAsteroids.Location = new System.Drawing.Point(101, 29);
            this.labelAsteroids.Name = "labelAsteroids";
            this.labelAsteroids.Size = new System.Drawing.Size(14, 13);
            this.labelAsteroids.TabIndex = 15;
            this.labelAsteroids.Text = "X";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(101, 105);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(14, 13);
            this.labelAngle.TabIndex = 13;
            this.labelAngle.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Angle:";
            // 
            // buttonStopGame
            // 
            this.buttonStopGame.BackColor = System.Drawing.Color.Firebrick;
            this.buttonStopGame.Location = new System.Drawing.Point(85, 171);
            this.buttonStopGame.Name = "buttonStopGame";
            this.buttonStopGame.Size = new System.Drawing.Size(59, 24);
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
            this.labelSpeed.Location = new System.Drawing.Point(101, 82);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(24, 13);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "X,Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speed:";
            // 
            // labelPositionAbs
            // 
            this.labelPositionAbs.AutoSize = true;
            this.labelPositionAbs.Location = new System.Drawing.Point(101, 58);
            this.labelPositionAbs.Name = "labelPositionAbs";
            this.labelPositionAbs.Size = new System.Drawing.Size(24, 13);
            this.labelPositionAbs.TabIndex = 6;
            this.labelPositionAbs.Text = "X,Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
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
            // labelBullets
            // 
            this.labelBullets.AutoSize = true;
            this.labelBullets.Location = new System.Drawing.Point(101, 16);
            this.labelBullets.Name = "labelBullets";
            this.labelBullets.Size = new System.Drawing.Size(14, 13);
            this.labelBullets.TabIndex = 2;
            this.labelBullets.Text = "X";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(46, 4);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(13, 13);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Score:";
            // 
            // timerGameTick
            // 
            this.timerGameTick.Interval = 10;
            this.timerGameTick.Tick += new System.EventHandler(this.timerGameTick_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "StartNew";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.labelLevel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 20);
            this.panel1.TabIndex = 4;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(133, 4);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(13, 13);
            this.labelLevel.TabIndex = 7;
            this.labelLevel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Level:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(534, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Debug";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonStartGame);
            this.panelMenu.Location = new System.Drawing.Point(3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(600, 640);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.White;
            this.buttonStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartGame.Location = new System.Drawing.Point(222, 214);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(150, 35);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "New Game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.White;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(222, 266);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(150, 35);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.White;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(222, 320);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(150, 35);
            this.buttonInfo.TabIndex = 2;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(222, 374);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 35);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMainMenu);
            this.tabControl.Controls.Add(this.tabMenu2);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabGameWindow);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Controls.Add(this.tabScore);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(614, 650);
            this.tabControl.TabIndex = 4;
            // 
            // tabGameWindow
            // 
            this.tabGameWindow.Controls.Add(this.canvas);
            this.tabGameWindow.Controls.Add(this.panel1);
            this.tabGameWindow.Location = new System.Drawing.Point(4, 22);
            this.tabGameWindow.Name = "tabGameWindow";
            this.tabGameWindow.Padding = new System.Windows.Forms.Padding(3);
            this.tabGameWindow.Size = new System.Drawing.Size(606, 624);
            this.tabGameWindow.TabIndex = 0;
            this.tabGameWindow.Text = "GameWindow";
            this.tabGameWindow.UseVisualStyleBackColor = true;
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Controls.Add(this.panelMenu);
            this.tabMainMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMenu.Size = new System.Drawing.Size(606, 624);
            this.tabMainMenu.TabIndex = 1;
            this.tabMainMenu.Text = "MainMenu";
            this.tabMainMenu.UseVisualStyleBackColor = true;
            // 
            // tabMenu2
            // 
            this.tabMenu2.Controls.Add(this.panel2);
            this.tabMenu2.Location = new System.Drawing.Point(4, 22);
            this.tabMenu2.Name = "tabMenu2";
            this.tabMenu2.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu2.Size = new System.Drawing.Size(606, 624);
            this.tabMenu2.TabIndex = 2;
            this.tabMenu2.Text = "Menu2";
            this.tabMenu2.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.panel3);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(606, 624);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 640);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Location = new System.Drawing.Point(3, -8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 640);
            this.panel3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(226, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(406, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(149, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.panel4);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(606, 624);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel4.Location = new System.Drawing.Point(3, -8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 640);
            this.panel4.TabIndex = 6;
            // 
            // tabScore
            // 
            this.tabScore.Controls.Add(this.panel5);
            this.tabScore.Location = new System.Drawing.Point(4, 22);
            this.tabScore.Name = "tabScore";
            this.tabScore.Size = new System.Drawing.Size(606, 624);
            this.tabScore.TabIndex = 5;
            this.tabScore.Text = "Score";
            this.tabScore.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel5.Location = new System.Drawing.Point(3, -8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 640);
            this.panel5.TabIndex = 7;
            // 
            // SimpleGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 621);
            this.Controls.Add(this.tabControl);
            this.KeyPreview = true;
            this.Name = "SimpleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleGame";
            this.canvas.ResumeLayout(false);
            this.debugBox.ResumeLayout(false);
            this.debugBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabGameWindow.ResumeLayout(false);
            this.tabGameWindow.PerformLayout();
            this.tabMainMenu.ResumeLayout(false);
            this.tabMenu2.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabScore.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label labelBullets;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerGameTick;
        private System.Windows.Forms.Button buttonStopGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAsteroids;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGameWindow;
        private System.Windows.Forms.TabPage tabMainMenu;
        private System.Windows.Forms.TabPage tabMenu2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabScore;
        private System.Windows.Forms.Panel panel5;
    }
}

