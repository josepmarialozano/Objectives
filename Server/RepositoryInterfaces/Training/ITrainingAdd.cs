namespace RepositoryInterface.Training {
    using DataEntity;
    using System;

    interface ITrainingAdd {
        Guid Add(Training Training);
    }
}
