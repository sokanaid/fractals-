using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Fractal
{
    public partial class MainWindow : System.Windows.Forms.Form
    {

        public char Sep = Convert.ToChar(NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
        /*public Color SrartColor= Color.Blue,
            EndColor= Color.Red;*/
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Загрузка формы.
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Задание минимальныого и максимального размера формы.    
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width / 2,
                Screen.PrimaryScreen.WorkingArea.Height / 2);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,
                Screen.PrimaryScreen.WorkingArea.Height);
            PictureBoxColor1.BackColor = Color.Yellow;
            PictureBoxColor2.BackColor = Color.Blue;
        }

        

        /// <summary>
        /// Изображение ковра серпинского.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Bitmap PrintCarpet()
        {

            // Создание объеката картинки.
            Bitmap bmp = new Bitmap(FractalPicture.Width, FractalPicture.Height);

            Graphics graf = Graphics.FromImage(bmp);
            graf.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
            SierpinskisCarpetFractal fractal =
                 new SierpinskisCarpetFractal(TrackBarRecSteps.Value,PictureBoxColor1.BackColor,PictureBoxColor2.BackColor);
            fractal.PrintFractal(0, 0, ref graf, 0, Math.Min(bmp.Width, bmp.Height));
            ButtonSave.Visible = true;
            return bmp;
        }

        /// <summary>
        /// Изображение ковра фрактального дерева.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Bitmap PrintTree()
        {
            // Создание объеката картинки.
            Bitmap bmp = new Bitmap(FractalPicture.Width, FractalPicture.Height);
            double len,
                angle1,
                angle2;
            if (!double.TryParse(TextBoxAngle1.Text, out angle1) || angle1 > 90 || angle1 <= 0 ||
                !double.TryParse(TextBoxAngle2.Text, out angle2) || angle2 > 90 || angle2 <= 0)
            {
                MessageBox.Show($"Введите корректные значения уголов : вещественные числа 0<n<=90, " +
                    $"с разделителем целой и дробной части ''{Sep}'' "
                    , "Некорректные параметры", MessageBoxButtons.OK);
                return bmp;
            }
            if (!double.TryParse(TextBoxTrees.Text, out len) || len >= 3 || len < 1.5)
            {
                MessageBox.Show($"Введите корректное значение отношения отрезков : вещественное число 1.5<=n<3, с разделителем целой и дробной части ''{Sep}'' "
                    , "Некорректные параметры", MessageBoxButtons.OK);
                return bmp;
            }
            angle1 = angle1 * Math.PI / 90;
            angle2 = angle2 * Math.PI / 90;
            Graphics graf = Graphics.FromImage(bmp);
            graf.FillRectangle(Brushes.White,0,0,bmp.Width, bmp.Height);
            FractalTree fractal = new FractalTree(TrackBarRecSteps.Value, len, angle1, angle2,
                PictureBoxColor1.BackColor, PictureBoxColor2.BackColor);
            fractal.PrintFractal((float)(bmp.Width / 2), bmp.Height - 60, ref graf, 0, (float)(bmp.Height / 4));
            ButtonSave.Visible = true;
            return bmp;
        }

        /// <summary>
        /// Изображение ковра кривой Коха.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Bitmap PrintKoch()
        {
            // Создание объеката картинки.
            Bitmap bmp = new Bitmap(FractalPicture.Width, FractalPicture.Height);

            Graphics graf = Graphics.FromImage(bmp);
            graf.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

            KochCurveFractal fractal = new KochCurveFractal(TrackBarRecSteps.Value, PictureBoxColor1.BackColor, PictureBoxColor2.BackColor);
            fractal.PrintFractal(0, bmp.Height / 2, ref graf, 0, bmp.Width - 20);
            ButtonSave.Visible = true;
            return bmp;
        }

        /// <summary>
        /// Изображение ковра множества Кантора.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Bitmap PrintCantor()
        {
            // Создание объеката картинки.
            Bitmap bmp = new Bitmap(FractalPicture.Width, FractalPicture.Height);
            double len;
            if (!double.TryParse(TextBoxTrees.Text, out len) || len > 50 || len < 1)
            {
                MessageBox.Show($"Введите корректное значение отношения отрезков : вещественное число 1<=n<=50, с разделителем целой и дробной части ''{Sep}'' "
                    , "Некорректные параметры", MessageBoxButtons.OK);
                return bmp;
            }
            Graphics graf = Graphics.FromImage(bmp);
            graf.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

            CantorsSetFractal fractal = new CantorsSetFractal(TrackBarRecSteps.Value, (float)len, Math.Min(bmp.Width, bmp.Height) - 10
                , PictureBoxColor1.BackColor, PictureBoxColor2.BackColor);
            fractal.PrintFractal(0, (float)(bmp.Height / len / 2), ref graf, 0, Math.Min(bmp.Width, bmp.Height) - 20);
            ButtonSave.Visible = true;
            return bmp;
        }

        /// <summary>
        /// Изображение ковра треугольника Серпинского.
        /// </summary>
        /// <returns>Изображение.</returns>
        public Bitmap PrintTriagle()
        {
            // Создание объеката картинки.
            Bitmap bmp = new Bitmap(FractalPicture.Width, FractalPicture.Height);
            Graphics graf = Graphics.FromImage(bmp);
            graf.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);

            SerpinskisTriangle fractal = new SerpinskisTriangle(TrackBarRecSteps.Value, PictureBoxColor1.BackColor, PictureBoxColor2.BackColor);
            fractal.PrintFractal(10, bmp.Height - 10, ref graf, 0, Math.Min(bmp.Width, bmp.Height) - 10);
            ButtonSave.Visible = true;
            return bmp;
        }

        /// <summary>
        /// Выбор характеристик фрактала для изображения.
        /// </summary>
        private void ButtonPrintFractal_Click(object sender, EventArgs e)
        {

            // Cкрываем элементы.
            ChoseFractalVisiable(false);
            // Обновление трекбара.
            TrackBarRecSteps.Value = 1;
            RecStepsLable.Text = "1";
            // Выбор дополнительных характеристик.
            if (RadioButtonCarpet.Checked)
            {
                TrackBarRecSteps.Maximum = 7;
            }
            else if (RadioButtonTree.Checked)
            {
                TrackBarRecSteps.Maximum = 16;
                TextBoxAngle1.Visible = true;
                TextBoxAngle2.Visible = true;
                LabelTrees.Text = "Выбрете отношение отрезков на соседних итерациях (1,5<=n<3)";
                TextBoxTrees.Visible = true;
                LabelAngles.Visible = true;
                LabelTrees.Visible = true;

            }
            else if (RadioButtonKoch.Checked)
            {
                TrackBarRecSteps.Maximum = 7;
            }
            else if (radioButtonSet.Checked)
            {
                TrackBarRecSteps.Maximum = 5;

                LabelTrees.Text = $"Выберите расстояние между отрезками на соседних итерациях (1<=n<=50)";
                TextBoxTrees.Visible = true;
                TextBoxTrees.Visible = true;
            }
            else
            {
                TrackBarRecSteps.Maximum = 11;
            }

            BackButton.Visible = true;
            RecStepsLable.Visible = true;
            PrintFractalButton.Visible = true;
            TrackBarRecSteps.Visible = true;
            LabelChooseRecSteps.Visible = true;
            ButtonColor1.Visible = true;
            ButtonColor2.Visible = true;
            PictureBoxColor1.Visible = true;
            PictureBoxColor2.Visible = true;
        }

        /// <summary>
        /// Упревление компонентами с главного меню.
        /// </summary>
        /// <param name="isVisiable">Скрыть или отобразить меню..</param>
        public void ChoseFractalVisiable(bool isVisiable)
        {
            LabelChooseFractal.Visible = isVisiable;
            RadioButtonTriagle.Visible = isVisiable;
            radioButtonSet.Visible = isVisiable;
            RadioButtonKoch.Visible = isVisiable;
            RadioButtonCarpet.Visible = isVisiable;
            RadioButtonTree.Visible = isVisiable;
            ButtonChooseFractal.Visible = isVisiable;
        }
        /// <summary>
        /// Изменение видимости всех элементов.
        /// </summary>
        /// <param name="isVisiable">Сокрыти или отобразить.</param>
        public void AllComponentsVisible(bool isVisiable)
        {
            ChoseFractalVisiable(isVisiable);
            BackButton.Visible = isVisiable;
            FractalPicture.Visible = isVisiable;
            RecStepsLable.Visible = isVisiable;
            PrintFractalButton.Visible = isVisiable;
            TrackBarRecSteps.Visible = isVisiable;
            LabelChooseRecSteps.Visible = isVisiable;
            TextBoxAngle1.Visible = isVisiable;
            TextBoxAngle2.Visible = isVisiable;
            TextBoxTrees.Visible = isVisiable;
            LabelAngles.Visible = isVisiable;
            LabelTrees.Visible = isVisiable;
            ButtonSave.Visible = isVisiable;
            ButtonColor1.Visible = isVisiable;
            ButtonColor2.Visible = isVisiable;
            PictureBoxColor1.Visible = isVisiable;
            PictureBoxColor2.Visible = isVisiable;
        }
       

        /// <summary>
        /// Возвращение в главное меню.
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Сокрытие всех элементов.
            AllComponentsVisible(false);
            // Отображение меню.
            ChoseFractalVisiable(true);
        }


        /// <summary>
        /// Изменение значения трекбара.
        /// </summary>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RecStepsLable.Text = TrackBarRecSteps.Value.ToString();
        }


        /// <summary>
        /// Изобрадение фрактала.
        /// </summary>
        private void PrintFractalButton_Click(object sender, EventArgs e)
        {
            // Создание объеката картинки.
            Bitmap bmp;
            if (RadioButtonCarpet.Checked)
            {
                bmp = PrintCarpet();
            }
            else if (RadioButtonTree.Checked)
            {
                bmp = PrintTree();
            }
            else if (RadioButtonKoch.Checked)
            {
                bmp = PrintKoch();
            }
            else if (radioButtonSet.Checked)
            {
                bmp = PrintCantor();
            }
            else
            {
                bmp = PrintTriagle();
            }

            // Присвоение картинки PictureBox. 
            FractalPicture.Image = bmp;
            FractalPicture.Visible = true;
        }

        
        /// <summary>
        /// Сохранение изображения.
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FractalPicture.Image != null)
                {
                    //Graphics graf = Graphics.FromImage(FractalPicture.Image);
                    SaveFileDialog savedialog = new SaveFileDialog();
                    savedialog.Title = "Сохранить картинку как...";
                    
                    savedialog.OverwritePrompt = true;
                    savedialog.CheckPathExists = true;
                    savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

                    savedialog.ShowHelp = true;
                    if (savedialog.ShowDialog() == DialogResult.OK) 
                    {
                        try
                        {
                            FractalPicture.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        catch
                        {
                            MessageBox.Show($"Неудалось сохранить изображение"
                     , "Ошибка при сохранении", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Неудалось сохранить изображение"
                     , "Ошибка при сохранении", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Выбор начального цвета.
        /// </summary>
        private void buttonColor1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = PictureBoxColor1.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)

                PictureBoxColor1.BackColor = colorDialog.Color;
        }

        /// <summary>
        /// Выбор конечного цвета.
        /// </summary>
        private void ButtonColor2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowHelp = true;
            colorDialog.Color = PictureBoxColor1.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)

                PictureBoxColor2.BackColor = colorDialog.Color;
        }

       

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            FractalPicture.Width = this.Width / 2;
            FractalPicture.Height = this.Height;
            
        }

        private void FractalPicture_SizeChanged(object sender, EventArgs e)
        {
            if (ButtonSave.Visible)
            {
                PrintTree();
            }
        }
    }
    
}
