using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace GreenWalk.Models
{
    public class Timer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TimeSpan Time
        {
            get => DateTime.Now - StartTime;
            set => throw new FieldAccessException();
        }
        public TimeSpan TimeSpent => EndTime - StartTime;
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public Timer()
        {
        }

        public void Start()
        {
            StartTime = DateTime.Now;
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Time"));
                return PropertyChanged != null;
            });
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
        }
    }
}
