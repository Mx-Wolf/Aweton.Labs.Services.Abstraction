namespace Aweton.Mxw.Services.Abstraction;

public interface ITaskSource<TTask>{
  Task<IEnumerable<TTask>> LoadTasks();
  Task RegisterSuccess();
  Task RegisterFailure(Exception exception);
}
