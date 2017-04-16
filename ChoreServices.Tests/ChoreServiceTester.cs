using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChoreServices.Services;
using ChoreDataAccess.Repositories;
using Moq;
using ChoreData;
using System.Collections.Generic;
using ChoreDataAccess.Interface;

namespace ChoreServices.Tests
{
    [TestClass]
    public class ChoreServiceTester
    {
        private Mock<IChoreRepository> _repo = new Mock<IChoreRepository>();
        private ChoreService service;

        [TestInitialize]
        public void InitBeforeTests()
        {
            service = new ChoreService(_repo.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Constructor cannot be null")]
        public void ChoreService_NullThrows()
        {
            new ChoreService(null);
        }

        [TestMethod]
        public void GetList_HitsRepository()
        {
            _repo.Setup(x => x.GetList()).Returns(new List<Chore>());

            service.GetList();
            _repo.Verify(x => x.GetList(), Times.Once);
        }

        [TestMethod]
        public void GetRandomChore_HitsRepository()
        {
            _repo.Setup(x => x.GetList()).Returns(new List<Chore>());

            service.GetRandomChore();
            _repo.Verify(x => x.GetList(), Times.Once);
        }

        [TestMethod]
        public void Save_HitsRepository()
        {
            _repo.Setup(x => x.Save(It.IsAny<Chore>())).Returns(new Chore());

            var entity = new Chore()
            {
                Name = "Button Pressing" 
            };

            service.Save(entity);
            _repo.Verify(x => x.Save(It.IsAny<Chore>()), Times.Once);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Passed entity cannot be null")]
        public void Save_NullInvalid()
        {
            service.Save(null);
        }
    }
}
