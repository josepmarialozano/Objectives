namespace Data.RepositoryInterface.Objective {
    using System.Collections.Generic;
    using DataEntity;
    interface IObjectiveSelectAll {
        List<Objective> SelectAll(int itemsPerPage, int page);
    }
}
