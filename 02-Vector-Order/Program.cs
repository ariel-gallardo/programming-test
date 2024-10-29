namespace _02_Vector_Order
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var vect = new List<int>() { 1, 3, 6, 8, 9, 10, -5, -23, 32, 6 };
            foreach (var e in vect.CustomOrder())
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }

    public static class VectorExtensions
    {
        public static IList<int> CustomOrder(this IList<int> vector, bool asc = true)
        {
            if (vector.Count <= 1) return vector;

            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < vector.Count - 1; i++)
                {
                    if ((asc && vector[i] > vector[i + 1]) || (!asc && vector[i] < vector[i + 1]))
                    {
                        int temp = vector[i];
                        vector[i] = vector[i + 1];
                        vector[i + 1] = temp;
                        sorted = false;
                    }
                }
            } while (!sorted);

            return vector;
        }
    }
}
