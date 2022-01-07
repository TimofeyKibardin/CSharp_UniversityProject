using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        static Trajectory trajectory = new Ellipse(); //Создание объекта траектории
        MoveableObject moveableObject = new MyFigure(); //Создание объекта фигуры
        String figureName;

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

        //Кнопка, отвечающая за конвертацию текста в string-переменную
        private void Click_EnterFigureName(object sender, EventArgs e)
        {
            figureName = Convert.ToString(textBox.Text).ToUpper();

            if (figureName.Equals("КВАДРАТ") || figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                moveableObject = new UserFigure(figureName);
                moveableObject.Move(pictureBox, trajectory);
            }
        }
    }
}
