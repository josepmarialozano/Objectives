namespace Logics.Logic.TrainingSensation {
    using Data.DataSingleton;
    using System;

    public class TrainingSensationDelete {
        public void ExecuteDelete(Guid id) {
            try {
                if (Singleton.TrainingSensationSelect.Select(id) == null)
                    throw new Exception("Training Sensation Delete. TrainingSensation doesn't exist.");
                Singleton.TrainingSensationDelete.Delete(id);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
