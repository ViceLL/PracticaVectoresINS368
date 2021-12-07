int x, y;
Console.WriteLine("Ingrese x & y para calcular magnitud: ");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());

Console.WriteLine("Magnitud: ");
Console.WriteLine(Grabacion2PracticaVectoresINS368.Vector.Magnitud(x, y));

Grabacion2PracticaVectoresINS368.Vector objeto1 = new Grabacion2PracticaVectoresINS368.Vector(2, 5);
Grabacion2PracticaVectoresINS368.Vector objeto2 = new Grabacion2PracticaVectoresINS368.Vector(1, 3);
Console.WriteLine("Dot Product: ");
Console.WriteLine(Grabacion2PracticaVectoresINS368.Vector.DotProduct(objeto1, objeto2));

Console.WriteLine("Angle Between: ");
Console.WriteLine(Grabacion2PracticaVectoresINS368.Vector.AngleBetween(objeto1, objeto2));

