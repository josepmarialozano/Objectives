using NUnit.Framework;
using System;
using Util.Common.Entities;

namespace TestCommon {
    public class GenericTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestToDataEntity() {
            CommonGenericData<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> commonGenericData = new CommonGenericData<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
            Controller.DtoEntity.TrainingType controllerTrainingType = new Controller.DtoEntity.TrainingType {
                Id = Guid.NewGuid(),
                Name = "Testing"
            };
            Data.DataEntity.TrainingType dataTrainingType = commonGenericData.ToDataEntity(controllerTrainingType);
            Assert.AreEqual(dataTrainingType.Id, controllerTrainingType.Id);
            Assert.AreEqual(dataTrainingType.Name, controllerTrainingType.Name);
        }

        [Test]
        public void TestToControllerEntity() {
            CommonGenericData<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> commonGenericData = new CommonGenericData<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
            Data.DataEntity.TrainingType dataTrainingType = new Data.DataEntity.TrainingType {
                Id = Guid.NewGuid(),
                Name = "Testing"
            };
            Controller.DtoEntity.TrainingType controllerTrainingType = commonGenericData.ToDtoEntity(dataTrainingType);
            Assert.AreEqual(dataTrainingType.Id, controllerTrainingType.Id);
            Assert.AreEqual(dataTrainingType.Name, controllerTrainingType.Name);
        }
    }
}