using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomControls
{
    class ClockWatchViewModel:INotifyPropertyChanged
    {
        private Int32 _sec;
        private Int32 _min;
        private Int32 _hour;
        public int Sec
        {
            get
            {
                return _sec;
            }
            set
            {
                _sec = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sec)));
            }
        }
        public int Min
        {
            get
            {
                return _min;
            }
            set
            {
                _min = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Min)));

            }
        }
        public int Hour
        {
            get
            {
                return _hour;
            }
            set
            {
                _hour = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Hour)));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
