using System;
using System.Collections.Generic;
using System.Text;

namespace Amos.Mvvm.Messaging
{
    /// <summary>
    /// 消息的处理委托
    /// </summary>
    /// <typeparam name="TRecipient">消息接收者的类型</typeparam>
    /// <typeparam name="TMessage">消息的类型</typeparam>
    /// <param name="recipient"></param>
    /// <param name="message"></param>
    public delegate void MessageHandler<in TRecipient, in TMessage>(TRecipient recipient, TMessage message)
        where TRecipient : class
        where TMessage : class;
}
