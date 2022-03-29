namespace Aweton.Labs.Services.Abstraction;

public interface ITaskRunner<TTask,TResponse>{
  Task<TResponse> ExecuteTask(TTask task);
}
