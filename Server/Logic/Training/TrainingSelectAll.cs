namespace Logics.Logic.Training {
    using Data.DataSingleton;
    using System;
    using System.Collections.Generic;
    using Util.Common;

    public class TrainingSelectAll {
        public List<Controller.DtoEntity.Training> ExecuteSelectAll(Guid objectiveId, int itemsPerPage, int page) {
            try {
                if (itemsPerPage <= 0)
                    page = 0;
                if (page <= 0)
                    itemsPerPage = 0;
                return CommonSingleton.TrainingCommon.ToDtoEntityList(Singleton.TrainingSelectAll.SelectAll(objectiveId, itemsPerPage, page));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
