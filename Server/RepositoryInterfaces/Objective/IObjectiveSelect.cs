namespace RepositoryInterface.Objective {
    using DataEntity;
    using System;

    interface IObjectiveSelect {
        Objective Select(Guid ObjectiveId);
    }
}
