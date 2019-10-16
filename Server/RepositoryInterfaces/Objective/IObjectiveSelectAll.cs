namespace Data.RepositoryInterface.Objective {
    using System.Collections.Generic;
    using DataEntity;
    public interface IObjectiveSelectAll {
        List<Objective> SelectAll(int itemsPerPage, int page);
    }
}
