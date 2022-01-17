using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KibardinTN_Project
{
    
    public class MyFigure : Figure
	{
		public MyFigure()
		{
			figureCoordinatesArray = new Point[20];
        }

        private Point rhombusCenter; //Центр ромба

        /*
         * Метод, отвечающий за создание фигуры
         */
        protected override Point[] CreateFigure(Point[] coordinatesArray)
        {
            //Нижний ромб
            rhombusCenter = new Point((int)X, (int)(Y - (2 * 10 + breathIncrement + FigureSize)));
            figureCoordinatesArray[0] = new Point(rhombusCenter.X, rhombusCenter.Y + (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[1] = new Point(rhombusCenter.X - (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[2] = new Point(rhombusCenter.X, rhombusCenter.Y - (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[3] = new Point(rhombusCenter.X + (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            //Возврат к точке
            figureCoordinatesArray[4] = new Point(rhombusCenter.X, rhombusCenter.Y + (10 + breathIncrement + FigureSize));

            //Левый ромб
            rhombusCenter = new Point((int)(X - (2 * 10 + breathIncrement + FigureSize)), (int)Y);
            figureCoordinatesArray[5] = new Point(rhombusCenter.X + (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[6] = new Point(rhombusCenter.X, rhombusCenter.Y + (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[7] = new Point(rhombusCenter.X - (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[8] = new Point(rhombusCenter.X, rhombusCenter.Y - (10 + breathIncrement + FigureSize));
            //Возврат к точке
            figureCoordinatesArray[9] = new Point(rhombusCenter.X + (10 + breathIncrement + FigureSize), rhombusCenter.Y);

            //Верхний ромб
            rhombusCenter = new Point((int)X, (int)(Y + (2 * 10 + breathIncrement + FigureSize)));
            figureCoordinatesArray[10] = new Point(rhombusCenter.X, rhombusCenter.Y - (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[11] = new Point(rhombusCenter.X + (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[12] = new Point(rhombusCenter.X, rhombusCenter.Y + (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[13] = new Point(rhombusCenter.X - (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            //Возврат к точке
            figureCoordinatesArray[14] = new Point(rhombusCenter.X, rhombusCenter.Y - (10 + breathIncrement + FigureSize));

            //Правый ромб
            rhombusCenter = new Point((int)(X + (2 * 10 + breathIncrement + FigureSize)), (int)Y);
            figureCoordinatesArray[15] = new Point(rhombusCenter.X - (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[16] = new Point(rhombusCenter.X, rhombusCenter.Y - (10 + breathIncrement + FigureSize));
            figureCoordinatesArray[17] = new Point(rhombusCenter.X + (10 + breathIncrement + FigureSize), rhombusCenter.Y);
            figureCoordinatesArray[18] = new Point(rhombusCenter.X, rhombusCenter.Y + (10 + breathIncrement + FigureSize));
            //Возврат к точке
            figureCoordinatesArray[19] = new Point(rhombusCenter.X - (10 + breathIncrement + FigureSize), rhombusCenter.Y);

            return figureCoordinatesArray;
        }

        /*
		 * Метод, отвечающий за движение объекта по траектории
		 */
        public override void Move(PictureBox pb, Trajectory trajec)
        {
            if (IsBreathOn) MoveWithBreath(pb, trajec);
            else MoveWithoutBreath(pb, trajec);
        }

        /*
         * Метод, отвечающий за движение фигуры с ВЫКЛЮЧЕННЫМ дыханием
         */
        public override void MoveWithoutBreath(PictureBox pb, Trajectory trajec)
        {
            MoveCentralPoint(pb, trajec);
            CreateFigure(figureCoordinatesArray);
            pb.CreateGraphics().DrawPolygon(new Pen(FigureColor, 3f), figureCoordinatesArray);
        }

        /*
         * Метод, отвечающий за движение фигуры с ВКЛЮЧЕННЫМ дыханием
         */
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

        public override void Draw(PictureBox pb)
    {
        throw new NotImplementedException();
    }
}
}
