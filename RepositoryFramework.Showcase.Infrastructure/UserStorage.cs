using RepositoryFramework.Showcase.Domain;
using System.Linq.Expressions;

namespace RepositoryFramework.Showcase.Infrastructure
{
    public class UserStorage : IRepository<User>
    {
        public Task<BatchResults<User, string>> BatchAsync(BatchOperations<User, string> operations, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<State<User>> DeleteAsync(string key, CancellationToken cancellationToken = default)
        {
            //We do something here with a DB context for example
            throw new NotImplementedException();
        }

        public Task<State<User>> ExistAsync(string key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(string key, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }

        public Task<State<User>> InsertAsync(string key, User value, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }

        public ValueTask<TProperty> OperationAsync<TProperty>(OperationType<TProperty> operation, Query query, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async IAsyncEnumerable<User> QueryAsync(Expression<Func<User, bool>>? predicate = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            await Task.Delay(0).NoContext();
            List<User> users = new();
            users.Add(new User
            {
                Age = 21,
                Email = "dasd",
                Id = 1,
                Name = "dddd"
            });
            foreach (var user in users)
                yield return user;
        }

        public IAsyncEnumerable<User> QueryAsync(Query query, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<State<User>> UpdateAsync(string key, User value, CancellationToken cancellationToken = default)
        {
            //We do something here
            throw new NotImplementedException();
        }
    }
}