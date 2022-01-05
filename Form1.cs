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

        //Изменение размера главной формы
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Refresh();
            PictureBox_Resize(sender, e);
        }

        //Отрисовка на PictureBox
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Height = (int)(ClientSize.Height * 0.7);
            pictureBox.Width = (int)(ClientSize.Width * 0.5);
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

        //Кнопка, отвечающая за смену цвета фона
        private void Click_ChooseBackgroundColor(object sender, MouseEventArgs e)
        {
            chooseColor.ShowDialog();
            pictureBox.BackColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета траектории
        private void Click_ChooseTrajectoryColor(object sender, MouseEventArgs e)
        {
            chooseColor.ShowDialog();
            trajectory.TrajectoryColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета фигуры
        private void Click_ChooseFigureColor(object sender, MouseEventArgs e)
        {
            chooseColor.ShowDialog();
            moveableObject.FigureColor = chooseColor.Color;
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Отрисовка траектории в PictureBox после смены цвета
        private void PictureBox_BackColorChanged(object sender, EventArgs e)
        {
            trajectory.Draw(pictureBox);
        }
    }
}
