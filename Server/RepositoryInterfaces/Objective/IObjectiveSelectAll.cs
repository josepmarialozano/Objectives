
namespace RepositoryInterface.Objective {
    using System.Collections.Generic;
    using DataEntity;
    interface IObjectiveSelectAll {
        List<Objective> SelectAll(int ItemsPerPage, int Page);
    }
}
