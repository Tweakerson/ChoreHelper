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
        private readonly IChoreRepository _repository;

        public ChoreService(IChoreRepository repo)
        {
            if(repo == null)
            {
                throw new ArgumentNullException(nameof(repo) + " cannot be null");
            }

            _repository = repo;
        }

        public IEnumerable<Chore> GetList()
        {
            return _repository.GetList();
        }

        public Chore GetRandomChore()
        {
            var list = _repository.GetList();

            return list.FirstOrDefault();
        }

        public Chore Save(Chore entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity) + " cannot be null");
            }

            return _repository.Save(entity);
        }
    }
}
