using System;
namespace task32
{
    sealed class JaggedArray : Parent
    {
        private int n;
        private bool input;
        private OneDimensionalArray[] array;
        private static Random rand = new Random();

        private void ManualInput()
        {

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array length:");
                OneDimensionalArray one = new(int.Parse(Console.ReadLine()), true);
                array[i] = one;
                 
            }

        }

        private void RandomInput()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter array length:");
                OneDimensionalArray one = new(int.Parse(Console.ReadLine()), false);
                array[i] = one;
            }
        }


        public JaggedArray(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new OneDimensionalArray[n];


            if (input)
            {
                ManualInput();
            }
            else
            {
                RandomInput();
            }
        }


        protected override void Print()
        {
            Console.WriteLine("Printed array: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
                
        }


        


        protected override double AverageOfAll()
        {
            double summ = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    summ += array[i][j];
                    count++;
                }
                

            }
            return summ / count;

        }


        protected override void FillAgain(int n, bool input = false)
        {
            this.n = n;
            this.input = input;
            array = new OneDimensionalArray[n];


            if (input)
            {
                ManualInput();
            }
            else
            {
                RandomInput();
            }
        }
        
    }
}
