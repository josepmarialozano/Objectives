namespace RepositoryInterface.TrainingSensation {
    using DataEntity;
    using System;
    interface ITrainingSensationSelect {
        TrainingSensation Select(Guid TrainingSensationId);
    }
}
