using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    /// <summary>
    /// Общий класс Фракталов.
    /// </summary>
    abstract class Fractal
    {
        // Глубина рекурсии.
        public int NumberOfSteps;
        // Длина отрезка.
        public double FractalSize;
        // Массив цветов на разных итерациях.
        public List<Color> Colors = new List<Color>();
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        /// <param name="size">Длина отрезка.</param>
        public Fractal(int numberOfSteps, Color startColor,Color endColor,double size =0)
        {
            NumberOfSteps = numberOfSteps;
            FractalSize = size;
            GetColor(startColor, endColor);
        }

        /// <summary>
        ///  Изображения фрактала.
        /// </summary>
        /// <param name="x"> Координата по оси X.</param>
        /// <param name="y">Координата по оси Y.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step"> Шаг рекурсии.</param>
        /// <param name="step"> Размер стороны.</param>
        public abstract void  PrintFractal(float x, float y, ref Graphics graf, int step = 0, float size = 0);

        public void GetColor(Color StartColor,Color EndColor)
        {
            if (NumberOfSteps == 1)
            {
                Colors.Add(StartColor);
                return;
            }
            int stepA = ((EndColor.A - StartColor.A) / (NumberOfSteps - 1));
            int stepR = ((EndColor.R - StartColor.R) / (NumberOfSteps - 1));
            int stepG = ((EndColor.G - StartColor.G) / (NumberOfSteps - 1));
            int stepB = ((EndColor.B - StartColor.B) / (NumberOfSteps - 1));
            for (int i = 0; i < NumberOfSteps; i++)
            {
                Colors.Add(Color.FromArgb(StartColor.A + (stepA * i),
                                            StartColor.R + (stepR * i),
                                            StartColor.G + (stepG * i),
                                            StartColor.B + (stepB * i)));
            }
        }
        
    }
}
