namespace Data.RepositoryInterface.Objective {
    using System;
    using DataEntity;

    public interface IObjectiveAdd {
        Guid Add(Objective objective);
    }
}
