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
    /// Фрактал ковер Серпинского.
    /// </summary>
    class SierpinskisCarpetFractal : Fractal

    {


        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        public SierpinskisCarpetFractal(int numberOfSteps, Color startColor, Color endColor)
            : base(numberOfSteps, startColor, endColor)
        {
        }

        /// <summary>
        ///  Изображения фрактала.
        /// </summary>
        /// <param name="x"> Координата по оси X.</param>
        /// <param name="y"> Координата по оси Y.</param>
        /// <param name="size"> Сторона квадрата.</param>
        public override void PrintFractal(float x, float y, ref Graphics graf, int step = 0, float size = 0)
        {
            SolidBrush brush;

            // Изображение первоначального квадрата.
            if (step == 0)
            {
                brush = new SolidBrush(Colors[step]);
                graf.FillRectangle(brush, x, y, size, size);
                size /= 3;
                x += size;
                y += size;
                step++;
            }

            // Праверка на глубину и колличество пикселей.
            if (step >= NumberOfSteps || size < 1)
            {
                //MessageBox.Show(step++.ToString());
                return;
            }
            brush = new SolidBrush(Colors[step]);

            // Изображение текущего квадрата.
            graf.FillRectangle(brush, x, y, size, size);

            // Массив смещений по координате.
            List<float> delta = new List<float>() { size / 3, -2 * size / 3, size + size / 3 };

            size /= 3;

            // Переход на следущий шаг рекурии.
            foreach (int nextX in delta)
            {
                foreach (int nextY in delta)
                {
                    if (Math.Abs(nextX - size) < 1 && Math.Abs(nextY - size) < 1)
                    {
                        continue;
                    }
                    PrintFractal(x + nextX, y + nextY, ref graf, step + 1, size);
                }
            }
        }
    }
}
