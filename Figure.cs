using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	abstract class Figure : MoveableObject
	{
		protected Point[] figureCoordinatesArray;
		public int FigureSize { get; set; }
		public bool IsBreathOn { get; set; }
		protected bool breathStatus = true;
		protected int breathIncrement = 1;
		public int BreathSpeed { get; set; }
		public int BreathSize { get; set; }

        protected abstract Point[] CreateFigure(Point[] coordinatesArray);
		public abstract void MoveWithoutBreath(PictureBox pb, Trajectory trajec);
		public abstract void MoveWithBreath(PictureBox pb, Trajectory trajec);
	}
}
