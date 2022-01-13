using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace KibardinTN_Project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            AutoCompleteTextBox1();

            textBox.Text = Properties.Settings.Default.textBoxText;
            textBox2.Text = Properties.Settings.Default.textBoxText2;
            textBox3.Text = Properties.Settings.Default.textBoxText3;
            textBox4.Text = Properties.Settings.Default.textBoxText4;
            textBox5.Text = Properties.Settings.Default.textBoxText5;
            trajectory.TrajectoryColor = Properties.Settings.Default.trajectoryColor;
            figure.FigureColor = Properties.Settings.Default.figureColor;
            pictureBox.BackColor = Properties.Settings.Default.backgroundColor;
            trackBarBreathSize.Value = Properties.Settings.Default.breathSize;
            trackBarBreathSpeed.Value = Properties.Settings.Default.breathSpeed;
            trackBarTrajectorySize.Value = Properties.Settings.Default.trajectorySize;
            Timer.Enabled = Properties.Settings.Default.timerIsOn;
            figure.IsBreathOn = Properties.Settings.Default.breathIsOn;
            wordForCopyStatus = Properties.Settings.Default.wordStatusForCopyArray.Split(',');
        }

        private void Click_SaveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.textBoxText = textBox.Text; //Первый текст бокс
            Properties.Settings.Default.textBoxText2 = textBox2.Text; //Второй текст бокс
            Properties.Settings.Default.textBoxText3 = textBox3.Text; //Третий текст бокс
            Properties.Settings.Default.textBoxText4 = textBox4.Text; //Четвёртый текст бокс
            Properties.Settings.Default.textBoxText5 = textBox5.Text; //Пятый текст бокс
            Properties.Settings.Default.trajectoryColor = trajectory.TrajectoryColor; //Цвет траектории
            Properties.Settings.Default.figureColor = figure.FigureColor; //Цвет фигуры
            Properties.Settings.Default.backgroundColor = pictureBox.BackColor; //Цвет фона
            Properties.Settings.Default.breathSize = trackBarBreathSize.Value; //Значение величины дыхания
            Properties.Settings.Default.breathSpeed = trackBarBreathSpeed.Value; //Значение скорости дыхания
            Properties.Settings.Default.trajectorySize = trackBarTrajectorySize.Value; //Значение размера траектории
            Properties.Settings.Default.timerIsOn = Timer.Enabled; //Включено ли движение фигуры
            Properties.Settings.Default.breathIsOn = figure.IsBreathOn; //Включено ли дыхание фигуры
            Properties.Settings.Default.wordStatusForCopyArray = String.Join(',', wordForCopyStatus);
            Properties.Settings.Default.Save();

            /*savedTrajectory = new XmlSerializer(trajectory.GetType());
            savedFigure = new XmlSerializer(figure.GetType());

            using (FileStream fs = new FileStream("savedData.xml", FileMode.OpenOrCreate))
            {
                savedTrajectory.Serialize(fs, trajectory);
                savedFigure.Serialize(fs, figure);
            }*/
        }

        private void Click_Deserialize(object sender, EventArgs e)
        {
            /*savedTrajectory = new XmlSerializer(trajectory.GetType());
            savedFigure = new XmlSerializer(figure.GetType());

            using (FileStream fs = new FileStream("savedData.xml", FileMode.OpenOrCreate))
            {
                trajectory = (Trajectory)savedTrajectory.Deserialize(fs);
                figure = (Figure)savedFigure.Deserialize(fs);
            }*/
        }

        private void AutoCompleteTextBox1()
        {
            AutoCompleteStringCollection source1 = new AutoCompleteStringCollection()
            {
                "Квадрат",
                "Треугольник",
                "Фигура_Вариант8"
            };
            textBox.AutoCompleteCustomSource = source1;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        Trajectory trajectory = new Ellipse(); //Создание объекта траектории
        Figure figure = new MyFigure(); //Создание объекта фигуры
        String figureName; //Имя фигуры, переменная для текстбокса
        StringBuilder wordForCopy = new StringBuilder(); //Строка для скопированного текста
        String[] wordForCopyStatus = new String[5] { "False", "False", "False", "False", "False" }; //Массив со статусом по наличию текста в текстовых ячейках
        public XmlSerializer savedTrajectory;
        public XmlSerializer savedFigure;


        //Изменение размера главной формы
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Refresh();
            PictureBox_Resize(sender, e);
        }

        //Отрисовка на PictureBox
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Height = ClientSize.Height;
            pictureBox.Width = ClientSize.Width;
            trajectory.Draw(pictureBox);
        }

        //Изменение размера PictureBox
        private void PictureBox_Resize(object sender, EventArgs e)
        {
            PictureBox_Paint(sender, null);
        }

        //Изменение размера траектории
        private void TrackBar_TrajectorySize(object sender, EventArgs e)
        {
            trajectory.Scale = trackBarTrajectorySize.Value / (double)(trackBarTrajectorySize.Maximum - trackBarTrajectorySize.Minimum);
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Тик таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh();
            figure.Move(pictureBox, trajectory);
        }

        //Кнопка, отвечающая за включение движения фигуры по траектории
        private void Click_StartMove(object sender, MouseEventArgs e)
        {
            Timer.Enabled = true;
        }

        //Кнопка, отвечающая за остановку движения фигуры
        private void Click_StopMove(object sender, MouseEventArgs e)
        {
            Timer.Enabled = false;
        }

        //Изменение размера фигуры
        private void TrackBar_FigureSize(object sender, EventArgs e)
        {
            figure.FigureSize = trackBarFigureSize.Value;
            Refresh();
        }

        //Изменение скорости движения фигуры по траектории
        private void TrackBar_FigureSpeed(object sender, EventArgs e)
        {
            figure.CenterMovingSpeed = trackBarFigureSpeed.Value;
        }

        //Изменение скорости дыхания фигуры
        private void TrackBar_BreathSpeed(object sender, EventArgs e)
        {
            figure.BreathSpeed = trackBarBreathSpeed.Value;
        }

        //Изменение размера дыхания фигуры
        private void TrackBar_BreathSize(object sender, EventArgs e)
        {
            figure.BreathSize = trackBarBreathSize.Value;
        }

        //Кнопка, отвечающая за начало дыхания фигуры
        private void Click_StartBreath(object sender, EventArgs e)
        {
            figure.IsBreathOn = true;
            Refresh();
        }

        //Кнопка, отвечающая за приостановку дыхания фигуры
        private void Click_StopBreath(object sender, EventArgs e)
        {
            figure.IsBreathOn = false;
            Refresh();
        }

        //Отрисовка траектории в PictureBox после смены цвета
        private void PictureBox_BackColorChanged(object sender, EventArgs e)
        {
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета траектории
        private void Click_ChooseTrajectoryColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            trajectory.TrajectoryColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета фигуры
        private void Click_ChooseFigureColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            figure.FigureColor = chooseColor.Color;
        }

        //Кнопка, отвечающая за смену цвета фона
        private void Click_ChooseBackgroundColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            pictureBox.BackColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за конвертацию figure в string-переменную
        private void Click_EnterFigureName(object sender, EventArgs e)
        {
            figureName = Convert.ToString(textBox.Text).ToUpper();

            if (figureName.Equals("КВАДРАТ") || figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                figure = new UserFigure(figureName);
                figure.Move(pictureBox, trajectory);
                figure.FigureColor = chooseColor.Color;
            }
            if (figureName.Equals("ФИГУРА_ВАРИАНТ8"))
            {
                figure = new MyFigure();
                figure.Move(pictureBox, trajectory);
                figure.FigureColor = chooseColor.Color;
            }
        }

        //Кнопка, отвечающая за конвертацию trajectory в string-переменную
        private void Click_EnterTrajectoryName(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text))
                && (!String.IsNullOrWhiteSpace(textBox4.Text)) && (!String.IsNullOrWhiteSpace(textBox5.Text)))
            {
                double fi1 = Double.Parse(textBox2.Text) * Math.PI / Double.Parse(textBox3.Text);
                double fi2 = Double.Parse(textBox4.Text) * Math.PI / Double.Parse(textBox5.Text);

                trajectory = new UserTrajectory
                {
                    AngleStart = fi1,
                    AngleLimit = fi2
                };
                trajectory.TrajectoryColor = chooseColor.Color;
                trajectory.Draw(pictureBox);
                Refresh();
            }
        }

        //Кнопка, отвечающая за отрисовку траектории в виде половины эпициклоида
        private void Click_DrawCloud(object sender, EventArgs e)
        {
            trajectory = new Epicycloid();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            Refresh();
        }

        //Кнопка, отвечающая за отрисовку изначальной траектории
        private void Click_DrawTrajectoryVariant8(object sender, EventArgs e)
        {
            trajectory = new Ellipse();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            Refresh();
        }

        //Кнопка, отвечающая за копирование текста из текстовых ячеек
        private void Click_CopyText(object sender, EventArgs e)
        {
            Clipboard.Clear();

            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                wordForCopy.Append(textBox.Text).Append(',');
                wordForCopyStatus[0] = "True";
            }
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                wordForCopy.Append(textBox2.Text).Append(',');
                wordForCopyStatus[1] = "True";
            }
            if (!String.IsNullOrWhiteSpace(textBox3.Text))
            {
                wordForCopy.Append(textBox3.Text).Append(',');
                wordForCopyStatus[2] = "True";
            }
            if (!String.IsNullOrWhiteSpace(textBox4.Text))
            {
                wordForCopy.Append(textBox4.Text).Append(',');
                wordForCopyStatus[3] = "True";
            }
            if (!String.IsNullOrWhiteSpace(textBox5.Text))
            {
                wordForCopy.Append(textBox5.Text);
                wordForCopyStatus[4] = "True";
            }

            Clipboard.SetDataObject(wordForCopy.ToString());
        }

        //Кнопка, отвечающая за подстановку текста в текстовые ячейки
        private void Click_PasteText(object sender, EventArgs e)
        {
            String[] pasteTextArray = new String[5];

            /*if (wordForCopy.ToString().Equals(Clipboard.GetText()))
            {
                    pasteTextArray = Clipboard.GetText().Split(',');
                    
                    for (int i = 0; i < 5; i++)
                    {
                        if (!wordForCopyStatus[i])
                        {
                            pasteTextArray[i] = "";
                        }
                    }
            }*/

            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(typeof(String)))
            {
                pasteTextArray = Clipboard.GetText().Split(',');
                for (int i = 0; i < wordForCopyStatus.Length; i++)
                {
                    bool status = bool.Parse(wordForCopyStatus[i]);
                    if (!status)
                    {
                        pasteTextArray[i] = "";
                    }
                }
            }

        textBox.Text = pasteTextArray[0];
        textBox2.Text = pasteTextArray[1];
        textBox3.Text = pasteTextArray[2];
        textBox4.Text = pasteTextArray[3];
        textBox5.Text = pasteTextArray[4];
        }
    }
}
