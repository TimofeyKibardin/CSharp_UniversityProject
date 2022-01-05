
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
            this.buttonChooseFigureColor = new System.Windows.Forms.Button();
            this.buttonChooseTrajectoryColor = new System.Windows.Forms.Button();
            this.buttonChooseBackgroundColor = new System.Windows.Forms.Button();
            this.trackBarBreathSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarBreathSize = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
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
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1182, 753);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.BackColorChanged += new System.EventHandler(this.PictureBox_BackColorChanged);
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.Resize += new System.EventHandler(this.PictureBox_Resize);
            // 
            // trackBarTrajectorySize
            // 
            this.trackBarTrajectorySize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarTrajectorySize.Location = new System.Drawing.Point(191, 9);
            this.trackBarTrajectorySize.Maximum = 11;
            this.trackBarTrajectorySize.Minimum = 1;
            this.trackBarTrajectorySize.Name = "trackBarTrajectorySize";
            this.trackBarTrajectorySize.Size = new System.Drawing.Size(206, 56);
            this.trackBarTrajectorySize.TabIndex = 1;
            this.trackBarTrajectorySize.Value = 11;
            this.trackBarTrajectorySize.ValueChanged += new System.EventHandler(this.TrackBar_TrajectorySize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер траектории";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Honeydew;
            this.controlPanel.Controls.Add(this.buttonChooseFigureColor);
            this.controlPanel.Controls.Add(this.buttonChooseTrajectoryColor);
            this.controlPanel.Controls.Add(this.buttonChooseBackgroundColor);
            this.controlPanel.Controls.Add(this.trackBarBreathSpeed);
            this.controlPanel.Controls.Add(this.trackBarBreathSize);
            this.controlPanel.Controls.Add(this.label7);
            this.controlPanel.Controls.Add(this.label6);
            this.controlPanel.Controls.Add(this.button2);
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.buttonStart);
            this.controlPanel.Controls.Add(this.buttonStop);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.trackBarFigureSpeed);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.trackBarFigureSize);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.trackBarTrajectorySize);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(734, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(448, 753);
            this.controlPanel.TabIndex = 3;
            // 
            // buttonChooseFigureColor
            // 
            this.buttonChooseFigureColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseFigureColor.Location = new System.Drawing.Point(317, 393);
            this.buttonChooseFigureColor.Name = "buttonChooseFigureColor";
            this.buttonChooseFigureColor.Size = new System.Drawing.Size(102, 100);
            this.buttonChooseFigureColor.TabIndex = 19;
            this.buttonChooseFigureColor.Text = "Выбрать цвет фигуры";
            this.buttonChooseFigureColor.UseVisualStyleBackColor = true;
            this.buttonChooseFigureColor.Click += new System.EventHandler(this.Click_ChooseFigureColor);
            // 
            // buttonChooseTrajectoryColor
            // 
            this.buttonChooseTrajectoryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseTrajectoryColor.Location = new System.Drawing.Point(172, 393);
            this.buttonChooseTrajectoryColor.Name = "buttonChooseTrajectoryColor";
            this.buttonChooseTrajectoryColor.Size = new System.Drawing.Size(102, 100);
            this.buttonChooseTrajectoryColor.TabIndex = 18;
            this.buttonChooseTrajectoryColor.Text = "Выбрать цвет траектории";
            this.buttonChooseTrajectoryColor.UseVisualStyleBackColor = true;
            this.buttonChooseTrajectoryColor.Click += new System.EventHandler(this.Click_ChooseTrajectoryColor);
            // 
            // buttonChooseBackgroundColor
            // 
            this.buttonChooseBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseBackgroundColor.Location = new System.Drawing.Point(27, 393);
            this.buttonChooseBackgroundColor.Name = "buttonChooseBackgroundColor";
            this.buttonChooseBackgroundColor.Size = new System.Drawing.Size(102, 100);
            this.buttonChooseBackgroundColor.TabIndex = 4;
            this.buttonChooseBackgroundColor.Text = "Выбрать цвет фона";
            this.buttonChooseBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonChooseBackgroundColor.Click += new System.EventHandler(this.Click_ChooseBackgroundColor);
            // 
            // trackBarBreathSpeed
            // 
            this.trackBarBreathSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarBreathSpeed.Location = new System.Drawing.Point(191, 337);
            this.trackBarBreathSpeed.Maximum = 5;
            this.trackBarBreathSpeed.Minimum = 1;
            this.trackBarBreathSpeed.Name = "trackBarBreathSpeed";
            this.trackBarBreathSpeed.Size = new System.Drawing.Size(206, 56);
            this.trackBarBreathSpeed.TabIndex = 17;
            this.trackBarBreathSpeed.Value = 1;
            this.trackBarBreathSpeed.ValueChanged += new System.EventHandler(this.TrackBar_BreathSpeed);
            // 
            // trackBarBreathSize
            // 
            this.trackBarBreathSize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarBreathSize.Location = new System.Drawing.Point(191, 293);
            this.trackBarBreathSize.Maximum = 5;
            this.trackBarBreathSize.Minimum = 1;
            this.trackBarBreathSize.Name = "trackBarBreathSize";
            this.trackBarBreathSize.Size = new System.Drawing.Size(206, 56);
            this.trackBarBreathSize.TabIndex = 16;
            this.trackBarBreathSize.Value = 1;
            this.trackBarBreathSize.Scroll += new System.EventHandler(this.TrackBar_BreathSize);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Частота дыхания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Размер дыхания";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(302, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Click_StopBreath);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(200, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Click_StartBreath);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Активация дыхания";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Location = new System.Drawing.Point(200, 68);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 29);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StartMove);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.Location = new System.Drawing.Point(302, 68);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 29);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StopMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Активация движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Скорость фигуры";
            // 
            // trackBarFigureSpeed
            // 
            this.trackBarFigureSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarFigureSpeed.Location = new System.Drawing.Point(191, 151);
            this.trackBarFigureSpeed.Maximum = 5;
            this.trackBarFigureSpeed.Minimum = 1;
            this.trackBarFigureSpeed.Name = "trackBarFigureSpeed";
            this.trackBarFigureSpeed.Size = new System.Drawing.Size(206, 56);
            this.trackBarFigureSpeed.TabIndex = 6;
            this.trackBarFigureSpeed.Value = 1;
            this.trackBarFigureSpeed.ValueChanged += new System.EventHandler(this.TrackBar_FigureSpeed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер фигуры";
            // 
            // trackBarFigureSize
            // 
            this.trackBarFigureSize.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarFigureSize.Location = new System.Drawing.Point(191, 109);
            this.trackBarFigureSize.Minimum = 1;
            this.trackBarFigureSize.Name = "trackBarFigureSize";
            this.trackBarFigureSize.Size = new System.Drawing.Size(206, 56);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBox);
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
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarBreathSpeed;
        private System.Windows.Forms.TrackBar trackBarBreathSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChooseFigureColor;
        private System.Windows.Forms.Button buttonChooseTrajectoryColor;
        private System.Windows.Forms.Button buttonChooseBackgroundColor;
        private System.Windows.Forms.ColorDialog chooseColor;
    }
}

