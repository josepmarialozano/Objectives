namespace Logics.Logic.Training {
    using Data.DataSingleton;
    using System;
    public class TrainingDelete {
        public void ExecuteDelete(Guid id) {
            try {
                if (Singleton.TrainingSelect.Select(id) == null)
                    throw new Exception("Training Delete. Training doesn't exist.");
                Singleton.TrainingDelete.Delete(id);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
