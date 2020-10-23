﻿using System;

namespace LccHotfix
{
    public class AViewBase<T> : AObjectBase, IView<T> where T : ViewModelBase
    {
        public bool isInit;
        public Binding<T> binding;
        protected DataBinder<T> dataBinder;
        public AViewBase()
        {
            ViewModel = Activator.CreateInstance<T>();
        }
        public T ViewModel
        {
            get
            {
                return binding.Value;
            }
            set
            {
                if (!isInit)
                {
                    InitView();
                }
                binding.Value = value;
            }
        }
        public virtual void InitView()
        {
            isInit = true;
            binding = new Binding<T>();
            dataBinder = new DataBinder<T>();
            binding.OnValueChange += Binding;
        }
        public virtual void Binding(T oldValue, T newValue)
        {
            dataBinder.UnBind(oldValue);
            dataBinder.Bind(newValue);
        }
    }
}