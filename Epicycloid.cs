using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	class Epicycloid : Trajectory
	{
		public Epicycloid()
		{
            AngleStart = Math.PI;
            AngleLimit = 2 * Math.PI;
		}

        private double radius = 20;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        private int k = 6;

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
            for (int i = 0; i < TrajectoryPoints.Length; i++)
            {
                X = XStart + radius * (k + 1) * (Math.Cos(AngleNextValue) - (Math.Cos((k + 1) * AngleNextValue) / (k + 1))) * Scale;
                Y = YStart + radius * (k + 1) * (Math.Sin(AngleNextValue) - (Math.Sin((k + 1) * AngleNextValue) / (k + 1))) * Scale;
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
