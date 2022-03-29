namespace Aweton.Labs.Services.Abstraction;

public interface ITaskSourceFactory<TInit, TTask>{
  Task<ITaskSource<TTask>> CreateSource(TInit init);  
}
