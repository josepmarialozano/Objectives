namespace TestDataEntity {
    using Data.DataEntity;
    using NUnit.Framework;
    using System;

    public class Tests {
        private Guid Id { get; set; }
        private string Name { get; set; }
        [SetUp]
        public void Setup() {
            Id = Guid.NewGuid();
            Name = Guid.NewGuid().ToString();
        }

        private void AddAndAssertBaseEntityInfo(BaseEntity baseEntity) {
            baseEntity.Id = Id;
            baseEntity.Name = Name;

            Assert.AreEqual(Id, baseEntity.Id);
            Assert.AreEqual(Name, baseEntity.Name);
        }

        private Objective AddObjective(string description = "description") {
            Objective objective = new Objective();
            AddAndAssertBaseEntityInfo(objective);
            objective.Description = description;
            return objective;
        }

        private TrainingType AddTrainingType() {
            TrainingType trainingType = new TrainingType();
            AddAndAssertBaseEntityInfo(trainingType);
            return trainingType;
        }

        private TrainingSensation AddTrainingSensation() {
            TrainingSensation trainingSensation = new TrainingSensation();
            AddAndAssertBaseEntityInfo(trainingSensation);
            return trainingSensation;
        }

        [Test]
        public void TestBaseEntity() {
            BaseEntity baseEntity = new BaseEntity();
            AddAndAssertBaseEntityInfo(baseEntity);
        }


        [Test]
        public void TestObjective() {
            string description = Guid.NewGuid().ToString();
            Objective objective = AddObjective(description);
            Assert.AreEqual(description, objective.Description);
        }

        [Test]
        public void TestTraining() {
            Objective objective = AddObjective();
            Training training = new Training();
            string description = Guid.NewGuid().ToString();
            double speed = new Random().NextDouble();
            int trainingLengthHours = new Random().Next(0, 24);
            int trainingLengthMinutes = new Random().Next(0, 60);
            int trainingLengthSeconds = new Random().Next(0, 60);
            int trainingDay = new Random().Next(1, 31);
            int trainingMonth = new Random().Next(1, 12);
            int trainingYear = new Random().Next(2019, 2021);
            int trainingHour = new Random().Next(0, 24);
            int trainingMinute = new Random().Next(0, 60);
            int trainingSecond = new Random().Next(0, 60);
            TrainingType trainingType = AddTrainingType();
            TrainingSensation trainingSensation = AddTrainingSensation();

            training.Description = description;
            training.ObjectiveId = objective.Id;
            training.Speed = speed;
            training.TrainingLengthHours = trainingLengthHours;
            training.TrainingLengthMinutes = trainingLengthMinutes;
            training.TrainingLengthSeconds = trainingLengthSeconds;
            training.TrainingDay = trainingDay;
            training.TrainingMonth = trainingMonth;
            training.TrainingYear = trainingYear;
            training.TrainingHour = trainingHour;
            training.TrainingMinute = trainingMinute;
            training.TrainingSecond = trainingSecond;
            training.TrainingType = trainingType;
            training.TrainingSensation = trainingSensation;

            Assert.AreEqual(training.Description, description);
            Assert.AreEqual(training.ObjectiveId, objective.Id);
            Assert.AreEqual(training.Speed, speed);
            Assert.AreEqual(training.TrainingLengthHours, trainingLengthHours);
            Assert.AreEqual(training.TrainingLengthMinutes, trainingLengthMinutes);
            Assert.AreEqual(training.TrainingLengthSeconds, trainingLengthSeconds);
            Assert.AreEqual(training.TrainingDay, trainingDay);
            Assert.AreEqual(training.TrainingMonth, trainingMonth);
            Assert.AreEqual(training.TrainingYear, trainingYear);
            Assert.AreEqual(training.TrainingHour, trainingHour);
            Assert.AreEqual(training.TrainingMinute, trainingMinute);
            Assert.AreEqual(training.TrainingSecond, trainingSecond);
            Assert.AreEqual(training.TrainingType, trainingType);
            Assert.AreEqual(training.TrainingSensation, trainingSensation);
        }

        [Test]
        public void TestTrainingType() {
            AddTrainingType();
        }

        [Test]
        public void TestTrainingSensation() {
            AddTrainingSensation();
        }
    }
}