using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.WebUI.Domain.Interfaces;

namespace Blog.WebUI.Infrastructure.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly List<TEntity> _db;
        public Repository(List<TEntity> context)
        {
            this._db = context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _db;
        }
    }
}