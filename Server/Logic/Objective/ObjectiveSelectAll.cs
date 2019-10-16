namespace Logics.Logic.Objective {
    using Data.DataSingleton;
    using System;
    using System.Collections.Generic;
    using Util.Common;

    public class ObjectiveSelectAll {
        public List<Controller.DtoEntity.Objective> ExecuteSelectAll(int itemsPerPage, int page) {
            try {
                if (itemsPerPage <= 0)
                    page = 0;
                if (page <= 0)
                    itemsPerPage = 0;
                return CommonSingleton.ObjectiveCommon.ToDtoEntityList(Singleton.ObjectiveSelectAll.SelectAll(itemsPerPage, page));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
