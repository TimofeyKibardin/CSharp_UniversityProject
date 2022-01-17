using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
    
    public class UserFigure : Figure
	{
        public UserFigure()
        {
        }

		public UserFigure(String figureName)
		{
            this.figureName = figureName;
        }
        String figureName;
        private Point squareCenter; //Центр квадрата
        private Point triangleCenter; //Центр треугольника

        protected override Point[] CreateFigure(Point[] coordinatesArray)
        {
            if (figureName.Equals("КВАДРАТ"))
            {
                figureCoordinatesArray = new Point[4];
                squareCenter = new Point((int)X, (int)Y);
                figureCoordinatesArray[0] = new Point(squareCenter.X - (FigureSize + 20 + breathIncrement), squareCenter.Y + (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[1] = new Point(squareCenter.X + (FigureSize + 20 + breathIncrement), squareCenter.Y + (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[2] = new Point(squareCenter.X + (FigureSize + 20 + breathIncrement), squareCenter.Y - (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[3] = new Point(squareCenter.X - (FigureSize + 20 + breathIncrement), squareCenter.Y - (FigureSize + 20 + breathIncrement));
            }
            if (figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                figureCoordinatesArray = new Point[3];
                triangleCenter = new Point((int)X, (int)Y);
                figureCoordinatesArray[0] = new Point(triangleCenter.X, triangleCenter.Y + (FigureSize + breathIncrement + 10));
                figureCoordinatesArray[1] = new Point(triangleCenter.X + (FigureSize + 10 + breathIncrement), triangleCenter.Y - (FigureSize + 10 + breathIncrement));
                figureCoordinatesArray[2] = new Point(triangleCenter.X - (FigureSize + 10 + breathIncrement), triangleCenter.Y - (FigureSize + 10 + breathIncrement));
            }

            return figureCoordinatesArray;
        }

        public override void Draw(PictureBox pb)
        {
            throw new NotImplementedException();
        }

        public override void Move(PictureBox pb, Trajectory trajec)
        {
            if (IsBreathOn) MoveWithBreath(pb, trajec);
            else MoveWithoutBreath(pb, trajec);
        }

        public override void MoveWithBreath(PictureBox pb, Trajectory trajec)
        {
            if (breathStatus)
            {
                if (breathIncrement >= BreathSize + 10)
                {
                    breathStatus = false;
                }
                else
                {
                    MoveCentralPoint(pb, trajec);
                    CreateFigure(figureCoordinatesArray);
                    pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
                    breathIncrement += BreathSpeed;
                }
            }
            else if (!breathStatus)
            {
                if (breathIncrement <= 0)
                {
                    breathStatus = true;
                }
                else
                {
                    MoveCentralPoint(pb, trajec);
                    CreateFigure(figureCoordinatesArray);
                    pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
                    breathIncrement -= BreathSpeed;
                }
            }
        }

        public override void MoveWithoutBreath(PictureBox pb, Trajectory trajec)
        {
            MoveCentralPoint(pb, trajec);
            CreateFigure(figureCoordinatesArray);
            pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
        }
    }
}
