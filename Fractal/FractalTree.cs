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
    /// Обдуваемое ветром фрактальное дерево.
    /// </summary>
    class FractalTree : Fractal
    {
        // Углы наклона ветвей.
        double Angle1,
             Angle2;
        // Толщина пера.
        int PenWigth = 3;
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numberOfSteps">Глубина рекурсии.</param>
        /// <param name="size">Отношение отрезков на соседних итерациях.</param>
        /// <param name="angle1">Угол наклона первой ветви.</param>
        /// <param name="angle2">Угол наклона второй ветви.</param>
        public FractalTree(int numberOfSteps, double size, double angle1, double angle2, Color startColor, Color endColor)
            : base(numberOfSteps, startColor, endColor, size)
        {
            Angle1 = angle1;
            Angle2 = angle2;
        }

        /// <summary>
        ///  Изображения фрактала (изображение ствола и вызов рекурсивного изображения дерева).
        /// </summary>
        /// <param name="x"> Координата по оси X начала отрезка.</param>
        /// <param name="y">Координата по оси Y начала отрезка.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step"> Шаг рекурсии.</param>
        /// <param name="size"> Размер отрезка.</param>
        public override void PrintFractal(float x, float y, ref Graphics graf, int step = 0, float size = 0)
        {
            Pen pen = new Pen(Colors[step], PenWigth);

            graf.DrawLine(pen, x, y, x, y - size);


            PrintFractalRec(new PointF(x, y - size), size / (float)FractalSize, step + 1, Math.PI/2,ref graf);


        }

        /// <summary>
        /// Рекурсивное изображение дерева.
        /// </summary>
        /// <param name="startPoint">Точка начала ветвей.</param>
        /// <param name="size"> Размер отрезка.</param>
        /// <param name="graf">Графический элемент.</param>
        /// <param name="step"> Шаг рекурсии.</param>
        /// <param name="angle"> Текущий угол наклона.</param>
        private void PrintFractalRec(PointF startPoint, float size, int step,double angle, ref Graphics graf)
        {
            // Провека на глубину рекурсии и колличество пикселей.
            if (step >= NumberOfSteps) //|| size < 1)
            {
                return;
            }
            Pen pen = new Pen(Colors[step], PenWigth);
            // Определение точек концов отрезков.
            PointF nextPoint1 = GetPoint(startPoint, size, angle - Angle1),
                nextPoint2 = GetPoint(startPoint, size, angle + Angle2);
            // Изображение отрезков.
            graf.DrawLine(pen, startPoint, nextPoint1);
            graf.DrawLine(pen, startPoint, nextPoint2);
            // Переход на следущую итерацию.
            step++;
            size /= (float)FractalSize;
            PrintFractalRec(nextPoint1, size, step,angle-Angle1, ref graf);
            PrintFractalRec(nextPoint2, size, step,angle+Angle2, ref graf);

        }

        /// <summary>
        /// Вычисление конечной точки отрезка.
        /// </summary>
        /// <param name="startpoint">Начальная точка отрезка.</param>
        /// <param name="size">Длина отрезка.</param>
        /// <param name="angle"> Наклон к горизонтали.</param>
        /// <returns></returns>
        private PointF GetPoint(PointF startpoint, float size, double angle)
        {
            PointF ans = new PointF();
            ans.X = (float)(startpoint.X - size * Math.Cos(angle));
            ans.Y = (float)(startpoint.Y - size * Math.Sin(angle));
            return ans;
        }
    }
}
