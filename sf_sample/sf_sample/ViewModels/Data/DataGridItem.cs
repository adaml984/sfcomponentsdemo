using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace sf_sample.ViewModels
{
    public class DataGridItem : INotifyPropertyChanged
    {
        private DateTime _dt;
        private string _firtName;
        private int _id;
        private string _lastName;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public DateTime Dt
        {
            get { return _dt; }
            set
            {
                _dt = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get { return _firtName; }
            set
            {
                _firtName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}