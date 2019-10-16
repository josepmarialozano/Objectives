using Data.DataSingleton;
using System;
using Util.Common;

namespace Logics.Logic.Objective {
    public class ObjectiveUpdateStatus {
        public void ExecuteUpdateStatus(Guid objectiveId) {
            try {
                if (Singleton.ObjectiveSelect.Select(objectiveId) == null)
                    throw new Exception("Objective Update Status. Objective doesn't exist.");
                Singleton.ObjectiveUpdateStatus.UpdateStatus(objectiveId);
            }
            catch (Exception) {
                throw;
            }
        }

    }
}
