using System.ComponentModel;

namespace Module_Motor_DC.Models
{
    class DataModel
    {
    }

    public class Data : INotifyPropertyChanged
    {
        private double speed, psignal, isignal, dsignal, pidsignal, setpoint, error;
        private int time, starttime;

        public int StartTime
        {
            get { return starttime; }
            set
            {
                if (starttime != value)
                {
                    starttime = value;
                    RaisePropertyChanged("StartTime");
                }
            }
        }

        public double Error
        {
            get { return error; }
            set
            {
                if (error != value)
                {
                    error = value;
                    RaisePropertyChanged("Error");
                }
            }
        }

        public int Time
        {
            get { return time; }
            set
            {
                if (time != value)
                {
                    time = value;
                    RaisePropertyChanged("Time");
                }
            }
        }

        public double PIDSignal
        {
            get { return pidsignal; }
            set
            {
                if (pidsignal != value)
                {
                    pidsignal = value;
                    RaisePropertyChanged("PIDSignal");
                }
            }
        }

        public double PSignal
        {
            get { return psignal; }
            set
            {
                if (psignal != value)
                {
                    psignal = value;
                    RaisePropertyChanged("PSignal");
                }
            }
        }

        public double ISignal
        {
            get { return isignal; }
            set
            {
                if (isignal != value)
                {
                    isignal = value;
                    RaisePropertyChanged("ISignal");
                }
            }
        }

        public double DSignal
        {
            get { return dsignal; }
            set
            {
                if (dsignal != value)
                {
                    dsignal = value;
                    RaisePropertyChanged("DSignal");
                }
            }
        }

        public double Speed
        {
            get { return speed; }
            set
            {
                if (speed != value)
                {
                    speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }

        public double SetPoint
        {
            get { return setpoint; }
            set
            {
                if (setpoint != value)
                {
                    setpoint = value;
                    RaisePropertyChanged("SetPoint");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    public class PID : INotifyPropertyChanged
    {
        private double kp, ki, kd;
        private bool isset;

        public bool IsSet
        {
            get { return isset; }
            set
            {
                if (isset != value)
                {
                    isset = value;
                    RaisePropertyChanged("IsSet");
                }
            }
        }
        public double KP
        {
            get { return kp; }
            set
            {
                if (kp != value)
                {
                    kp = value;
                    RaisePropertyChanged("KP");
                }
            }
        }

        public double KI
        {
            get { return ki; }
            set
            {
                if (ki != value)
                {
                    ki = value;
                    RaisePropertyChanged("KI");
                }
            }
        }

        public double KD
        {
            get { return kd; }
            set
            {
                if (kd != value)
                {
                    kd = value;
                    RaisePropertyChanged("KD");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
