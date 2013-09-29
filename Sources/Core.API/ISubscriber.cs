﻿using System;

namespace MessageBus.Core.API
{
    public interface ISubscriber : IDisposable
    {
        bool Subscribe<TData>(Action<TData> callback);

        bool Subscribe<TData>(IProcessor<TData> processor);
        
        bool Subscribe(Type dataType, Action<object> callback);

        bool SubscribeHierarchy<TData>(Action<TData> callback);
    }
}