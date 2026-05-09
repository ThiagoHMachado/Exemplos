
namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface IEventHandler<TEvent>
    {
        Task HandleAsync(
            TEvent message,
            CancellationToken cancellationToken);
    }
}