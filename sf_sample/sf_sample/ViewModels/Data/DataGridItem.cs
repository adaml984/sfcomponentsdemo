using System;

namespace sf_sample.ViewModels
{
    public class DataGridItem : BaseViewModel
    {
        private DateTime _dt;
        private string _firstName;
        private int _id;
        private string _lastName;

        public int Id { get { return _id; } set { SetProperty(ref _id, value); } }

        public DateTime Dt { get { return _dt; } set { SetProperty(ref _dt, value); } }

        public string FirstName { get { return _firstName; } set { SetProperty(ref _firstName, value); } }

        public string LastName { get { return _lastName; } set { SetProperty(ref _lastName, value); } }
    }
}