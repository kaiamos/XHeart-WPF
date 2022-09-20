using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Amos.Mvvm
{
    public interface IRelayCommand : ICommand
    {
        /// <summary>
        /// 通知能够执更改
        /// </summary>
        void NotifyCanExecuteChanged();
    }
}
