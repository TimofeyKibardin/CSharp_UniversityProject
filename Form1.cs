using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KibardinTN_Project
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            AutoCompleteTextBox1();
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

            AutoCompleteStringCollection source2 = new AutoCompleteStringCollection()
            {
                "0",
                "Pi/4",
                "Pi/2",
                "3Pi/4",
                "Pi",
                "5Pi/4",
                "3Pi/2",
                "7Pi/4",
            };
            textBox2.AutoCompleteCustomSource = source2;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox3.AutoCompleteCustomSource = source2;
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        static Trajectory trajectory = new Ellipse(); //Создание объекта траектории
        MoveableObject moveableObject = new MyFigure(); //Создание объекта фигуры
        String figureName; //Имя фигуры, переменная для текстбокса
        StringBuilder wordForCopy = new StringBuilder(); //Строка для скопированного текста
        bool[] wordForCopyStatus = new bool[3] { false, false, false }; //Массив со статусом по наличию текста в текстовых ячейках
        bool copyStatus = false; //Статус, скопировано или нет

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
            moveableObject.Move(pictureBox, trajectory);
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
            Figure figure = (Figure)moveableObject;
            figure.FigureSize = trackBarFigureSize.Value;
            Refresh();
        }

        //Изменение скорости движения фигуры по траектории
        private void TrackBar_FigureSpeed(object sender, EventArgs e)
        {
            moveableObject.CenterMovingSpeed = trackBarFigureSpeed.Value;
        }

        //Изменение скорости дыхания фигуры
        private void TrackBar_BreathSpeed(object sender, EventArgs e)
        {
            Figure figure = (Figure)moveableObject;
            figure.BreathSpeed = trackBarBreathSpeed.Value;
        }

        //Изменение размера дыхания фигуры
        private void TrackBar_BreathSize(object sender, EventArgs e)
        {
            Figure figure = (Figure)moveableObject;
            figure.BreathSize = trackBarBreathSize.Value;
        }

        //Кнопка, отвечающая за начало дыхания фигуры
        private void Click_StartBreath(object sender, EventArgs e)
        {
            Figure figure = (Figure)moveableObject;
            figure.IsBreathOn = true;
            Refresh();
        }

        //Кнопка, отвечающая за приостановку дыхания фигуры
        private void Click_StopBreath(object sender, EventArgs e)
        {
            Figure figure = (Figure)moveableObject;
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
            moveableObject.FigureColor = chooseColor.Color;
        }

        //Кнопка, отвечающая за смену цвета фона
        private void Click_ChooseBackgroundColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            pictureBox.BackColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Ячейка для ввода текста
        private void TextBox_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                figureName = textBox.Text;
            }
        }


        //Кнопка, отвечающая за конвертацию figure в string-переменную
        private void Click_EnterFigureName(object sender, EventArgs e)
        {
            figureName = Convert.ToString(textBox.Text).ToUpper();

            if (figureName.Equals("КВАДРАТ") || figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                moveableObject = new UserFigure(figureName);
                moveableObject.Move(pictureBox, trajectory);
                moveableObject.FigureColor = chooseColor.Color;
            }
            if (figureName.Equals("ФИГУРА_ВАРИАНТ8"))
            {
                moveableObject = new MyFigure();
                moveableObject.Move(pictureBox, trajectory);
                moveableObject.FigureColor = chooseColor.Color;
            }
        }

        //Кнопка, отвечающая за конвертацию trajectory в string-переменную
        private void Click_EnterTrajectoryName(object sender, EventArgs e)
        {
            double fi1 = 1;
            double fi2 = 1;

            if (textBox2.Text.Equals("0")) fi1 = 0;
            else if (textBox2.Text.Equals("Pi/4")) fi1 = Math.PI / 4;
            else if (textBox2.Text.Equals("Pi/2")) fi1 = Math.PI / 2;
            else if (textBox2.Text.Equals("3Pi/4")) fi1 = 3 * Math.PI / 4;
            else if (textBox2.Text.Equals("Pi")) fi1 = Math.PI;
            else if (textBox2.Text.Equals("5Pi/4")) fi1 = 5 * Math.PI / 4;
            else if (textBox2.Text.Equals("3Pi/2")) fi1 = 3 * Math.PI / 2;
            else if (textBox2.Text.Equals("7Pi/4")) fi1 = 7 * Math.PI / 4;

            if (textBox3.Text.Equals("0")) fi2 = 0;
            else if (textBox3.Text.Equals("Pi/4")) fi2 = Math.PI / 4;
            else if (textBox3.Text.Equals("Pi/2")) fi2 = Math.PI / 2;
            else if (textBox3.Text.Equals("3Pi/4")) fi2 = 3 * Math.PI / 4;
            else if (textBox3.Text.Equals("Pi")) fi2 = Math.PI;
            else if (textBox3.Text.Equals("5Pi/4")) fi2 = 5 * Math.PI / 4;
            else if (textBox3.Text.Equals("3Pi/2")) fi2 = 3 * Math.PI / 2;
            else if (textBox3.Text.Equals("7Pi/4")) fi2 = 7 * Math.PI / 4;

            trajectory = new UserTrajectory
            {
                AngleStart = fi1,
                AngleLimit = fi2
            };
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            Refresh();
        }

        private void Click_DrawCloud(object sender, EventArgs e)
        {
            trajectory = new Epicycloid();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            Refresh();
        }

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
            if (!copyStatus)
            {

                if (!String.IsNullOrWhiteSpace(textBox.Text))
                {
                    wordForCopy.Append(textBox.Text).Append(',');
                    wordForCopyStatus[0] = true;
                }
                if (!String.IsNullOrWhiteSpace(textBox2.Text))
                {
                    wordForCopy.Append(textBox2.Text).Append(',');
                    wordForCopyStatus[1] = true;
                }
                if (!String.IsNullOrWhiteSpace(textBox3.Text))
                {
                    wordForCopy.Append(textBox3.Text);
                    wordForCopyStatus[2] = true;
                }

                Clipboard.SetText(wordForCopy.ToString());
                copyStatus = true;
            }
        }

        //Кнопка, отвечающая за подстановку текста в текстовые ячейки
        private void Click_PasteText(object sender, EventArgs e)
        {
            if (copyStatus)
            {

                string[] pasteTextArray = new string[3];

                if (wordForCopy.ToString().Equals(Clipboard.GetText()))
                {
                    pasteTextArray = Clipboard.GetText().Split(',');
                    
                    for (int i = 0; i < wordForCopyStatus.Length; i++)
                    {
                        if (!wordForCopyStatus[i])
                        {
                            pasteTextArray[i] = "";
                        }
                    }
                }

                textBox.Text = pasteTextArray[0];
                textBox2.Text = pasteTextArray[1];
                textBox3.Text = pasteTextArray[2];

                wordForCopy.Clear();
                copyStatus = false;
            }
        }
    }
}
