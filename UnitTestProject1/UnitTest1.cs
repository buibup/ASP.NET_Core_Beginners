using FirstApplication.Controllers;
using FirstApplication.Models;
using FirstApplication.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ControllerDoesNotReturnNull()
        {
            var mockBandRepository = new Mock<IBandRepository>();
            mockBandRepository.Setup(x => x.GetBands()).Returns(new List<Band> {
                new Band { Title = "mock title" }
            });
            var musicController = new MusicController(mockBandRepository.Object);
            Assert.IsNotNull(musicController);
        }
    }
}
