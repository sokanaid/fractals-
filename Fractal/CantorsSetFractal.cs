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
    /// Фрактал множество Кантора.
    /// </summary>
    class CantorsSetFractal : Fractal
    {
        // Ширина пера.
        const int PenWidht = 10;
        // Максимальная координата.
        int MaxXOrY;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        /// <param name="size">Расстояние между линиями, орисованными на разных итерациях.</param>
        /// <param name="size">Максимальная координата.</param>
        public CantorsSetFractal(int numberOfSteps, double size,int maxXOrY, Color startColor, Color endColor)
            : base(numberOfSteps, startColor, endColor, size)
        {
            MaxXOrY=maxXOrY;
            FractalSize += PenWidht;
        }

        /// <summary>
        ///  Изображения фрактала.
        /// </summary>
        /// <param name="x"> Координата по оси X начала линии.</param>
        /// <param name="y">Координата по оси Y начала линии.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step"> Шаг рекурсии.</param>
        /// <param name="step"> Длина линии.</param>
        public override void PrintFractal(float x, float y, ref Graphics graf, int step = 0, float size = 0)
        {
            if(x+size>MaxXOrY || y+PenWidht > MaxXOrY || step>=NumberOfSteps || size<1)
            {
                return;
            }
            Pen pen = new Pen(Colors[step], PenWidht);
            graf.DrawLine(pen, x, y, x + size, y);

            step++;
            PrintFractal(x, (float)(y+ FractalSize), ref graf, step, size / 3);
            PrintFractal(x+size/3*2, (float)(y + FractalSize), ref graf, step, size / 3);
        }

    }
}
