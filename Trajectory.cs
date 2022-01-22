using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KibardinTN_Project
{
	
	public abstract class Trajectory
	{
		public double X { get; set; } //Координата X
		public double Y { get; set; } //Координата Y
		public double XStart { get; set; } //Стартовый X
		public double YStart { get; set; } //Старотовый Y

		protected double a = 200;
		protected double b = 140;

		private double angleStart = 0; //Начальный угол, базовое значение
		public double AngleStart
        {
			get { return angleStart; }
			set { angleStart = value; }
        }
		private double angleLimit = Math.PI; //Конечный угол, базовое значение
		public double AngleLimit
        {
			get { return angleLimit; }
			set { angleLimit = value; }
        }
		public double AngleNextValue { get; set; }

		public double Step { get; set; } //Шаг
		private double scale = 1; //Масштаб базовое значение
		public double Scale
        {
			get { return scale; }
			set { scale = value; }
        }
		private Point[] trajectoryPoints = new Point[200]; //Массив на 200 точек
		public Point[] TrajectoryPoints
        {
			get { return trajectoryPoints; }
			set {}
        }
		public Graphics TrajectoryGraphic { get; set; } //Графика
		public Pen TrajectoryPen { get; set; } //Ручка

		private Color trajectoryColor = Color.Blue; //Базовый цвет траектории
		public Color TrajectoryColor
        {
			get { return trajectoryColor; }
			set { trajectoryColor = value; }
        }

		public abstract void Draw(PictureBox pb); //Абстрактный метод Draw
	}
}
