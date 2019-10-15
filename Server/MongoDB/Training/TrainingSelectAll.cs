namespace Data.MongoDB.Training {
    using System;
    using System.Collections.Generic;
    using Data.DataEntity;
    using Data.RepositoryInterface.Training;
    public class TrainingSelectAll : ITrainingSelectAll {
        public List<Training> SelectAll(Guid objectiveId, int itemsPerPage, int page) {
            throw new NotImplementedException();
        }
    }
}
