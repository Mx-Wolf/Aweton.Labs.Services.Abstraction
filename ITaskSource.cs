namespace Aweton.Labs.Services.Abstraction;

public interface ITaskSource<TTask, TResult>: IDisposable{
  Task<IEnumerable<TTask>> LoadTasks();
  Task RegisterResult(TResult result);
  Task RegisterSuccess();
  Task RegisterFailure(Exception exception);
}
