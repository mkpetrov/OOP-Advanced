public class Box<T>
{
    public Box(T item)
    {
        this.Value = item;
    }

    public T Value { get; private set; }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }
}