namespace Infrastructure;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}