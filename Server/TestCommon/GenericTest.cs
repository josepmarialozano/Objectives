using NUnit.Framework;
using System;
using System.Collections.Generic;
using Util.Common.Entities;

namespace TestCommon {
    public class GenericTest {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestToDataEntity() {
            CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> commonGenericData = new CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
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
            CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> commonGenericData = new CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
            Data.DataEntity.TrainingType dataTrainingType = new Data.DataEntity.TrainingType {
                Id = Guid.NewGuid(),
                Name = "Testing"
            };
            Controller.DtoEntity.TrainingType controllerTrainingType = commonGenericData.ToDtoEntity(dataTrainingType);
            Assert.AreEqual(dataTrainingType.Id, controllerTrainingType.Id);
            Assert.AreEqual(dataTrainingType.Name, controllerTrainingType.Name);
        }

        [Test]
        public void TestToListControllerEntity() {
            CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType> commonGenericData = new CommonGeneric<Data.DataEntity.TrainingType, Controller.DtoEntity.TrainingType>();
            Data.DataEntity.TrainingType dataTrainingType = new Data.DataEntity.TrainingType {
                Id = Guid.NewGuid(),
                Name = "Testing"
            };
            Data.DataEntity.TrainingType dataTrainingType2 = new Data.DataEntity.TrainingType {
                Id = Guid.NewGuid(),
                Name = "Testing 2"
            };

            List<Data.DataEntity.TrainingType> dataTrainingTypeList = new List<Data.DataEntity.TrainingType>();
            dataTrainingTypeList.Add(dataTrainingType);
            dataTrainingTypeList.Add(dataTrainingType2);
            List<Controller.DtoEntity.TrainingType> controllerTypeList = commonGenericData.ToDtoEntityList(dataTrainingTypeList);
            for(int count = 0; count < dataTrainingTypeList.Count -1; count++) {
                Assert.AreEqual(dataTrainingTypeList[count].Id, controllerTypeList[count].Id);
                Assert.AreEqual(dataTrainingTypeList[count].Name, controllerTypeList[count].Name);
            }
        }
    }
}