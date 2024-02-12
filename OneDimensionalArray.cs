using System; 
namespace task32
{
    sealed class OneDimensionalArray : Parent
    {
        private int[] array;
        private int n; 
    }

    public OneDimensionalArray(int n; bool input = false) : base(input)
    {
        this.n = n;
        array = new int[n];
        
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

    
}
