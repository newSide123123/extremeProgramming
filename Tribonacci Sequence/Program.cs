namespace Tribonacci_Sequence
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            if (signature == null || signature.Length != 3)
            {
                throw new ArgumentException("Signature must contain 3 numbers.");
            }

            if (n == 0)
            {
                return Array.Empty<double>();
            }

            List<double> result = new List<double>(signature);

            for (int i = 3; i < n; i++)
            {
                result.Add(result[i - 3] + result[i - 2] + result[i - 1]);
            }

            return result.Take(n).ToArray();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] data = new double[] { 0, 0, 1 };

            Xbonacci xbonacci = new Xbonacci();

            Console.WriteLine(string.Join(',', xbonacci.Tribonacci(data, 7)));
        }
    }
}