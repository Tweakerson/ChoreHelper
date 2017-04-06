using System;
using System.Collections.Generic;
using ChoreData;
using ChoreServices.Interface;
using ChoreDataAccess.Interface;
using System.Linq;

namespace ChoreServices.Services
{
    public class ChoreService : IChoreService
    {
        private readonly IRepository _repository;

        public ChoreService(IRepository repo)
        {
            if(repo == null)
            {
                throw new ArgumentNullException(nameof(repo) + " cannot be null");
            }

            _repository = repo;
        }

        public IEnumerable<EntityBase> GetList()
        {
            return _repository.GetList();
        }

        public EntityBase GetRandomChore()
        {
            var list = _repository.GetList();

            return list.FirstOrDefault();
        }

        public EntityBase Save(EntityBase entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity) + " cannot be null");
            }

            return _repository.Save(entity);
        }
    }
}
