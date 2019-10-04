namespace Data.RepositoryInterface.Training {
    using System;
    using DataEntity;
    interface ITrainingSelect {
        Training Select(Guid trainingId);
    }
}
