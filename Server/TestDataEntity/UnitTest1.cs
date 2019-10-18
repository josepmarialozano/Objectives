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

        [Test]
        public void TestBaseEntity() {
            BaseEntity baseEntity = new BaseEntity();
            baseEntity.Id = Id;
            baseEntity.Name = Name;

            Assert.AreEqual(Id, baseEntity.Id);
            Assert.AreEqual(Name, baseEntity.Name);
        }

        [Test]
        public void TestObjective() {
            Objective objective = new Objective();
        }
    }
}