namespace RepositoryInterface.TrainingSensation {
    using System;
    using DataEntity;

    interface ITrainingSensationAdd {
        Guid Add(TrainingSensation TrainingSensation);
    }
}
