namespace Data.RepositoryInterface.Objective {
    using DataEntity;
    using System;

    public interface IObjectiveSelect {
        Objective Select(Guid objectiveId);
    }
}
