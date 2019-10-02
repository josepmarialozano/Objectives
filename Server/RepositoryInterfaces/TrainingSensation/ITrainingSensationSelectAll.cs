namespace RepositoryInterface.TrainingSensation {
    using DataEntity;
    using System.Collections.Generic;

    interface ITrainingSensationSelectAll {
        List<TrainingSensation> SelectAll(int ItemsPerPage, int Page);
    }
}
