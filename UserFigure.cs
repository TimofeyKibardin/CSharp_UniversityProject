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
        private Point figureCenter;

        protected override Point[] CreateFigure(Point[] coordinatesArray)
        {
            if (figureName.Equals("КВАДРАТ"))
            {
                figureCoordinatesArray = new Point[4];
                figureCenter = new Point((int)X, (int)Y);
                figureCoordinatesArray[0] = new Point(figureCenter.X - (FigureSize + 20 + breathIncrement), figureCenter.Y + (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[1] = new Point(figureCenter.X + (FigureSize + 20 + breathIncrement), figureCenter.Y + (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[2] = new Point(figureCenter.X + (FigureSize + 20 + breathIncrement), figureCenter.Y - (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[3] = new Point(figureCenter.X - (FigureSize + 20 + breathIncrement), figureCenter.Y - (FigureSize + 20 + breathIncrement));
            }
            if (figureName.Equals("ТРЕУГОЛЬНИК"))
            {
                figureCoordinatesArray = new Point[3];
                figureCenter = new Point((int)X, (int)Y);
                figureCoordinatesArray[0] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[1] = new Point(figureCenter.X + (FigureSize + 20 + breathIncrement), figureCenter.Y - (FigureSize + 20 + breathIncrement));
                figureCoordinatesArray[2] = new Point(figureCenter.X - (FigureSize + 20 + breathIncrement), figureCenter.Y - (FigureSize + 20 + breathIncrement));
            }
            if (figureName.Equals("ФИГУРА_ВАРИАНТ19"))
            {
                figureCoordinatesArray = new Point[21];
                figureCenter = new Point((int)X, (int)Y);

                //Верхний прямоугольник
                figureCoordinatesArray[0] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[1] = new Point(figureCenter.X - (FigureSize + 15 + breathIncrement), figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[2] = new Point(figureCenter.X - (FigureSize + 15 + breathIncrement), figureCenter.Y + (FigureSize + 15 + breathIncrement));
                figureCoordinatesArray[3] = new Point(figureCenter.X + (FigureSize + 15 + breathIncrement), figureCenter.Y + (FigureSize + 15 + breathIncrement));
                figureCoordinatesArray[4] = new Point(figureCenter.X + (FigureSize + 15 + breathIncrement), figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[5] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 5 + breathIncrement));
                //Левый прямоугольник
                figureCoordinatesArray[6] = new Point(figureCenter.X, figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[7] = new Point(figureCenter.X - (FigureSize + 30 + breathIncrement), figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[8] = new Point(figureCenter.X - (FigureSize + 30 + breathIncrement), figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[9] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[10] = new Point(figureCenter.X, figureCenter.Y - (FigureSize + 5 + breathIncrement));
                //Правый прямоугольник
                figureCoordinatesArray[11] = new Point(figureCenter.X + (FigureSize + 30 + breathIncrement), figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[12] = new Point(figureCenter.X + (FigureSize + 30 + breathIncrement), figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[13] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[14] = new Point(figureCenter.X, figureCenter.Y - (FigureSize + 5 + breathIncrement));
                //Нижний прямоугольник
                figureCoordinatesArray[15] = new Point(figureCenter.X - (FigureSize + 15 + breathIncrement), figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[16] = new Point(figureCenter.X - (FigureSize + 15 + breathIncrement), figureCenter.Y - (FigureSize + 15 + breathIncrement));
                figureCoordinatesArray[17] = new Point(figureCenter.X + (FigureSize + 15 + breathIncrement), figureCenter.Y - (FigureSize + 15 + breathIncrement));
                figureCoordinatesArray[18] = new Point(figureCenter.X + (FigureSize + 15 + breathIncrement), figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[19] = new Point(figureCenter.X, figureCenter.Y - (FigureSize + 5 + breathIncrement));
                figureCoordinatesArray[20] = new Point(figureCenter.X, figureCenter.Y + (FigureSize + 5 + breathIncrement));
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
