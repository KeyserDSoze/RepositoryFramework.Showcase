using RepositoryFramework.Showcase.Domain;
using System.Linq.Expressions;

namespace RepositoryFramework.Showcase.Infrastructure
{
    public class UserStorage : IStringableRepository<User>
    {
        public Task<bool> DeleteAsync(string key, CancellationToken cancellationToken = default)
        {
            //We do something here with a DB context for example
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(string key, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(string key, User value, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> QueryAsync(Expression<Func<User, bool>>? predicate = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            List<User> users = new List<User>();
            users.Add(new User
            {
                Age = 21,
                Email = "dasd",
                Id = 1,
                Name = "dddd"
            });
            return Task.FromResult(users.Select(x => x));
        }

        public Task<bool> UpdateAsync(string key, User value, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }
    }
}