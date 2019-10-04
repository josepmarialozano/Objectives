using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DataEntity {
    public class Training : BaseEntity {
        public Guid ObjectiveId { get; set; }
        public TrainingType TrainingType { get; set; }
        public TrainingSensation TrainingSensation { get; set; }
        public string Description { get; set; }
        public int TrainingDay { get; set; }
        public int TrainingMonth { get; set; }
        public int TrainingYear { get; set; }
        public int StartingHour { get; set; }
        public int StartingMinute { get; set; }
        public int StartingSecond { get;set; }
        public int TrainingHour { get; set; }
        public int TrainingMinute { get; set; }
        public int TrainingSecond { get; set; }
        public double Speed { get; set; }
    }
}
