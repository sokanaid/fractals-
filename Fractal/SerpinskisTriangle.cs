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
    /// Фрактал треугольник Серпинского.
    /// </summary>
    
    class SerpinskisTriangle : Fractal
    {
        // Толщина пера.
        const int PenWidht = 3;

        const float eps = (float)1;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        public SerpinskisTriangle(int numberOfSteps, Color startColor, Color endColor) 
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
            List<PointF> points = new List<PointF>() { new PointF(x, y), new PointF(x + size, y),
                new PointF(x + (float)size / 2,(float)y- (float)(Math.Sqrt(size*size - (double)size*size/4)))};
            Pen pen = new Pen(Colors[step], PenWidht);
            graf.DrawPolygon(pen, points.ToArray());
            step++;
            PrintFractalRec(points, ref graf, step);
        }

        /// <summary>
        /// Рекурсивное изображение фрактала.
        /// </summary>
        /// <param name="points"> Вершины треугольника.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step">Шаг рекурсии.</param>
        private void PrintFractalRec(List<PointF> points, ref Graphics graf, int step)
        {
            // Проверка на глубину рекурсии и количество пикселей.
            if(step>=NumberOfSteps || NotTriangle(points))
            {
                //MessageBox.Show(step++.ToString());
                return;
            }
            Pen pen = new Pen(Colors[step], PenWidht);

            // Массив из середин сторон.
            List<PointF> nextPoints = new List<PointF>() {GetMidlPoint(points[0], points[1]), GetMidlPoint(points[1], points[2]),
                GetMidlPoint(points[2], points[0])};

            // Изображение средних линий.
            for(int i=0; i<3; i++)
            {
                for(int j=i+1; j<3; j++)
                {
                    graf.DrawLine(pen, nextPoints[i], nextPoints[j]);
                }
            }

            step++;
            // Переход на следущий шаг рекурсии.
            PrintFractalRec(new List<PointF>() { points[0], nextPoints[0], nextPoints[2] }, ref graf, step);
            PrintFractalRec(new List<PointF>() { nextPoints[2], nextPoints[1], points[2] }, ref graf, step);
            PrintFractalRec(new List<PointF>() {nextPoints[0], points[1], nextPoints[1] }, ref graf, step);
        }

        /// <summary>
        /// Проверка на совпадение точек.
        /// </summary>
        /// <param name="points"> Вершины треугольника.</param>
        /// <returns>Возвращает ложь, если точки не совпадают.</returns>
        private bool NotTriangle(List<PointF> points)
        {

            for(int i=0; i<3; i++)
            {
                for(int j=i+1; j<3; j++)
                {
                    if (Math.Abs((points[i].X - points[j].X)* (points[i].X - points[j].X)
                        + (points[i].Y - points[j].Y)* (points[i].Y - points[j].Y)) < eps)
                    {
                        return true ;
                    }
                }
            }
            return false;
        }

        /// <summary>
        ///  Получение средней точки.
        /// </summary>
        /// <param name="firstPoint">Первый конец отрезка.</param>
        /// <param name="secondPoint">Второй конец отрезка.</param>
        /// <returns>Средняя точка.</returns>
        private PointF GetMidlPoint(PointF firstPoint, PointF secondPoint)
        {
            return new PointF((firstPoint.X + secondPoint.X) / 2, (firstPoint.Y + secondPoint.Y) / 2);
        }
    }

}
