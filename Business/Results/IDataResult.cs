namespace Business.Results
{
    public interface IDataResult<T>
    {
        T Data { get; }
    }
}