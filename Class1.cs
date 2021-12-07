namespace Grabacion2PracticaVectoresINS368
{
    public class Vector
    {
        public double x, y;
        Vector objeto1, objeto2;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static double Magnitud(double x, double y)
        {
            double x_m = Math.Pow(x, 2);
            double y_m = Math.Pow(y, 2);
            return x_m + y_m;
        }

        public static double DotProduct(Vector objeto1, Vector objeto2)
        {
            double a = objeto1.x * objeto2.x;
            double b = objeto1.y * objeto2.y;

            return a + b;
        }

        public static double AngleBetween(Vector objeto1, Vector objeto2)
        {
            double a = objeto1.x * objeto2.x;
            double b = objeto1.y * objeto2.y;
            double sum = a + b;

            double a_m = Math.Sqrt(Math.Pow(objeto1.x,2) + Math.Pow(objeto1.y,2));
            double b_m = Math.Sqrt(Math.Pow(objeto2.x, 2) + Math.Pow(objeto2.y, 2));

            return Math.Acos(sum / (a_m * b_m));
        }
    }
}