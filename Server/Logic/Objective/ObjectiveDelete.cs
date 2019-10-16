namespace Logics.Logic.Objective {
    using Data.DataSingleton;
    using System;
    public class ObjectiveDelete {
        public void ExecuteDelete(Guid id) {
            try {
                if (Singleton.ObjectiveSelect.Select(id) == null)
                    throw new Exception("Objective Delete. Objective doesn't exist.");
                Singleton.ObjectiveDelete.Delete(id);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
