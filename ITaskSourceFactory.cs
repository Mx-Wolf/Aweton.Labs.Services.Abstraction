namespace Aweton.Labs.Services.Abstraction;
public interface ITaskSourceFactory<TInit, TTask, TResult>{
  Task<ITaskSource<TTask, TResult>> CreateSource(TInit init);  
}
