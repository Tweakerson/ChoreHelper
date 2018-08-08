using System;
using System.Collections.Generic;
using ChoreData;
using ChoreServices.Interface;
using ChoreDataAccess.Interface;
using System.Linq;

namespace ChoreServices.Services
{
    public class ChoreEventService : IChoreEventService
    {
        private readonly IChoreEventRepository _repository;

        public ChoreEventService(IChoreEventRepository repo)
        {
            if(repo == null)
            {
                throw new ArgumentNullException(nameof(repo) + " cannot be null");
            }

            _repository = repo;
        }

        public IEnumerable<ChoreEvent> GetList()
        {
            return _repository.GetList();
        }

        public ChoreEvent GetRandomChore()
        {
            var list = _repository.GetList();

            return list.FirstOrDefault();
        }

        public ChoreEvent Save(ChoreEvent entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity) + " cannot be null");
            }

            return _repository.Save(entity);
        }
    }
}
