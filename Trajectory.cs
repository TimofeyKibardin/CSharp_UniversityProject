﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	abstract class Trajectory
	{
		public double X { get; set; } //Координата X
		public double Y { get; set; } //Координата Y
		public double XStart { get; set; } //Стартовый X
		public double YStart { get; set; } //Старотовый Y

		private double angleStart = 0; //Начальный угол
		public double AngleStart
        {
			get { return angleStart; }
			set { angleStart = value; }
        }
		private double angleLimit = Math.PI;
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
		private Point[] trajectoryPoints = new Point[100]; //Массив на 100 точек
		public Point[] TrajectoryPoints
        {
			get { return trajectoryPoints; }
			private set {}
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
