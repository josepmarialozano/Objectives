namespace Logics.Logic.Objective {
    using Data.DataSingleton;
    using System;
    using Util.Common;

    public class ObjectiveSelect {
        public Controller.DtoEntity.Objective ExecuteSelect(Guid trainingId) {
            try {
                return CommonSingleton.ObjectiveCommon.ToDtoEntity(Singleton.ObjectiveSelect.Select(trainingId));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
