using System;
using System.Collections.Generic;
using System.Text;

namespace DtoEntity {
    public class Training : BaseEntity {
        public Guid ObjectiveId { get; set; }
        public TrainingType TrainingType { get; set; }
        public TrainingSensation TrainingSensation { get; set; }
        public string Description { get; set; }
        private int _TrainingDay = -1;
        public int TrainingDay {
            get {
                return _TrainingDay;
            }
            set {
                if (!DateCorrect(value, _TrainingMonth, _TrainingYear))
                    throw new Exception("Incorrect date!");
                _TrainingDay = value;
            }
        }
        private int _TrainingMonth = -1;
        public int TrainingMonth {
            get {
                return _TrainingMonth;
            }
            set {
                if (!DateCorrect(_TrainingDay, value, _TrainingYear))
                    throw new Exception("Incorrect date!");
                _TrainingMonth = value;
            }
        }
        private int _TrainingYear = -1;
        public int TrainingYear {
            get {
                return _TrainingYear;
            }
            set {
                if (!DateCorrect(_TrainingDay, _TrainingMonth, value))
                    throw new Exception("Incorrect date!");
                _TrainingYear = value;
            }
        }
        private int _StartingHour = -1;
        public int StartingHour {
            get {
                return _StartingHour;
            }
            set {
                if (!HourCorrect(value, _StartingMinute, _StartingSecond))
                    throw new Exception("Incorrect hour!");
                _StartingHour = value;
            }
        }
        private int _StartingMinute = -1;
        public int StartingMinute {
            get {
                return _StartingMinute;
            }
            set {
                if (!HourCorrect(_StartingHour, value, _StartingSecond))
                    throw new Exception("Incorrect hour!");
                _StartingMinute = value;
            }
        }
        private int _StartingSecond = 0;
        public int StartingSecond {
            get {
                return _StartingSecond;
            }
            set {
                if (!HourCorrect(_StartingHour, value, _StartingSecond))
                    throw new Exception("Incorrect hour!");
                _StartingSecond = value;
            }
        }
        private int _TrainingHour = -1;
        public int TrainingHour {
            get {
                return _TrainingHour;
            }
            set {
                if (!HourCorrect(value, _TrainingMinute, _TrainingSecond))
                    throw new Exception("Incorrect hour!");
                _TrainingHour = value;
            }
        }
        private int _TrainingMinute = -1;
        public int TrainingMinute {
            get {
                return _TrainingMinute;
            }
            set {
                if (!HourCorrect(_TrainingHour, value, _TrainingSecond))
                    throw new Exception("Incorrect hour!");
                _TrainingMinute = value;
            }
        }
        private int _TrainingSecond = -1;
        public int TrainingSecond {
            get {
                return _TrainingSecond;
            }
            set {
                if (!HourCorrect(_TrainingHour, _TrainingMinute, value))
                    throw new Exception("Incorrect hour!");
                _TrainingSecond = value;
            }
        }
        public double Speed { get; set; }

        private bool DateCorrect(int Day, int Month, int Year) {
            if (Day == -1 || Month == -1 || Year == -1)
                return true;
            try {
                DateTime date = new DateTime(Year, Month, Day);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        private bool HourCorrect(int Hour, int Minute, int Second) {
            if (Hour == -1 || Minute == -1 || Second == -1)
                return true;
            try {
                if (Hour > 23 || Minute > 59 || Second > 59)
                    return false;
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
