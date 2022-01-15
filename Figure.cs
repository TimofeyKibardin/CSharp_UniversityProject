using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KibardinTN_Project
{
	
	public abstract class Figure : MoveableObject
	{

        protected abstract Point[] CreateFigure(Point[] coordinatesArray);
		public abstract void MoveWithoutBreath(PictureBox pb, Trajectory trajec);
		public abstract void MoveWithBreath(PictureBox pb, Trajectory trajec);
	}
}
