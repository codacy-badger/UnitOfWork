namespace UnitOfWork.Core.Generic
{
    /// <summary>
    /// Abstraction Of UnitOfWork with Generic DataContext
    /// </summary>
    /// <typeparam name="TContext">Context  </typeparam>
    public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : class
    {

    }
}
