
namespace KibardinTN_Project
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.trackBarTrajectorySize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.buttonEnterText = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonChooseFigureColor = new System.Windows.Forms.Button();
            this.buttonChooseTrajectoryColor = new System.Windows.Forms.Button();
            this.buttonChooseBackgroundColor = new System.Windows.Forms.Button();
            this.trackBarBreathSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarBreathSize = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStopBreath = new System.Windows.Forms.Button();
            this.buttonStartBreath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStartMove = new System.Windows.Forms.Button();
            this.buttonStopMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarFigureSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarFigureSize = new System.Windows.Forms.TrackBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.chooseColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrajectorySize)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFigureSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFigureSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1034, 565);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.BackColorChanged += new System.EventHandler(this.PictureBox_BackColorChanged);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.Resize += new System.EventHandler(this.PictureBox_Resize);
            // 
            // trackBarTrajectorySize
            // 
            this.trackBarTrajectorySize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarTrajectorySize.Location = new System.Drawing.Point(167, 7);
            this.trackBarTrajectorySize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarTrajectorySize.Maximum = 11;
            this.trackBarTrajectorySize.Minimum = 1;
            this.trackBarTrajectorySize.Name = "trackBarTrajectorySize";
            this.trackBarTrajectorySize.Size = new System.Drawing.Size(180, 45);
            this.trackBarTrajectorySize.TabIndex = 1;
            this.trackBarTrajectorySize.Value = 11;
            this.trackBarTrajectorySize.ValueChanged += new System.EventHandler(this.TrackBar_TrajectorySize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер траектории";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Honeydew;
            this.controlPanel.Controls.Add(this.buttonEnterText);
            this.controlPanel.Controls.Add(this.label8);
            this.controlPanel.Controls.Add(this.textBox);
            this.controlPanel.Controls.Add(this.buttonChooseFigureColor);
            this.controlPanel.Controls.Add(this.buttonChooseTrajectoryColor);
            this.controlPanel.Controls.Add(this.buttonChooseBackgroundColor);
            this.controlPanel.Controls.Add(this.trackBarBreathSpeed);
            this.controlPanel.Controls.Add(this.trackBarBreathSize);
            this.controlPanel.Controls.Add(this.label7);
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.buttonStopBreath);
            this.controlPanel.Controls.Add(this.buttonStartBreath);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.buttonStartMove);
            this.controlPanel.Controls.Add(this.buttonStopMove);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.trackBarFigureSpeed);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.trackBarFigureSize);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.trackBarTrajectorySize);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(642, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(392, 565);
            this.controlPanel.TabIndex = 3;
            // 
            // buttonEnterText
            // 
            this.buttonEnterText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterText.Location = new System.Drawing.Point(291, 302);
            this.buttonEnterText.Name = "buttonEnterText";
            this.buttonEnterText.Size = new System.Drawing.Size(75, 23);
            this.buttonEnterText.TabIndex = 21;
            this.buttonEnterText.Text = "Enter";
            this.buttonEnterText.UseVisualStyleBackColor = true;
            this.buttonEnterText.Click += new System.EventHandler(this.Click_EnterFigureName);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Выбор фигуры";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(175, 302);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(110, 23);
            this.textBox.TabIndex = 4;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPressed);
            // 
            // buttonChooseFigureColor
            // 
            this.buttonChooseFigureColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseFigureColor.Location = new System.Drawing.Point(291, 479);
            this.buttonChooseFigureColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseFigureColor.Name = "buttonChooseFigureColor";
            this.buttonChooseFigureColor.Size = new System.Drawing.Size(89, 75);
            this.buttonChooseFigureColor.TabIndex = 19;
            this.buttonChooseFigureColor.Text = "Выбрать цвет фигуры";
            this.buttonChooseFigureColor.UseVisualStyleBackColor = true;
            this.buttonChooseFigureColor.Click += new System.EventHandler(this.Click_ChooseFigureColor);
            // 
            // buttonChooseTrajectoryColor
            // 
            this.buttonChooseTrajectoryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseTrajectoryColor.Location = new System.Drawing.Point(151, 479);
            this.buttonChooseTrajectoryColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseTrajectoryColor.Name = "buttonChooseTrajectoryColor";
            this.buttonChooseTrajectoryColor.Size = new System.Drawing.Size(89, 75);
            this.buttonChooseTrajectoryColor.TabIndex = 18;
            this.buttonChooseTrajectoryColor.Text = "Выбрать цвет траектории";
            this.buttonChooseTrajectoryColor.UseVisualStyleBackColor = true;
            this.buttonChooseTrajectoryColor.Click += new System.EventHandler(this.Click_ChooseTrajectoryColor);
            // 
            // buttonChooseBackgroundColor
            // 
            this.buttonChooseBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseBackgroundColor.Location = new System.Drawing.Point(15, 479);
            this.buttonChooseBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChooseBackgroundColor.Name = "buttonChooseBackgroundColor";
            this.buttonChooseBackgroundColor.Size = new System.Drawing.Size(89, 75);
            this.buttonChooseBackgroundColor.TabIndex = 4;
            this.buttonChooseBackgroundColor.Text = "Выбрать цвет фона";
            this.buttonChooseBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonChooseBackgroundColor.Click += new System.EventHandler(this.Click_ChooseBackgroundColor);
            // 
            // trackBarBreathSpeed
            // 
            this.trackBarBreathSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarBreathSpeed.Location = new System.Drawing.Point(167, 253);
            this.trackBarBreathSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarBreathSpeed.Maximum = 5;
            this.trackBarBreathSpeed.Minimum = 1;
            this.trackBarBreathSpeed.Name = "trackBarBreathSpeed";
            this.trackBarBreathSpeed.Size = new System.Drawing.Size(180, 45);
            this.trackBarBreathSpeed.TabIndex = 17;
            this.trackBarBreathSpeed.Value = 1;
            this.trackBarBreathSpeed.ValueChanged += new System.EventHandler(this.TrackBar_BreathSpeed);
            // 
            // trackBarBreathSize
            // 
            this.trackBarBreathSize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarBreathSize.Location = new System.Drawing.Point(167, 220);
            this.trackBarBreathSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarBreathSize.Maximum = 5;
            this.trackBarBreathSize.Minimum = 1;
            this.trackBarBreathSize.Name = "trackBarBreathSize";
            this.trackBarBreathSize.Size = new System.Drawing.Size(180, 45);
            this.trackBarBreathSize.TabIndex = 16;
            this.trackBarBreathSize.Value = 1;
            this.trackBarBreathSize.Scroll += new System.EventHandler(this.TrackBar_BreathSize);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Частота дыхания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Размер дыхания";
            // 
            // buttonStopBreath
            // 
            this.buttonStopBreath.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStopBreath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopBreath.Location = new System.Drawing.Point(264, 184);
            this.buttonStopBreath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopBreath.Name = "buttonStopBreath";
            this.buttonStopBreath.Size = new System.Drawing.Size(74, 22);
            this.buttonStopBreath.TabIndex = 13;
            this.buttonStopBreath.Text = "Stop";
            this.buttonStopBreath.UseVisualStyleBackColor = false;
            this.buttonStopBreath.Click += new System.EventHandler(this.Click_StopBreath);
            // 
            // buttonStartBreath
            // 
            this.buttonStartBreath.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStartBreath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartBreath.Location = new System.Drawing.Point(175, 184);
            this.buttonStartBreath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartBreath.Name = "buttonStartBreath";
            this.buttonStartBreath.Size = new System.Drawing.Size(74, 22);
            this.buttonStartBreath.TabIndex = 12;
            this.buttonStartBreath.Text = "Start";
            this.buttonStartBreath.UseVisualStyleBackColor = false;
            this.buttonStartBreath.Click += new System.EventHandler(this.Click_StartBreath);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Активация дыхания";
            // 
            // buttonStartMove
            // 
            this.buttonStartMove.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStartMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartMove.Location = new System.Drawing.Point(175, 51);
            this.buttonStartMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartMove.Name = "buttonStartMove";
            this.buttonStartMove.Size = new System.Drawing.Size(74, 22);
            this.buttonStartMove.TabIndex = 4;
            this.buttonStartMove.Text = "Start";
            this.buttonStartMove.UseVisualStyleBackColor = false;
            this.buttonStartMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StartMove);
            // 
            // buttonStopMove
            // 
            this.buttonStopMove.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStopMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopMove.Location = new System.Drawing.Point(264, 51);
            this.buttonStopMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStopMove.Name = "buttonStopMove";
            this.buttonStopMove.Size = new System.Drawing.Size(74, 22);
            this.buttonStopMove.TabIndex = 5;
            this.buttonStopMove.Text = "Stop";
            this.buttonStopMove.UseVisualStyleBackColor = false;
            this.buttonStopMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StopMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Активация движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Скорость фигуры";
            // 
            // trackBarFigureSpeed
            // 
            this.trackBarFigureSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarFigureSpeed.Location = new System.Drawing.Point(167, 113);
            this.trackBarFigureSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarFigureSpeed.Maximum = 5;
            this.trackBarFigureSpeed.Minimum = 1;
            this.trackBarFigureSpeed.Name = "trackBarFigureSpeed";
            this.trackBarFigureSpeed.Size = new System.Drawing.Size(180, 45);
            this.trackBarFigureSpeed.TabIndex = 6;
            this.trackBarFigureSpeed.Value = 1;
            this.trackBarFigureSpeed.ValueChanged += new System.EventHandler(this.TrackBar_FigureSpeed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер фигуры";
            // 
            // trackBarFigureSize
            // 
            this.trackBarFigureSize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarFigureSize.Location = new System.Drawing.Point(167, 82);
            this.trackBarFigureSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarFigureSize.Minimum = 1;
            this.trackBarFigureSize.Name = "trackBarFigureSize";
            this.trackBarFigureSize.Size = new System.Drawing.Size(180, 45);
            this.trackBarFigureSize.TabIndex = 7;
            this.trackBarFigureSize.Value = 1;
            this.trackBarFigureSize.Scroll += new System.EventHandler(this.TrackBar_FigureSize);
            // 
            // Timer
            // 
            this.Timer.Interval = 80;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1034, 565);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTrajectorySize)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBreathSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFigureSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFigureSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar trackBarTrajectorySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarFigureSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarFigureSpeed;
        private System.Windows.Forms.Button buttonStartMove;
        private System.Windows.Forms.Button buttonStopMove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarBreathSpeed;
        private System.Windows.Forms.TrackBar trackBarBreathSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStopBreath;
        private System.Windows.Forms.Button buttonStartBreath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChooseFigureColor;
        private System.Windows.Forms.Button buttonChooseTrajectoryColor;
        private System.Windows.Forms.Button buttonChooseBackgroundColor;
        private System.Windows.Forms.ColorDialog chooseColor;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonEnterText;
        private System.Windows.Forms.Label label8;
    }
}

