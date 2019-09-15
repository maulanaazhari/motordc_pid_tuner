using Module_Motor_DC.Models;
using System.Collections.ObjectModel;

namespace Module_Motor_DC.ViewModels
{
    class DataViewModel
    {
        private Data _data = new Data();
        private ObservableCollection<Data> _dataCollection = new ObservableCollection<Data>();
        private PID _pid = new PID();

        public Data data
        {
            get { return _data; }
            set { _data = value; }
        }
        public ObservableCollection<Data> dataCollection
        {
            get { return _dataCollection; }
            set { _dataCollection = value; }
        }

        public PID pid
        {
            get { return _pid; }
            set { _pid = value; }
        }

        public void Add(int time, double speed, double psignal, double isignal, double dsignal, double setpoint)
        {
            if(dataCollection.Count == 0)
            {
                _data.StartTime = time;
                _data.Time = 0;
            }
            else
            {
                _data.StartTime = data.StartTime;
                _data.Time = time - data.StartTime;
            }
            _data.Speed = speed;
            _data.PSignal = psignal;
            _data.ISignal = isignal;
            _data.DSignal = dsignal;
            _data.PIDSignal = psignal + isignal + dsignal;
            _data.SetPoint = setpoint;
            _data.Error = setpoint - speed;
            data = _data;
            _dataCollection.Add(new Data { StartTime = data.StartTime, Time = data.Time, DSignal = dsignal, PSignal = psignal, ISignal = isignal, PIDSignal = data.PIDSignal, Error = data.Error, SetPoint = setpoint, Speed = speed });
            dataCollection = _dataCollection;
        }

        public void Initialize()
        {
            _pid.IsSet = false;
            pid = _pid;
        }
        public void SetKonstanta(double kp, double ki, double kd)
        {
            _pid.IsSet = true;
            _pid.KP = kp;
            _pid.KD = kd;
            _pid.KI = ki;
            pid = _pid;
        }
    }
}
