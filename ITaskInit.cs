namespace Aweton.Labs.Services.Abstraction;
public interface ITaskInit<TInit>{
  Task<TInit> ComputeInit();
}
