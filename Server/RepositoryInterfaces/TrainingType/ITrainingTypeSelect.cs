namespace Data.RepositoryInterface.TrainingType {
    using DataEntity;
    using System;
    public interface ITrainingTypeSelect {
        TrainingType Select(Guid trainingTypeId);
    }
}
