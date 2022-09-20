using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Amos.Mvvm.Messaging
{
    /// <summary>
    /// 弱引用信使，不需要自己注销
    /// </summary>
    public sealed class WeakReferenceMessenger : IMessenger
    {
        /// <summary>
        /// 用于存储信使实例
        /// </summary>
        private readonly Dictionary<Type, ConditionalWeakTable<object, object>> recipientsMap = new Dictionary<Type, ConditionalWeakTable<object, object>>();


        #region 实现 IMessenger 接口              

        public void Cleanup()
        {
            throw new NotImplementedException();
        }

        public void Register<TRecipient, TMessage, TToken>(TRecipient recipient, TToken token, MessageHandler<TRecipient, TMessage> handler)
            where TRecipient : class
            where TMessage : class
            where TToken : IEquatable<TToken>
        {
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public TMessage Send<TMessage, TToken>(TMessage message, TToken token)
            where TMessage : class
            where TToken : IEquatable<TToken>
        {
            throw new NotImplementedException();
        }

        public void Unregister<TMessage, TToken>(object recipient, TToken token)
            where TMessage : class
            where TToken : IEquatable<TToken>
        {
            throw new NotImplementedException();
        }

        public void UnregisterAll(object recipient)
        {
            throw new NotImplementedException();
        }

        public void UnregisterAll<TToken>(object recipient, TToken token) where TToken : IEquatable<TToken>
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
