using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KibardinTN_Project
{
    public partial class mainForm : Form
    {
        IntPtr nextClipboardViewer;

        public mainForm()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
            //Добавление наименований в выпадающий список
            comboBoxFigure.Items.AddRange(new string[] { "Квадрат", "Треугольник", "Фигура_Вариант8", "Фигура_Вариант19" });
            //Загрузка параметров из Settings
            LoadSettings();
        }

        /*
         * Блок кода, отвечающий за вывод сообщений об изменении содержимого буфера обмена
         */
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                    m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam,
                        m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        void DisplayClipboardData()
        {
            try
            {
                IDataObject iData = new DataObject();
                iData = Clipboard.GetDataObject();

                if (iData.GetDataPresent(DataFormats.Rtf))
                {
                    richTextBox1.Rtf = "Скопировано: " + (string)iData.GetData(DataFormats.Rtf);
                    richTextBox1.BackColor = Color.Gold;
                }
                else if (iData.GetDataPresent(DataFormats.Text))
                {
                    richTextBox1.Text = "Скопировано: " + (string)iData.GetData(DataFormats.Text);
                    richTextBox1.BackColor = Color.Gold;
                }
                else
                {
                    richTextBox1.Text = "В буфере обмена должен находиться текст";
                    richTextBox1.BackColor = Color.LightCoral;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        /*
         * Переменные
         */
        Trajectory trajectory = new Ellipse(); //Создание объекта траектории, базовое создание траектории без сохранения
        MoveableObject figure = new MyFigure(); //Создание объекта фигуры
        static String figureName = ""; //Имя фигуры, переменная для текстбокса
        StringBuilder wordForCopy = new StringBuilder(); //Строка для скопированного текста
        DateTime localTime = DateTime.Now; //Локальное время для обработчика ошибок
        Dictionary<int, Trajectory> trajectoryList = new Dictionary<int, Trajectory>() //Словарь для траекторий
        {
            {1, new Ellipse() },
            {2, new Epicycloid() },
            {3, new Hypocycloid() }
        };
        int trajectoryKey = 0; //Ключ к траектории
        static double fi1; //Начальное ограничение
        static double fi2; //Конечное ограничение

        //Сохранение настроек
        private void Click_SaveSettings(object sender, EventArgs e)
        {
            Properties.Settings.Default.textBoxText = comboBoxFigure.Text; //Первый текст бокс
            Properties.Settings.Default.textBoxText2 = textBox2.Text; //Второй текст бокс
            Properties.Settings.Default.textBoxText3 = textBox3.Text; //Третий текст бокс
            Properties.Settings.Default.textBoxText4 = textBox4.Text; //Четвёртый текст бокс
            Properties.Settings.Default.textBoxText5 = textBox5.Text; //Пятый текст бокс
            Properties.Settings.Default.trajectoryColor = trajectory.TrajectoryColor; //Цвет траектории
            Properties.Settings.Default.figureColor = figure.FigureColor; //Цвет фигуры
            Properties.Settings.Default.backgroundColor = pictureBox.BackColor; //Цвет фона
            Properties.Settings.Default.figureSize = trackBarFigureSize.Value; //Размер фигуры
            Properties.Settings.Default.figureCenterMovingSpeed = trackBarFigureSpeed.Value; //Скорость движения фигуры
            Properties.Settings.Default.breathSize = trackBarBreathSize.Value; //Значение величины дыхания
            Properties.Settings.Default.breathSpeed = trackBarBreathSpeed.Value; //Значение скорости дыхания
            Properties.Settings.Default.trajectorySize = trackBarTrajectorySize.Value; //Значение размера траектории
            Properties.Settings.Default.timerIsOn = Timer.Enabled; //Включено ли движение фигуры
            Properties.Settings.Default.breathIsOn = figure.IsBreathOn; //Включено ли дыхание фигуры
            Properties.Settings.Default.trajectoryKeyValue = trajectoryKey; //Ключ для создания траектории
            Properties.Settings.Default.angleStartValue = fi1; //Начальный угол траектории
            Properties.Settings.Default.angleLimitValue = fi2; //Конечный угол траектории
            Properties.Settings.Default.Save(); //Сохранение
        }

        //Загрузка сохранённых настроек
        private void LoadSettings()
        {
            //Текстовые ячейки
            comboBoxFigure.Text = Properties.Settings.Default.textBoxText;
            textBox2.Text = Properties.Settings.Default.textBoxText2;
            textBox3.Text = Properties.Settings.Default.textBoxText3;
            textBox4.Text = Properties.Settings.Default.textBoxText4;
            textBox5.Text = Properties.Settings.Default.textBoxText5;
            //Траектория
            trajectoryKey = Properties.Settings.Default.trajectoryKeyValue;
            trajectory = trajectoryList.GetValueOrDefault(trajectoryKey);
            trackBarTrajectorySize.Value = Properties.Settings.Default.trajectorySize;
            fi1 = Properties.Settings.Default.angleStartValue;
            fi2 = Properties.Settings.Default.angleLimitValue;
            //Фигура
            trackBarFigureSize.Value = Properties.Settings.Default.figureSize;
            figure.FigureSize = trackBarTrajectorySize.Value;
            trackBarFigureSpeed.Value = Properties.Settings.Default.figureCenterMovingSpeed;
            figure.CenterMovingSpeed = Properties.Settings.Default.figureCenterMovingSpeed;
            //Дыхание
            trackBarBreathSize.Value = Properties.Settings.Default.breathSize;
            figure.BreathSize = trackBarBreathSize.Value;
            trackBarBreathSpeed.Value = Properties.Settings.Default.breathSpeed;
            figure.BreathSpeed = trackBarBreathSpeed.Value;
            figure.IsBreathOn = Properties.Settings.Default.breathIsOn;
            //Цвета
            trajectory.TrajectoryColor = Properties.Settings.Default.trajectoryColor;
            figure.FigureColor = Properties.Settings.Default.figureColor;
            pictureBox.BackColor = Properties.Settings.Default.backgroundColor;
            //Таймер
            Timer.Enabled = Properties.Settings.Default.timerIsOn;
        }

        //Изменение размера главной формы
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Refresh();
            PictureBox_Resize(sender, e);
        }

        //Отрисовка на PictureBox
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            pictureBox.Height = ClientSize.Height;
            pictureBox.Width = ClientSize.Width;
            trajectory.Draw(pictureBox);
        }

        //Изменение размера PictureBox
        private void PictureBox_Resize(object sender, EventArgs e)
        {
            PictureBox_Paint(sender, null);
        }

        //Изменение размера траектории
        private void TrackBar_TrajectorySize(object sender, EventArgs e)
        {
            trajectory.Scale = trackBarTrajectorySize.Value / (double)(trackBarTrajectorySize.Maximum - trackBarTrajectorySize.Minimum);
            Refresh();
            trajectory.Draw(pictureBox);
        }

        //Тик таймера
        private void Timer_Tick(object sender, EventArgs e)
        {
            Refresh();
            figure.Move(pictureBox, trajectory);
        }

        //Кнопка, отвечающая за включение движения фигуры по траектории
        private void Click_StartMove(object sender, MouseEventArgs e)
        {
            Timer.Enabled = true;
        }

        //Кнопка, отвечающая за остановку движения фигуры
        private void Click_StopMove(object sender, MouseEventArgs e)
        {
            Timer.Enabled = false;
        }

        //Изменение размера фигуры
        private void TrackBar_FigureSize(object sender, EventArgs e)
        {
            figure.FigureSize = trackBarFigureSize.Value;
            Refresh();
        }

        //Изменение скорости движения фигуры по траектории
        private void TrackBar_FigureSpeed(object sender, EventArgs e)
        {
            figure.CenterMovingSpeed = trackBarFigureSpeed.Value;
        }

        //Изменение скорости дыхания фигуры
        private void TrackBar_BreathSpeed(object sender, EventArgs e)
        {
            figure.BreathSpeed = trackBarBreathSpeed.Value;
        }

        //Изменение размера дыхания фигуры
        private void TrackBar_BreathSize(object sender, EventArgs e)
        {
            figure.BreathSize = trackBarBreathSize.Value;
        }

        //Кнопка, отвечающая за начало дыхания фигуры
        private void Click_StartBreath(object sender, EventArgs e)
        {
            figure.IsBreathOn = true;
            Refresh();
        }

        //Кнопка, отвечающая за приостановку дыхания фигуры
        private void Click_StopBreath(object sender, EventArgs e)
        {
            figure.IsBreathOn = false;
            Refresh();
        }

        //Отрисовка траектории в PictureBox после смены цвета
        private void PictureBox_BackColorChanged(object sender, EventArgs e)
        {
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета траектории
        private void Click_ChooseTrajectoryColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за смену цвета фигуры
        private void Click_ChooseFigureColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            figure.FigureColor = chooseColor.Color;
        }

        //Кнопка, отвечающая за смену цвета фона
        private void Click_ChooseBackgroundColor(object sender, EventArgs e)
        {
            chooseColor.ShowDialog();
            pictureBox.BackColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
        }

        //Кнопка, отвечающая за конвертацию figure в string-переменную
        private void Click_EnterFigureName(object sender, EventArgs e)
        {
            try
            {
                figureName = Convert.ToString(comboBoxFigure.Text).ToUpper();

                if (figureName.Equals("КВАДРАТ") || figureName.Equals("ТРЕУГОЛЬНИК") || figureName.Equals("ФИГУРА_ВАРИАНТ19"))
                {
                    figure = new UserFigure(figureName);
                    figure.Move(pictureBox, trajectory);
                    figure.FigureColor = chooseColor.Color;
                    richTextBox1.Text = localTime + "\nФигура изменена!";
                    richTextBox1.BackColor = Color.GreenYellow;
                }
                else if (figureName.Equals("ФИГУРА_ВАРИАНТ8"))
                {
                    figure = new MyFigure();
                    figure.Move(pictureBox, trajectory);
                    figure.FigureColor = chooseColor.Color;
                    richTextBox1.Text = localTime + "\nФигура изменена!";
                    richTextBox1.BackColor = Color.GreenYellow;
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
            catch (ArgumentException)
            {
                richTextBox1.Text = localTime + "\nВыбранной фигуры нет в списке доступных.";
                richTextBox1.BackColor = Color.LightCoral;
            }
        }

        //Кнопка, отвечающая за конвертацию trajectory в string-переменную
        private void Click_EnterTrajectoryName(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                if ((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text))
                    && (!String.IsNullOrWhiteSpace(textBox4.Text)) && (!String.IsNullOrWhiteSpace(textBox5.Text)))
                {
                    fi1 = Double.Parse(textBox2.Text) * Math.PI / Double.Parse(textBox3.Text);
                    fi2 = Double.Parse(textBox4.Text) * Math.PI / Double.Parse(textBox5.Text);

                    trajectory = new UserTrajectory(fi1, fi2);

                    trajectory.TrajectoryColor = chooseColor.Color;
                    trajectory.Draw(pictureBox);
                    Refresh();
                    richTextBox1.Text = localTime + "\nУспешно!";
                    richTextBox1.BackColor = Color.GreenYellow;
                }
                else if (!int.TryParse(textBox2.Text, out i) || !int.TryParse(textBox3.Text, out i)
                    || !int.TryParse(textBox4.Text, out i) || !int.TryParse(textBox2.Text, out i))
                {
                    throw new ArgumentException("");
                }
            }
            catch
            {
                richTextBox1.Text = localTime + "\nДолжны быть введены только числа.";
                richTextBox1.BackColor = Color.LightCoral;
            }
        }

        //Кнопка, отвечающая за отрисовку изначальной траектории
        private void Click_DrawTrajectoryVariant8(object sender, EventArgs e)
        {
            trajectory = new Ellipse();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            trajectoryKey = 1;
            Refresh();
            richTextBox1.Text = localTime + "\nТраектория изменена!";
            richTextBox1.BackColor = Color.GreenYellow;
        }

        //Кнопка, отвечающая за отрисовку траектории в виде половины эпициклоида
        private void Click_DrawCloud(object sender, EventArgs e)
        {
            trajectory = new Epicycloid();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            trajectoryKey = 2;
            Refresh();
            richTextBox1.Text = localTime + "\nТраектория изменена!";
            richTextBox1.BackColor = Color.GreenYellow;
        }

        //Кнопка, отвечающая за отрисовку траектории в виде гипоциклоиды
        private void Click_DrawHypocycloid(object sender, EventArgs e)
        {
            trajectory = new Hypocycloid();
            trajectory.TrajectoryColor = chooseColor.Color;
            trajectory.Draw(pictureBox);
            trajectoryKey = 3;
            Refresh();
            richTextBox1.Text = localTime + "\nТраектория изменена!";
            richTextBox1.BackColor = Color.GreenYellow;
        }

        //Кнопка, отвечающая за копирование текста из текстовых ячеек
        private void Click_CopyText(object sender, EventArgs e)
        {
            Clipboard.Clear();
            //1-ая текстовая ячейка
            if (!String.IsNullOrWhiteSpace(comboBoxFigure.Text))
            {
                wordForCopy.Append(comboBoxFigure.Text).Append(',');
            }
            else
            {
                wordForCopy.Append(" ,");
            }
            //2-ая текстовая ячейка
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                wordForCopy.Append(textBox2.Text).Append(',');
            }
            else
            {
                wordForCopy.Append(" ,");
            }
            //3-ая текстовая ячейка
            if (!String.IsNullOrWhiteSpace(textBox3.Text))
            {
                wordForCopy.Append(textBox3.Text).Append(',');
            }
            else
            {
                wordForCopy.Append(" ,");
            }

            if (!String.IsNullOrWhiteSpace(textBox4.Text))
            {
                wordForCopy.Append(textBox4.Text).Append(',');
            }
            else
            {
                wordForCopy.Append(" ,");
            }

            if (!String.IsNullOrWhiteSpace(textBox5.Text))
            {
                wordForCopy.Append(textBox5.Text);
            }
            else
            {
                wordForCopy.Append(" ,");
            }

            Clipboard.SetDataObject(wordForCopy.ToString());
            wordForCopy.Clear();
        }

        //Кнопка, отвечающая за подстановку текста в текстовые ячейки
        private void Click_PasteText(object sender, EventArgs e)
        {
            String[] pasteTextArray = new String[5];
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(typeof(String)) && Clipboard.GetDataObject() != null)
            {
                pasteTextArray = Clipboard.GetText().Split(',');
            }

            comboBoxFigure.Text = pasteTextArray[0];
            textBox2.Text = pasteTextArray[1];
            textBox3.Text = pasteTextArray[2];
            textBox4.Text = pasteTextArray[3];
            textBox5.Text = pasteTextArray[4];
        }
    }
}
