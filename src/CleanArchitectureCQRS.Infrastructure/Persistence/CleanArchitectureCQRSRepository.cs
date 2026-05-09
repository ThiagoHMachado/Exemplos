


using CleanArchitectureCQRS.Application.Interfaces;
using CleanArchitectureCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureCQRS.Infrastructure.Persistence;

public class CleanArchitectureCQRSRepository<T> : ICleanArchitectureCQRSRepository<T> where T : BaseEntity
{
    private static readonly List<T> _db = new();
    private readonly BdcleanarchitecturecqrsMdfContext context;

    public CleanArchitectureCQRSRepository(BdcleanarchitecturecqrsMdfContext context)
    {

        //context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        this.context = context;

    }


    public Task AddAsync(T entity)
    {
        context.Set<T>().Add(entity);
        context.SaveChangesAsync();
        return Task.CompletedTask;
    }
    public void DeleteAsync(T entity)
    {
        context.Set<T>().Remove(entity);
        context.SaveChangesAsync();
    }
    public Task UpdadeAsync(T entity)
    {
        context.Set<T>().Update(entity);
        context.SaveChangesAsync();
        return Task.CompletedTask;
    }

    public Task<T> GetByIdAsync(int id)
    {
        return Task.FromResult(_db.FirstOrDefault(p => p.Id == id));
    }

    public Task<List<T>> GetAllAsync()
    {

        return Task.FromResult(_db.ToList());
    }
}