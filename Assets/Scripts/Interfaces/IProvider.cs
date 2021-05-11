namespace Game
{
    public interface IProvider<T>
    {
        T Get();
    }

    public interface IProvider<T, D>
    {
        T Get(D data);
    }
}
