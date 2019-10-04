namespace Data.DataSingleton {
    using RepositoryInterface.TrainingType;
    using MongoDB.TrainingType;

    public class Singleton {
        private static ITrainingTypeAdd _TrainingTypeAdd;
        private static ITrainingTypeUpdate _TrainingTypeUpdate;
        private static ITrainingTypeSelect _TrainingTypeSelect;
        private static ITrainingTypeSelectAll _TrainingTypeSelectAll;
        private static ITrainingTypeDelete _TrainingTypeDelete;

        public static ITrainingTypeAdd TrainingTypeAdd {
            get {
                if (_TrainingTypeAdd == null)
                    _TrainingTypeAdd = new TrainingTypeAdd();
                return _TrainingTypeAdd;
            }
        }
        
        public static ITrainingTypeUpdate TrainingTypeUpdate {
            get {
                if (_TrainingTypeUpdate == null)
                    _TrainingTypeUpdate = new TrainingTypeUpdate();
                return _TrainingTypeUpdate;
            }
        }
        
        public static ITrainingTypeSelect TrainingTypeSelect {
            get {
                if (_TrainingTypeSelect == null)
                    _TrainingTypeSelect = new TrainingTypeSelect();
                return _TrainingTypeSelect;
            }
        }

        public static ITrainingTypeSelectAll TrainingTypeSelectAll {
            get {
                if (_TrainingTypeSelectAll == null)
                    _TrainingTypeSelectAll = new TrainingTypeSelectAll();
                return _TrainingTypeSelectAll;
            }
        }

        public static ITrainingTypeDelete TrainingTypeDelete {
            get {
                if (_TrainingTypeDelete == null)
                    _TrainingTypeDelete = new TrainingTypeDelete();
                return _TrainingTypeDelete;
            }
        }
    }
}
