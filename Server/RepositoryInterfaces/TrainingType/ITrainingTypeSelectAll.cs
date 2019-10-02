namespace RepositoryInterface.TrainingType {
    using DataEntity;
    using System.Collections.Generic;

    interface ITrainingTypeSelectAll {
        List<TrainingType> SelectAll(int ItemsPerPage, int Page);
    }
}
