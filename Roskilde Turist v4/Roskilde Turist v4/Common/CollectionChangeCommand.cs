using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Roskilde_Turist_v4.ViewModel;

namespace Roskilde_Turist_v4.Common
{
    class CollectionChangeCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ButikkerViewModel.OnCollectionChange(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
