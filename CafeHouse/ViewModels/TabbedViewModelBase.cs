using Prism;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace CafeHouse.ViewModels
{
    public class TabbedViewModelBase : BindableBase, IActiveAware
    {
        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set { SetProperty(ref _isActive, value, CurrentTabbedChanged); }
        }

        public virtual void CurrentTabbedChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);   
        }

        public event EventHandler IsActiveChanged;
    }
}
