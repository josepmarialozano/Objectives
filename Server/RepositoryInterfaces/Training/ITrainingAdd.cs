namespace Data.RepositoryInterface.Training {
    using DataEntity;
    using System;

    public interface ITrainingAdd {
        Guid Add(Training training);
    }
}
