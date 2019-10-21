using Data.DataSingleton;
using Data.RepositoryInterface.Objective;
using Data.RepositoryInterface.Training;
using Data.RepositoryInterface.TrainingSensation;
using Data.RepositoryInterface.TrainingType;
using NUnit.Framework;

namespace TestDataSingleton {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void TestTrainingType() {
            Assert.IsNotNull(Singleton.TrainingTypeAdd);
            Assert.IsTrue(Singleton.TrainingTypeAdd is ITrainingTypeAdd);

            Assert.IsNotNull(Singleton.TrainingTypeDelete);
            Assert.IsTrue(Singleton.TrainingTypeDelete is ITrainingTypeDelete);

            Assert.IsNotNull(Singleton.TrainingTypeSelect);
            Assert.IsTrue(Singleton.TrainingTypeSelect is ITrainingTypeSelect);

            Assert.IsNotNull(Singleton.TrainingTypeSelectAll);
            Assert.IsTrue(Singleton.TrainingTypeSelectAll is ITrainingTypeSelectAll);
            
            Assert.IsNotNull(Singleton.TrainingTypeUpdate);
            Assert.IsTrue(Singleton.TrainingTypeUpdate is ITrainingTypeUpdate);
        }

        [Test]
        public void TestTrainingSensation() {
            Assert.IsNotNull(Singleton.TrainingSensationAdd);
            Assert.IsTrue(Singleton.TrainingSensationAdd is ITrainingSensationAdd);

            Assert.IsNotNull(Singleton.TrainingSensationDelete);
            Assert.IsTrue(Singleton.TrainingSensationDelete is ITrainingSensationDelete);

            Assert.IsNotNull(Singleton.TrainingSensationSelect);
            Assert.IsTrue(Singleton.TrainingSensationSelect is ITrainingSensationSelect);

            Assert.IsNotNull(Singleton.TrainingSensationSelectAll);
            Assert.IsTrue(Singleton.TrainingSensationSelectAll is ITrainingSensationSelectAll);

            Assert.IsNotNull(Singleton.TrainingSensationUpdate);
            Assert.IsTrue(Singleton.TrainingSensationUpdate is ITrainingSensationUpdate);
        }

        [Test]
        public void TestTraining() {
            Assert.IsNotNull(Singleton.TrainingAdd);
            Assert.IsTrue(Singleton.TrainingAdd is ITrainingAdd);

            Assert.IsNotNull(Singleton.TrainingDelete);
            Assert.IsTrue(Singleton.TrainingDelete is ITrainingDelete);

            Assert.IsNotNull(Singleton.TrainingSelect);
            Assert.IsTrue(Singleton.TrainingSelect is ITrainingSelect);

            Assert.IsNotNull(Singleton.TrainingSelectAll);
            Assert.IsTrue(Singleton.TrainingSelectAll is ITrainingSelectAll);

            Assert.IsNotNull(Singleton.TrainingUpdate);
            Assert.IsTrue(Singleton.TrainingUpdate is ITrainingUpdate);
        }

        [Test]
        public void TestObjective() {
            Assert.IsNotNull(Singleton.ObjectiveAdd);
            Assert.IsTrue(Singleton.ObjectiveAdd is IObjectiveAdd);

            Assert.IsNotNull(Singleton.ObjectiveDelete);
            Assert.IsTrue(Singleton.ObjectiveDelete is IObjectiveDelete);

            Assert.IsNotNull(Singleton.ObjectiveSelect);
            Assert.IsTrue(Singleton.ObjectiveSelect is IObjectiveSelect);

            Assert.IsNotNull(Singleton.ObjectiveSelectAll);
            Assert.IsTrue(Singleton.ObjectiveSelectAll is IObjectiveSelectAll);

            Assert.IsNotNull(Singleton.ObjectiveUpdate);
            Assert.IsTrue(Singleton.ObjectiveUpdate is IObjectiveUpdate);

            Assert.IsNotNull(Singleton.ObjectiveUpdateStatus);
            Assert.IsTrue(Singleton.ObjectiveUpdateStatus is IObjectiveUpdateStatus);
        }
    }
}