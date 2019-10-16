namespace Logics.Logic.Objective {
    using Data.DataSingleton;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Util.Common;

    public class ObjectiveAdd {
        public Guid ExecuteAdd(Controller.DtoEntity.Objective objective) {
            try {
                if (string.IsNullOrEmpty(objective.Name))
                    throw new Exception("Add Objective, Name shouldn't be empty");
                Data.DataEntity.Objective objectiveResult = Singleton.ObjectiveAdd.Add(CommonSingleton.ObjectiveCommon.ToDataEntity(objective));
                return objectiveResult.Id;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
