namespace Aweton.Labs.Services.Abstraction;

public interface ITaskAdapter<TResponse, TResult>{
  Task<TResult> Transform(TResponse response);
}
