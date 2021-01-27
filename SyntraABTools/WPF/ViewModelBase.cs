using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace SyntraABTools.WPF
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler _propertyChangedEvent;


        // with virtual the event can be overrided: public override event
        public virtual event PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChangedEvent += value; }
            remove { _propertyChangedEvent -= value; }
        }

        // OPTION A: USING NULL CONDITION OPERATOR ?. SHORTHAND NOTATION
        public void Changed([CallerMemberName] string propName = "") => _propertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propName));

        // OPTION B: USING NULL CONDITION OPERATOR ?. REGULAR NOTATION
        public void Notify([CallerMemberName] string propName = "")
        {
            // _propertyChangedEvent?.Invoke(propName, new PropertyChangedEventArgs(propName)); // ERROR BY TEACHER
            _propertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propName)); // CORRECT -> use 'this'
        }

        // OPTION C: USING NULL CONDITION REGULAR NOTATION
        public void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            if (_propertyChangedEvent != null)
            {
                _propertyChangedEvent(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
