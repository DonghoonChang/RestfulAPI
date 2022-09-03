using System.Linq.Expressions;
using RestfulAPI.Application.Repository;
using RestfulAPI.Domain.Common;

namespace RestfulAPI.Infrastructure.Repository;
public class EntityRepository: IRepository<Entity>
{
    public Entity Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Entity> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Entity> Find(Expression<Func<Entity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public void Add(Entity entity)
    {
        throw new NotImplementedException();
    }

    public void AddAll(IEnumerable<Entity> entities)
    {
        throw new NotImplementedException();
    }

    public void Remove(Entity entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveAll(IEnumerable<Entity> entities)
    {
        throw new NotImplementedException();
    }
}
