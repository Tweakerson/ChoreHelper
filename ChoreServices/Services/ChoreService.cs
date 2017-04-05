using System;
using System.Collections.Generic;
using ChoreData;
using ChoreServices.Interface;
using ChoreDataAccess.Interface;

namespace ChoreServices.Services
{
    public class ChoreService : IChoreService
    {
        private readonly IRepository _repository;

        public ChoreService(IRepository repo)
        {
            _repository = repo;
        }

        public IEnumerable<EntityBase> GetList()
        {
            return _repository.GetList();
        }

        public EntityBase GetRandomChore()
        {
            throw new NotImplementedException();
        }

        public EntityBase Save(EntityBase entity)
        {
            throw new NotImplementedException();
        }
    }
}
