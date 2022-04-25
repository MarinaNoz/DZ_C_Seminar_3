// Напишие программу, которая принимает на вход координаты двух точек
// и находит расстяние между ними в 3D пространстве

double xA = Coordinate("x", "A");
double yA = Coordinate("y", "A");
double zA = Coordinate("z", "A");
double xB = Coordinate("x", "B");
double yB = Coordinate("y", "B");
double zB = Coordinate("z", "B");

double Coordinate(string coorName, string pointName)
{
   Console.WriteLine($"Введите координату {coorName} точки {pointName}: ");
   return Convert.ToDouble(Console.ReadLine());  
}
double a = (xB - xA)*(xB - xA);
double b = (yB - yA)*(yB - yA);
double c = (zB - zA)*(zB - zA);
double n = a + b + c;
double distance = Vector (n);

double Vector(double sum)
{
    return Math.Sqrt(sum);
}
Console.WriteLine($"Расстояние между точками равно {distance}");

