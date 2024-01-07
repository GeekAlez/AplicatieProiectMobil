using AplicatieProiectMobil.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AplicatieProiectMobil.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private LoginRequestModel myloginRequestModel = new LoginRequestModel();
        public LoginRequestModel MyloginRequstModel
        {
            get { return myloginRequestModel; }
            set { myloginRequestModel = value;
            
            
                OnPropertyChanged(nameof(MyloginRequstModel));
            }
        }

        public ICommand LoginCommand { get; }
        


        public LoginViewModel() 
        {
            LoginCommand = new Command(PerformLoginOperation);



        }

        private async void PerformLoginOperation(object obj)
        {
            //Perform API Operation
            var data = myloginRequestModel;
            await Shell.Current.GoToAsync(state: "//MainPage");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged( string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
