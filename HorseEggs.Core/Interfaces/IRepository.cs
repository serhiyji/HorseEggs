﻿using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseEggs.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        Task Save();
        Task Insert(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task Delete(object id);
        Task Delete(TEntity entityToDelete);
        Task Update(TEntity ententityToUpdate);
        Task<TEntity?> GetItemBySpec(ISpecification<TEntity> specification);
        Task<IEnumerable<TEntity>> GetListBySpec(ISpecification<TEntity> specification);
        Task<TEntity?> GetByID(object id);
    }
}
