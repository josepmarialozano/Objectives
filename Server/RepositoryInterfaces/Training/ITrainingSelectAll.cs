namespace Data.RepositoryInterface.Training {
    using System.Collections.Generic;
    using DataEntity;
    public interface ITrainingSelectAll {
        List<Training> SelectAll(int itemsPerPage, int page);
    }
}
