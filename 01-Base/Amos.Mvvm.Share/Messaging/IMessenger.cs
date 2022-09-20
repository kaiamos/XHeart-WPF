using System;
using System.Collections.Generic;
using System.Text;

namespace Amos.Mvvm.Messaging
{
    /// <summary>
    /// 信使的接口
    /// </summary>
    public interface IMessenger
    {
        /// <summary>
        /// 信使的注册
        /// </summary>
        /// <typeparam name="TRecipient">信息接收者的类型</typeparam>
        /// <typeparam name="TMessage">信息的类型</typeparam>
        /// <typeparam name="TToken">用来使信息到达指定地方的令牌</typeparam>
        /// <param name="recipient">接收者</param>
        /// <param name="token">令牌</param>
        /// <param name="handler">处理方法</param>
        void Register<TRecipient, TMessage, TToken>(TRecipient recipient, TToken token, MessageHandler<TRecipient, TMessage> handler)
            where TRecipient : class
            where TMessage : class
            where TToken : IEquatable<TToken>;

        /// <summary>
        /// 注销所有的信使
        /// </summary>
        /// <param name="recipient">信息接收者</param>
        void UnregisterAll(object recipient);

        /// <summary>
        /// 注销特定通道的信使
        /// </summary>
        /// <typeparam name="TToken">令牌类型</typeparam>
        /// <param name="recipient">接收者</param>
        /// <param name="token">令牌</param>
        void UnregisterAll<TToken>(object recipient, TToken token)
            where TToken : IEquatable<TToken>;


        /// <summary>
        /// 注销指定类型的信使
        /// </summary>
        /// <typeparam name="TMessage"></typeparam>
        /// <typeparam name="TToken"></typeparam>
        /// <param name="recipient"></param>
        /// <param name="token"></param>
        void Unregister<TMessage, TToken>(object recipient, TToken token)
            where TMessage : class
            where TToken : IEquatable<TToken>;

        /// <summary>
        /// 发功信息
        /// </summary>
        /// <typeparam name="TMessage">信息的类型</typeparam>
        /// <typeparam name="TToken">信息通道</typeparam>
        /// <param name="message">信息体</param>
        /// <param name="token">通道名</param>
        /// <returns></returns>
        TMessage Send<TMessage, TToken>(TMessage message, TToken token)
            where TMessage : class
            where TToken : IEquatable<TToken>;

        /// <summary>
        /// 清理数据但是不注销任何信使
        /// </summary>
        void Cleanup();

        /// <summary>
        /// 重置 IMessenger 实例并取消注册所有现有收件人。
        /// </summary>
        void Reset();
    }
}
