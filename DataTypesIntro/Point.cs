

namespace DataTypesIntro
{
    internal class Point
    {
        public int x;
        public int y;

        public void PrintCoordinates()
        {
            Console.WriteLine("Coordinate x  " + x + "  Coordinate y  " + y);

        }
        public double GetDistance(Point p2)
        {
            return Math.Sqrt(Math.Pow((this.x - p2.x), 2) + Math.Pow((this.y - p2.y), 2));
        }


    }

    internal class PointTask
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            point1.x = 10;
            point1.y = 20;

            Point point2 = new Point();
            point2.x = 15;
            point2.y = 30;

            Point point3 = new Point();
            point3.x = 30;
            point3.y = 60;

            Point point4 = new Point();
            point4.x = 60;
            point4.y = 120;

            Point point5 = new Point();
            point5.x = 40;
            point5.y = 110;

            Point point6 = new Point();
            point6.x = 50;
            point6.y = 20;

            Point point7 = new Point();
            point7.x = 30;
            point7.y = 80;

            Point point8 = new Point();
            point8.x = 12;
            point8.y = 18;

            Point point9 = new Point();
            point9.x = 12;
            point9.y = 18;

            Point point10 = new Point();
            point10.x = 30;
            point10.y = 48;

            Point[] points = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10 };

            for (int i = 0; i < points.Length; i++)
            {
                points[i].PrintCoordinates();
            }

            double dist = point7.GetDistance(point8);

            Console.WriteLine(dist);
        }
    }

//-создать класс точка с координатами   х и у
//-написать метод вывода этих координат на экран
//-создать массив из 10 точек
//-вывести координаты всех точек в массиве на экан с помощью цикла
//-к классу Point добавить метод, который считает расстояние между точками
}
