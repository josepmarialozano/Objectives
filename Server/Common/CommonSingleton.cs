namespace Util.Common {
    using Util.Common.Entities;

    public class CommonSingleton {
        private static TrainingTypeCommon _TrainingTypeCommon;

        public static TrainingTypeCommon TrainingTypeCommon {
            get {
                if (_TrainingTypeCommon == null)
                    _TrainingTypeCommon = new TrainingTypeCommon();
                return _TrainingTypeCommon;
            }
        }

    }
}
