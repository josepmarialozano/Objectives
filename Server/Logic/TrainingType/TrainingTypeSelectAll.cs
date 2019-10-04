namespace Logics.Logic.TrainingType {
    using Data.DataSingleton;
    using System.Collections.Generic;
    using Util.Common;

    public class TrainingTypeSelectAll {
        public List<Controller.DtoEntity.TrainingType> ExecuteSelectAll(int itemsPerPage, int page) {
            try {
                if (itemsPerPage <= 0)
                    page = 0;
                if (page <= 0)
                    itemsPerPage = 0;
                return CommonSingleton.TrainingTypeCommon.ToDtoEntityList(Singleton.TrainingTypeSelectAll.SelectAll(itemsPerPage, page));
            }
            catch (System.Exception) {
                throw;
            }
        }
    }
}
