using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KibardinTN_Project
{
    [Serializable]
    public class Ellipse : Trajectory
	{
		public Ellipse()
		{
            AngleStart = 3 * Math.PI / 2;
            AngleLimit = 5 * Math.PI / 2;
        }

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
                X = XStart + b * Math.Cos(AngleNextValue) * Scale;
                Y = YStart - a * Math.Sin(AngleNextValue) * Scale;
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
