namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[8]{0,1,1,2,3,5,8,13};
            string[] months = new string[12] { "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November" };
            int[][] matrix = new int[3][] { new[]{2,3,4}, new[]{2*2,3*3,4*4}, new[]{2*2*2,3*3*3,4*4*4} };
            double[][] jagged_array = new double[3][];
            jagged_array[0] = new double[] { 1, 2, 3, 4, 5 };
            jagged_array[1] = new double[] { Math.E, Math.PI };
            jagged_array[2] = new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) };

            // массивы для заданий 5 и 6.
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            Array Answer = Array.CreateInstance(typeof(int), 10);

            array.CopyTo(Answer, 0);
            array2.CopyTo(Answer, 3);

            // Выведите результат

            Console.WriteLine(Answer.GetValue(0));
            Console.WriteLine(Answer.GetValue(1));
            Console.WriteLine(Answer.GetValue(2));
            Console.WriteLine(Answer.GetValue(3));
            Console.WriteLine(Answer.GetValue(4));
            Console.WriteLine(Answer.GetValue(5));
            Console.WriteLine(Answer.GetValue(6));
            Console.WriteLine(Answer.GetValue(7));
            Console.WriteLine(Answer.GetValue(8));
            Console.WriteLine(Answer.GetValue(9));

            string[] sample = { "", "" };
            Array.Resize(ref sample, 4);
            Console.WriteLine("------------------");
            Console.WriteLine(sample[0]);  
            Console.WriteLine(sample[1]);  
            Console.WriteLine(sample[2]);  
            Console.WriteLine(sample[3]);  
            //ResizeArray(ref array, /* подставьте число вторым аргументов  */ );
            // Что же будет выведено?
        }
    }
}