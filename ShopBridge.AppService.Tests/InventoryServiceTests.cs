using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopBridge.DataModel.ServiceModel;
using ShopBridge.DbRepository.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopBridge.AppService.Tests
{
    [TestClass]
    public class InventoryServiceTests
    {
        [TestMethod]
        public void GetAllItemTest()
        {
            // Arrange
            var InventoryRepositoryMock = new Mock<IInventoryRepository>();

            var itemDetails = new List<ItemDetail>
            {
                new ItemDetail
                {
                    Id=1,
                    Name= "Item 1",
                    Description= "Description of item1",
                   Price= 22.30f,
                   Quantity= 2
                },
                 new ItemDetail
                {
                    Id=1,
                    Name= "Item 2",
                    Description= "Description of item2",
                   Price= 25.30f,
                   Quantity= 3
                },

            };

            InventoryRepositoryMock.Setup(x => x.GetAllItemDetails()).Returns(Task.Run(() => itemDetails));
            var inventoryService = new InventoryService(InventoryRepositoryMock.Object);

            // Act
            var result = inventoryService.GetAllItemDetails();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Result.Count);
            InventoryRepositoryMock.VerifyAll();
        }

        [TestMethod]
        public void GetItemByIDTest()
        {
            // Arrange
            var InventoryRepositoryMock = new Mock<IInventoryRepository>();

            var itemDetail = new ItemDetail
            {
                Id = 1,
                Name = "Item 1",
                Description = "Description of item1",
                Price = 22.30f,
                Quantity = 2
            };

            InventoryRepositoryMock.Setup(x => x.GetItemDetails(It.IsAny<int>())).Returns(Task.Run(() => itemDetail));
            var inventoryService = new InventoryService(InventoryRepositoryMock.Object);

            // Act
            var result = inventoryService.GetItemDetails(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(itemDetail, result.Result);
            InventoryRepositoryMock.VerifyAll();
        }

        [TestMethod]
        public void DeleteItemByIDTest()
        {
            // Arrange
            var InventoryRepositoryMock = new Mock<IInventoryRepository>();

            InventoryRepositoryMock.Setup(x => x.DeleteItemDetails(It.IsAny<int>())).Returns(Task.Run(() => 1));
            var inventoryService = new InventoryService(InventoryRepositoryMock.Object);

            // Act
            var result = inventoryService.DeleteItemDetails(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Result);
            InventoryRepositoryMock.VerifyAll();
        }


        [TestMethod]
        public void InsertItemsTest()
        {
            // Arrange
            var InventoryRepositoryMock = new Mock<IInventoryRepository>();

            var itemDetail = new ItemDetail
            {
                Name = "Item 1",
                Description = "Description of item1",
                Price = 22.30f,
                Quantity = 2
            };

            InventoryRepositoryMock.Setup(x => x.InsertItemDetails(It.IsAny<ItemDetail>())).Returns(Task.Run(() => 1));
            var inventoryService = new InventoryService(InventoryRepositoryMock.Object);

            // Act
            var result = inventoryService.InsertItemDetails(itemDetail);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Result);
            InventoryRepositoryMock.VerifyAll();
        }

        [TestMethod]
        public void UpdateItemsTest()
        {
            // Arrange
            var InventoryRepositoryMock = new Mock<IInventoryRepository>();

            var itemDetail = new ItemDetail
            {
                Name = "Item 1",
                Description = "Description of item1",
                Price = 22.30f,
                Quantity = 2
            };

            InventoryRepositoryMock.Setup(x => x.UpdateItemDetails(It.IsAny<ItemDetail>())).Returns(Task.Run(() => 1));
            var inventoryService = new InventoryService(InventoryRepositoryMock.Object);

            // Act
            var result = inventoryService.UpdateItemDetails(itemDetail);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Result);
            InventoryRepositoryMock.VerifyAll();
        }
    }
}