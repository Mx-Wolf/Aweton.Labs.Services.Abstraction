namespace Aweton.Mxw.Services.Abstraction;

public interface ITaskSourceFactory<TInit, TTask>{
  Task<ITaskSource<TTask>> CreateSource(TInit init);  
}
