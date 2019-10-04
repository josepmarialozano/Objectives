namespace Data.RepositoryInterface.TrainingSensation {
    using System;
    using DataEntity;

    public interface ITrainingSensationAdd {
        Guid Add(TrainingSensation trainingSensation);
    }
}
