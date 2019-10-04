namespace Data.RepositoryInterface.TrainingSensation {
    using DataEntity;
    using System.Collections.Generic;

    public interface ITrainingSensationSelectAll {
        List<TrainingSensation> SelectAll(int itemsPerPage, int page);
    }
}
