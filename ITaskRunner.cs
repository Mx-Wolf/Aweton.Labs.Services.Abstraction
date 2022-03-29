namespace Aweton.Mxw.Services.Abstraction;

public interface ITaskRunner<TTask,TResponse>{
  Task<TResponse> ExecuteTask(TTask task);
}
