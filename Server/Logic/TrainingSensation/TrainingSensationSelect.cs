using Data.DataSingleton;
using System;
using Util.Common;

namespace Logics.Logic.TrainingSensation {
    public class TrainingSensationSelect {
        public Controller.DtoEntity.TrainingSensation ExecuteSelect(Guid trainingSensationId) {
            try {
                return CommonSingleton.TrainingSensationCommon.ToDtoEntity(Singleton.TrainingSensationSelect.Select(trainingSensationId));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
