using System;
using System.Drawing;
using System.Windows.Forms;

namespace KibardinTN_Project
{
	class UserFigure : Figure
	{
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
                figureCoordinatesArray[0] = new Point(squareCenter.X - (FigureSize + 10), squareCenter.Y + (FigureSize + 10));
                figureCoordinatesArray[1] = new Point(squareCenter.X + (FigureSize + 10), squareCenter.Y + (FigureSize + 10));
                figureCoordinatesArray[2] = new Point(squareCenter.X + (FigureSize + 10), squareCenter.Y - (FigureSize + 10));
                figureCoordinatesArray[3] = new Point(squareCenter.X - (FigureSize + 10), squareCenter.Y - (FigureSize + 10));
            }
            if (figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                figureCoordinatesArray = new Point[3];
                triangleCenter = new Point((int)X, (int)Y);
                figureCoordinatesArray[0] = new Point(triangleCenter.X, triangleCenter.Y + (FigureSize + 10));
                figureCoordinatesArray[1] = new Point(triangleCenter.X + (FigureSize + 10), triangleCenter.Y - (FigureSize + 10));
                figureCoordinatesArray[2] = new Point(triangleCenter.X - (FigureSize + 10), triangleCenter.Y - (FigureSize + 10));
                figureCoordinatesArray[2] = new Point(triangleCenter.X - (FigureSize + 10), triangleCenter.Y - (FigureSize + 10));
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
                FigureSize += BreathSize + 1;
                MoveCentralPoint(pb, trajec);
                CreateFigure(figureCoordinatesArray);
                pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
                breathIncrement += 1 + BreathSpeed;

                if (breathIncrement >= 20)
                {
                    breathStatus = false;
                }
            }
            else
            {
                FigureSize -= BreathSize + 1;
                MoveCentralPoint(pb, trajec);
                CreateFigure(figureCoordinatesArray);
                pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
                breathIncrement -= 1 + BreathSpeed;

                if (breathIncrement <= 0)
                {
                    breathStatus = true;
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
