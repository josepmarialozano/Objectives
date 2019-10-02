namespace RepositoryInterface.TrainingType {
    using DataEntity;
    using System;
    interface ITrainingTypeSelect {
        TrainingType Select(Guid TrainingTypeId);
    }
}
