using System;
public abstract class Parent
{
    protected bool input;
    protected static Random rand = new Random()
    protected Array(bool input = false)
    {
        this.input = input;

    }

    protected abstract void RandomFill();
    protected abstract void ManualFill();
    public abstract double Average();
    public abstract void Print();

}