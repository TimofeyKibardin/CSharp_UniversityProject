using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	class Ellipse : Trajectory
	{
		public Ellipse()
		{
		}

        private double a = 200;
        private double b = 140;
        private double fi = (5 * Math.PI / 2) - (3 * Math.PI / 2);

        public override void Draw(PictureBox pb)
        {
            /*
             * Устанавливаем начальную точку
             */
            XStart = pb.Width / 3;
            YStart = pb.Height / 2;
            TrajectoryGraphic = pb.CreateGraphics();
            TrajectoryPen = new Pen(TrajectoryColor, 3f);
            Step = (AngleLimit - AngleStart) / TrajectoryPoints.Length;
            AngleNextValue = AngleStart;
            /*
             * Расчёт координаты траектории
             */
            Step = fi / TrajectoryPoints.Length;
            for (int i = 0; i < TrajectoryPoints.Length; i++)
            {
                X = XStart + b * Math.Sin(AngleNextValue) * Scale;
                Y = YStart + a * Math.Cos(AngleNextValue) * Scale;
                TrajectoryPoints[i] = new Point((int)X, (int)Y);
                AngleNextValue += Step;
            }
            /*
             * Отрисовывание траектории по созданным точкам
             */
            TrajectoryGraphic.DrawPolygon(TrajectoryPen, TrajectoryPoints);
        }
    }
}
