namespace Game
{
    public interface ICondition<T>
    {
        bool Try(T data);
    }
}
