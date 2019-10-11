namespace Logics.Logic.TrainingSensation {
    using Data.DataSingleton;
    using System.Collections.Generic;
    using Util.Common;

    public class TrainingSensationSelectAll {
        public List<Controller.DtoEntity.TrainingSensation> ExecuteSelectAll(int itemsPerPage, int page) {
            try {
                if (itemsPerPage <= 0)
                    page = 0;
                if (page <= 0)
                    itemsPerPage = 0;
                return CommonSingleton.TrainingSensationCommon.ToDtoEntityList(Singleton.TrainingSensationSelectAll.SelectAll(itemsPerPage, page));
            }
            catch (System.Exception) {
                throw;
            }
        }
    }
}
