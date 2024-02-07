namespace task32
{
    abstract class ClassParent
    {
        protected static Random random = new Random();
        protected bool input;

        protected ParentClass(bool input = false)
        {
            this.input = input;
        }

        protected abstract void RandomFill();

        protected abstract void ManualFill();

        public abstract double Average();

        public abstract void Print();
    }
}