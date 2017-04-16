using ChoreData;
using ChoreDataAccess.Repositories;
using ChoreServices.Interface;
using ChoreServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreHelperDesktopUI.MainViewModel
{
    public class ChoreViewModel : INotifyPropertyChanged
    {
        IChoreService service;

        private IEnumerable<Chore> choreList;

        public IEnumerable<Chore> ChoreList
        {
            get { return choreList; }
            set
            {
                choreList = value;
                RaisePropertyChanged(nameof(ChoreList));
            }
        }
        
        public ChoreViewModel()
        {
            var repo = new ChoreRepository();
            service = new ChoreService(repo);

            ChoreList = service.GetList();
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
