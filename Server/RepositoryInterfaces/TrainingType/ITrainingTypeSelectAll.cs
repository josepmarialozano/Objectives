namespace Data.RepositoryInterface.TrainingType {
    using DataEntity;
    using System.Collections.Generic;

    public interface ITrainingTypeSelectAll {
        List<TrainingType> SelectAll(int itemsPerPage, int page);
    }
}
