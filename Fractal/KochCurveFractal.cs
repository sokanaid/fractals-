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
    class KochCurveFractal : Fractal
    {
        // Толщина пера.
        const int PenWidht = 3;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        public KochCurveFractal(int numberOfSteps, Color startColor, Color endColor)
            : base(numberOfSteps, startColor, endColor)
        {
        }

        /// <summary>
        /// Изобаржение фрактала (расчет координат и переход к рекурсивному изображению).
        /// </summary>
        /// <param name="x">Координата по оси X левого нижнего угла треугольника.</param>
        /// <param name="y">Координата по оси У центра треугольника.</param>
        /// <param name="size">размер стороны треугольника</param>
        /// <param name="graf">Графическай элемент.</param>
        /// <param name="step">Шаг рекурсии.</param>
        public override void PrintFractal(float x, float y, ref Graphics graf, int step = 0, float size = 0)
        {

            Pen pen = new Pen(Colors[0]);

            graf.DrawLine(pen, new PointF(x, y), new PointF(x + size, y));

            step++;
            PrintFractalRec(new PointF(x, y), new PointF(x + size, y), ref graf, step, size / 3);

        }

        /// <summary>
        /// Рекурсивное изображение фрактала.
        /// </summary>
        /// <param name="points"> Вершины треугольника.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step">Шаг рекурсии.</param>
        /// <param name="pointsStep">Номер итерации на котором была добавлена точка.</param>
        private void PrintFractalRec(PointF startPoint, PointF endPoint, ref Graphics graf, int step, float size)
        {
            if (step >= NumberOfSteps || size < 1)
            {
                //MessageBox.Show(step++.ToString());
                return;
            }
           
            
            PointF point1 = GetPoint13(startPoint, endPoint);
            PointF point2 = GetMidlePoint(startPoint, endPoint);
            PointF point3 = GetPoint13(endPoint,startPoint);
            Pen pen = new Pen(Brushes.White, PenWidht);
            // Стирание предыдущей линии.
            graf.DrawLine(pen,point1, point3);
            pen = new Pen(Colors[step], PenWidht);
            // Изображение текущего шага.
            graf.DrawLine(pen, point1, point2);
            graf.DrawLine(pen, point2, point3);

            step++;
            size /= 3;

            PrintFractalRec(startPoint, point1, ref graf, step, size);
            PrintFractalRec(point1, point2, ref graf, step, size);
            PrintFractalRec(point2, point3, ref graf, step, size);
            PrintFractalRec(point3, endPoint, ref graf, step, size);


        }

        /// <summary>
        /// Вычисление новой средней точки.
        /// </summary>
        /// <param name="A">Начало отрезка.</param>
        /// <param name="B">Конец отрезка.</param>
        /// <returns>Новая точка.</returns>
        private PointF GetMidlePoint(PointF A, PointF B)
        {

            PointF newPoint = new PointF();
            newPoint.X = (float)((A.X + B.X) / 2 + (-A.Y + B.Y) / (2 * Math.Sqrt(3)));
            newPoint.Y = (float)((A.Y + B.Y) / 2 + (-B.X + A.X) / (2 * Math.Sqrt(3)));
            return newPoint;
        }

        /// <summary>
        /// Вычисление новой точки на 1/3 отрезка.
        /// </summary>
        /// <param name="A">Начало отрезка.</param>
        /// <param name="B">Конец отрезка.</param>
        /// <returns>Новая точка.</returns>
        private PointF GetPoint13(PointF A, PointF B)
        {

            PointF newPoint = new PointF();
            newPoint.X = (float)((2 * A.X + B.X) / 3);
            newPoint.Y = (float)((2 * A.Y + B.Y) / 3);
            return newPoint;
        }

    }
}
