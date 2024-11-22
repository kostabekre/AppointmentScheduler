namespace Domain.Requests;

public class Result<T>
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error? Error { get; }
    public T? Data { get; }

    public Result(Error error)
    {
        Error = error;
    }
    
    public Result(T data)
    {
        IsSuccess = true;
        Data = data;
    }
}