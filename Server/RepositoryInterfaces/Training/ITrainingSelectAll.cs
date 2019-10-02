namespace RepositoryInterface.Training {
    using System.Collections.Generic;
    using DataEntity;
    interface ITrainingSelectAll {
        List<Training> SelectAll(int ItemsPerPage, int Page);
    }
}
