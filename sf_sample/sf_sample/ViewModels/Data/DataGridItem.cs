using System;

namespace sf_sample.ViewModels.Data
{
    public class DataGridItem : BaseViewModel
    {
        private DateTime _dt;
        private string _firtName;
        private string _lastName;
        public DateTime DT { get { return _dt; } set { SetProperty(ref _dt, value); } }
        public string FirstName { get { return _firtName; } set { SetProperty(ref _firtName, value); } }
        public string LastName { get { return _lastName; } set { SetProperty(ref _lastName, value); } }
    }
}