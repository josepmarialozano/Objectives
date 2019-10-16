namespace Logics.Logic.Objective {
    using Data.DataSingleton;
    using System;
    using Util.Common;

    public class ObjectiveUpdate {
        public Controller.DtoEntity.Objective ExecuteUpdate(Controller.DtoEntity.Objective objective) {
            try {
                if (Singleton.ObjectiveSelect.Select(objective.Id) == null)
                    throw new Exception("Objective Update. Objective doesn't exist.");
                return CommonSingleton.ObjectiveCommon.ToDtoEntity(Singleton.ObjectiveUpdate.Update(CommonSingleton.ObjectiveCommon.ToDataEntity(objective)));
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
