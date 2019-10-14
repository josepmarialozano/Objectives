namespace Data.RepositoryInterface.Training {
    using System;
    using DataEntity;
    public interface ITrainingSelect {
        Training Select(Guid trainingId);
    }
}
