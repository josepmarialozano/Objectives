namespace Logics.Logic.TrainingType {
    using Data.DataSingleton;
    using System;

    public class TrainingTypeDelete {
        public void ExecuteDelete(Guid id) {
            try {
                if (Singleton.TrainingTypeSelect.Select(id) == null)
                    throw new Exception("Training Type Delete. TrainingType doesn't exist.");
                Singleton.TrainingTypeDelete.Delete(id);
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
