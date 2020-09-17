using System;
using Claro.Application.Interfaces;
using Claro.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Claro.Domain.Entities;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

using Moq;

namespace Claro.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private ICelularAppService _celularAppService;


        [TestInitialize]
        public void Setup()
        {
            var celulares = new List<Celular>()
            {
                new Celular() { CelularId = 100, Model = "aaa", Price = 100, Brand = "bbb", Date = "01/01/2001", Photo = "ccc" },
                new Celular() { CelularId = 200, Model = "ddd", Price = 200, Brand = "eee", Date = "01/01/2002", Photo = "fff" }
            };

            var repoMock = new Mock<ICelularAppService>();

            repoMock.Setup(r => r.GetAll()).Returns(celulares);

            _celularAppService = repoMock.Object;
        }


        [TestMethod]
        public void GetAllCelulares_ShouldReturnAllCelulares()
        {
            // Arrange
            var vb = new ClaroController(_celularAppService);

            //Act
            vb.Get();

            ////Assert
            Assert.IsNotNull(vb.Get());
            Assert.AreEqual(2, vb.Get().Count());
        }
    }
}
