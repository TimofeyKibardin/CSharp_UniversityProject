using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	
	public abstract class MoveableObject : Trajectory
	{
		protected Point[] figureCoordinatesArray; //Массив точек, из которых будет состоять фигура
		private int figureSize = 1; //Базовое значение масштаба фигуры
		public int FigureSize
        {
			get { return figureSize; }
			set { figureSize = value; }
        }
		public bool IsBreathOn { get; set; } //Включено дыхание или нет
		protected bool breathStatus = true; //Дышит фигура или нет
		protected int breathIncrement = 1;
		public int BreathSpeed { get; set; }
		public int BreathSize { get; set; }

		private int centerMovingSpeed = 1; //Базовая скорость движения
		public int CenterMovingSpeed
        {
			get { return centerMovingSpeed; }
			set { centerMovingSpeed = value; }
        }
		private bool isEndOfLine = false; //Флаг, означающий конец линии
		private int i = 1;

		private Color figureColor = Color.Black; //Базовый цвет фигуры
		public Color FigureColor
        {
			get { return figureColor; }
			set { figureColor = value; }
        }

		/*
		 * Метод, отвечающий за передвижение центральной точки фигуры по траектории
		 */
		protected void MoveCentralPoint(PictureBox pb, Trajectory trajectory)
        {
            trajectory.Draw(pb);
            if (isEndOfLine)
            {
                if (i >= trajectory.TrajectoryPoints.Length - 1)
                {
                    isEndOfLine = false;
                }
                else
                {
                    if (i < (int)trajectory.AngleStart) i = (int)trajectory.AngleStart;
                    X = trajectory.TrajectoryPoints[i].X;
                    Y = trajectory.TrajectoryPoints[i].Y;
                    i += centerMovingSpeed;
                }
            }
            else
            {
                if (i == trajectory.AngleStart || i < trajectory.AngleStart)
                {
                    isEndOfLine = true;
                }
                else
                {
                    if (i > trajectory.TrajectoryPoints.Length - 1) i = trajectory.TrajectoryPoints.Length - 1;
                    X = trajectory.TrajectoryPoints[i].X;
                    Y = trajectory.TrajectoryPoints[i].Y;
                    i -= centerMovingSpeed;
                }
            }
        }

		/*
		 * Абстрактный метод, отвечающий за движение объекта по траектории
		 */
		public abstract void Move(PictureBox pb, Trajectory trajec);	
	}
}
