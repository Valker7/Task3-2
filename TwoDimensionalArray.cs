using System; 
namespace task32
{
    sealed class TwoDimensionalArray : Parent
    {
        private int[] array;
        private int n; 
    }

    public TwoDimensionalArray(int n, int m, bool input = false)
    {
        this.n = n;
        this.m = m;
        this.input = input;
        array = new int[n,m];


        if (input)
        {
            ManualInput();
        }
            else
        {
            RandomInput();
        }
    }

    protected override void ManualInput()
    {
            Console.WriteLine($"Enter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
    }

    protected override void RandomInput()
    {
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(-200, 200);
        }
        
    }   

    public double Average()
    {

        double summ = 0;
        for (int i = 0; i < n; i++)
        {
            summ += array[i];
        }
        return summ / n;

    }   
     

    
}