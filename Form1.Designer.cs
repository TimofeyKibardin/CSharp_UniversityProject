
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
            ChangeClipboardChain(this.Handle, nextClipboardViewer);
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
            this.buttonTrajectoryHypocycloid = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonPasteText = new System.Windows.Forms.Button();
            this.buttonCopyText = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonVariant8 = new System.Windows.Forms.Button();
            this.buttonTrajectoryCloud = new System.Windows.Forms.Button();
            this.buttonEnterTrajectory = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEnterText = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.pictureBox.Size = new System.Drawing.Size(1182, 931);
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
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер траектории";
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Honeydew;
            this.controlPanel.Controls.Add(this.buttonTrajectoryHypocycloid);
            this.controlPanel.Controls.Add(this.label17);
            this.controlPanel.Controls.Add(this.richTextBox1);
            this.controlPanel.Controls.Add(this.comboBoxFigure);
            this.controlPanel.Controls.Add(this.label16);
            this.controlPanel.Controls.Add(this.label15);
            this.controlPanel.Controls.Add(this.label14);
            this.controlPanel.Controls.Add(this.label13);
            this.controlPanel.Controls.Add(this.textBox5);
            this.controlPanel.Controls.Add(this.textBox4);
            this.controlPanel.Controls.Add(this.label12);
            this.controlPanel.Controls.Add(this.buttonSaveAll);
            this.controlPanel.Controls.Add(this.label11);
            this.controlPanel.Controls.Add(this.buttonPasteText);
            this.controlPanel.Controls.Add(this.buttonCopyText);
            this.controlPanel.Controls.Add(this.label10);
            this.controlPanel.Controls.Add(this.buttonVariant8);
            this.controlPanel.Controls.Add(this.buttonTrajectoryCloud);
            this.controlPanel.Controls.Add(this.buttonEnterTrajectory);
            this.controlPanel.Controls.Add(this.textBox3);
            this.controlPanel.Controls.Add(this.textBox2);
            this.controlPanel.Controls.Add(this.label9);
            this.controlPanel.Controls.Add(this.buttonEnterText);
            this.controlPanel.Controls.Add(this.label8);
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
            this.controlPanel.Location = new System.Drawing.Point(734, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(448, 931);
            this.controlPanel.TabIndex = 3;
            // 
            // buttonTrajectoryHypocycloid
            // 
            this.buttonTrajectoryHypocycloid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrajectoryHypocycloid.Location = new System.Drawing.Point(275, 531);
            this.buttonTrajectoryHypocycloid.Name = "buttonTrajectoryHypocycloid";
            this.buttonTrajectoryHypocycloid.Size = new System.Drawing.Size(94, 29);
            this.buttonTrajectoryHypocycloid.TabIndex = 42;
            this.buttonTrajectoryHypocycloid.Text = "Гипоцикл.";
            this.buttonTrajectoryHypocycloid.UseVisualStyleBackColor = true;
            this.buttonTrajectoryHypocycloid.Click += new System.EventHandler(this.Click_DrawHypocycloid);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(3, 708);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 21);
            this.label17.TabIndex = 41;
            this.label17.Text = "Служебное сообщение";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(200, 708);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(235, 111);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.AutoCompleteCustomSource.AddRange(new string[] {
            "Квадрат",
            "Треугольник",
            "Фигура_Вариант8",
            "Фигура_Вариант19"});
            this.comboBoxFigure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxFigure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Location = new System.Drawing.Point(200, 372);
            this.comboBoxFigure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(156, 28);
            this.comboBoxFigure.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(299, 467);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Pi /";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 20);
            this.label15.TabIndex = 37;
            this.label15.Text = "Pi /";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "От";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "До";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(336, 464);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "4";
            this.textBox5.Size = new System.Drawing.Size(75, 27);
            this.textBox5.TabIndex = 34;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 464);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "3";
            this.textBox4.Size = new System.Drawing.Size(75, 27);
            this.textBox4.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(6, 633);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "Сохранение настроек";
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.BackColor = System.Drawing.Color.Gold;
            this.buttonSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveAll.Location = new System.Drawing.Point(200, 624);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(235, 37);
            this.buttonSaveAll.TabIndex = 31;
            this.buttonSaveAll.Text = "SAVE";
            this.buttonSaveAll.UseVisualStyleBackColor = false;
            this.buttonSaveAll.Click += new System.EventHandler(this.Click_SaveSettings);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(87, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Copy/Paste";
            // 
            // buttonPasteText
            // 
            this.buttonPasteText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPasteText.Location = new System.Drawing.Point(323, 576);
            this.buttonPasteText.Name = "buttonPasteText";
            this.buttonPasteText.Size = new System.Drawing.Size(112, 29);
            this.buttonPasteText.TabIndex = 29;
            this.buttonPasteText.Text = "Paste";
            this.buttonPasteText.UseVisualStyleBackColor = true;
            this.buttonPasteText.Click += new System.EventHandler(this.Click_PasteText);
            // 
            // buttonCopyText
            // 
            this.buttonCopyText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyText.Location = new System.Drawing.Point(200, 576);
            this.buttonCopyText.Name = "buttonCopyText";
            this.buttonCopyText.Size = new System.Drawing.Size(112, 29);
            this.buttonCopyText.TabIndex = 4;
            this.buttonCopyText.Text = "Copy";
            this.buttonCopyText.UseVisualStyleBackColor = true;
            this.buttonCopyText.Click += new System.EventHandler(this.Click_CopyText);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(17, 533);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Другие траектории";
            // 
            // buttonVariant8
            // 
            this.buttonVariant8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVariant8.Location = new System.Drawing.Point(371, 531);
            this.buttonVariant8.Name = "buttonVariant8";
            this.buttonVariant8.Size = new System.Drawing.Size(74, 29);
            this.buttonVariant8.TabIndex = 27;
            this.buttonVariant8.Text = "8 Вар.";
            this.buttonVariant8.UseVisualStyleBackColor = true;
            this.buttonVariant8.Click += new System.EventHandler(this.Click_DrawTrajectoryVariant8);
            // 
            // buttonTrajectoryCloud
            // 
            this.buttonTrajectoryCloud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrajectoryCloud.Location = new System.Drawing.Point(200, 531);
            this.buttonTrajectoryCloud.Name = "buttonTrajectoryCloud";
            this.buttonTrajectoryCloud.Size = new System.Drawing.Size(69, 29);
            this.buttonTrajectoryCloud.TabIndex = 26;
            this.buttonTrajectoryCloud.Text = "Облако";
            this.buttonTrajectoryCloud.UseVisualStyleBackColor = true;
            this.buttonTrajectoryCloud.Click += new System.EventHandler(this.Click_DrawCloud);
            // 
            // buttonEnterTrajectory
            // 
            this.buttonEnterTrajectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterTrajectory.Location = new System.Drawing.Point(23, 463);
            this.buttonEnterTrajectory.Name = "buttonEnterTrajectory";
            this.buttonEnterTrajectory.Size = new System.Drawing.Size(165, 28);
            this.buttonEnterTrajectory.TabIndex = 25;
            this.buttonEnterTrajectory.Text = "Enter";
            this.buttonEnterTrajectory.UseVisualStyleBackColor = true;
            this.buttonEnterTrajectory.Click += new System.EventHandler(this.Click_EnterTrajectoryName);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(336, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "4";
            this.textBox3.Size = new System.Drawing.Size(75, 27);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 420);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "3";
            this.textBox2.Size = new System.Drawing.Size(75, 27);
            this.textBox2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Выбор траектории";
            // 
            // buttonEnterText
            // 
            this.buttonEnterText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnterText.Location = new System.Drawing.Point(363, 371);
            this.buttonEnterText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEnterText.Name = "buttonEnterText";
            this.buttonEnterText.Size = new System.Drawing.Size(73, 29);
            this.buttonEnterText.TabIndex = 21;
            this.buttonEnterText.Text = "Enter";
            this.buttonEnterText.UseVisualStyleBackColor = true;
            this.buttonEnterText.Click += new System.EventHandler(this.Click_EnterFigureName);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(53, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Выбор фигуры";
            // 
            // buttonChooseFigureColor
            // 
            this.buttonChooseFigureColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseFigureColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChooseFigureColor.Location = new System.Drawing.Point(0, 827);
            this.buttonChooseFigureColor.Name = "buttonChooseFigureColor";
            this.buttonChooseFigureColor.Size = new System.Drawing.Size(448, 35);
            this.buttonChooseFigureColor.TabIndex = 19;
            this.buttonChooseFigureColor.Text = "Выбрать цвет фигуры";
            this.buttonChooseFigureColor.UseVisualStyleBackColor = true;
            this.buttonChooseFigureColor.Click += new System.EventHandler(this.Click_ChooseFigureColor);
            // 
            // buttonChooseTrajectoryColor
            // 
            this.buttonChooseTrajectoryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseTrajectoryColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChooseTrajectoryColor.Location = new System.Drawing.Point(0, 862);
            this.buttonChooseTrajectoryColor.Name = "buttonChooseTrajectoryColor";
            this.buttonChooseTrajectoryColor.Size = new System.Drawing.Size(448, 36);
            this.buttonChooseTrajectoryColor.TabIndex = 18;
            this.buttonChooseTrajectoryColor.Text = "Выбрать цвет траектории";
            this.buttonChooseTrajectoryColor.UseVisualStyleBackColor = true;
            this.buttonChooseTrajectoryColor.Click += new System.EventHandler(this.Click_ChooseTrajectoryColor);
            // 
            // buttonChooseBackgroundColor
            // 
            this.buttonChooseBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChooseBackgroundColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChooseBackgroundColor.Location = new System.Drawing.Point(0, 898);
            this.buttonChooseBackgroundColor.Name = "buttonChooseBackgroundColor";
            this.buttonChooseBackgroundColor.Size = new System.Drawing.Size(448, 33);
            this.buttonChooseBackgroundColor.TabIndex = 4;
            this.buttonChooseBackgroundColor.Text = "Выбрать цвет фона";
            this.buttonChooseBackgroundColor.UseVisualStyleBackColor = true;
            this.buttonChooseBackgroundColor.Click += new System.EventHandler(this.Click_ChooseBackgroundColor);
            // 
            // trackBarBreathSpeed
            // 
            this.trackBarBreathSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarBreathSpeed.Location = new System.Drawing.Point(191, 301);
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
            this.trackBarBreathSize.Location = new System.Drawing.Point(191, 259);
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
            this.label7.Location = new System.Drawing.Point(35, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Частота дыхания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Размер дыхания";
            // 
            // buttonStopBreath
            // 
            this.buttonStopBreath.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStopBreath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopBreath.Location = new System.Drawing.Point(302, 213);
            this.buttonStopBreath.Name = "buttonStopBreath";
            this.buttonStopBreath.Size = new System.Drawing.Size(85, 29);
            this.buttonStopBreath.TabIndex = 13;
            this.buttonStopBreath.Text = "Stop";
            this.buttonStopBreath.UseVisualStyleBackColor = false;
            this.buttonStopBreath.Click += new System.EventHandler(this.Click_StopBreath);
            // 
            // buttonStartBreath
            // 
            this.buttonStartBreath.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStartBreath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartBreath.Location = new System.Drawing.Point(200, 213);
            this.buttonStartBreath.Name = "buttonStartBreath";
            this.buttonStartBreath.Size = new System.Drawing.Size(85, 29);
            this.buttonStartBreath.TabIndex = 12;
            this.buttonStartBreath.Text = "Start";
            this.buttonStartBreath.UseVisualStyleBackColor = false;
            this.buttonStartBreath.Click += new System.EventHandler(this.Click_StartBreath);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Активация дыхания";
            // 
            // buttonStartMove
            // 
            this.buttonStartMove.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonStartMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartMove.Location = new System.Drawing.Point(200, 68);
            this.buttonStartMove.Name = "buttonStartMove";
            this.buttonStartMove.Size = new System.Drawing.Size(85, 29);
            this.buttonStartMove.TabIndex = 2;
            this.buttonStartMove.Text = "Start";
            this.buttonStartMove.UseVisualStyleBackColor = false;
            this.buttonStartMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StartMove);
            // 
            // buttonStopMove
            // 
            this.buttonStopMove.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStopMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStopMove.Location = new System.Drawing.Point(302, 68);
            this.buttonStopMove.Name = "buttonStopMove";
            this.buttonStopMove.Size = new System.Drawing.Size(85, 29);
            this.buttonStopMove.TabIndex = 3;
            this.buttonStopMove.Text = "Stop";
            this.buttonStopMove.UseVisualStyleBackColor = false;
            this.buttonStopMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_StopMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Активация движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 151);
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
            this.trackBarFigureSpeed.TabIndex = 5;
            this.trackBarFigureSpeed.Value = 1;
            this.trackBarFigureSpeed.ValueChanged += new System.EventHandler(this.TrackBar_FigureSpeed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 109);
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
            this.trackBarFigureSize.TabIndex = 4;
            this.trackBarFigureSize.Value = 10;
            this.trackBarFigureSize.Scroll += new System.EventHandler(this.TrackBar_FigureSize);
            // 
            // Timer
            // 
            this.Timer.Interval = 50;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 931);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBox);
            this.Name = "mainForm";
            this.Text = "Moving Figure App";
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
        private System.Windows.Forms.Button buttonEnterText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonEnterTrajectory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonVariant8;
        private System.Windows.Forms.Button buttonTrajectoryCloud;
        private System.Windows.Forms.Button buttonPasteText;
        private System.Windows.Forms.Button buttonCopyText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonTrajectoryHypocycloid;
    }
}

