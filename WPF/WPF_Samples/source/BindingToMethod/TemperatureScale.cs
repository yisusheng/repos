using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToMethod
{
    public class TemperatureScale : INotifyPropertyChanged
    {
        private TempType _type;

        public TemperatureScale()
        { }

        public TemperatureScale(TempType type)
        {
            _type = type;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}