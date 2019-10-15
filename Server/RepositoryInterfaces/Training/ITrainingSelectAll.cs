namespace Data.RepositoryInterface.Training {
    using System;
    using System.Collections.Generic;
    using DataEntity;
    public interface ITrainingSelectAll {
        List<Training> SelectAll(Guid objectiveId, int itemsPerPage, int page);
    }
}
