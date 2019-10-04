namespace Data.RepositoryInterface.TrainingSensation {
    using DataEntity;
    using System;
    public interface ITrainingSensationSelect {
        TrainingSensation Select(Guid trainingSensationId);
    }
}
