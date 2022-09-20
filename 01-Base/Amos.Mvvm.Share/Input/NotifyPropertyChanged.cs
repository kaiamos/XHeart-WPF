using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Amos.Mvvm
{
    /// <summary>
    /// 此类为是实现 INotifyPropertyChanged 的基类，通知客户端属性值已更改。
    /// </summary>
    public abstract class NotifyPropertyChangedBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
