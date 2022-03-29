namespace Aweton.Mxw.Services.Abstraction;

public interface ITaskAdapter<TResponse, TResult>{
  Task<TResult> Transform(TResponse response);
}
