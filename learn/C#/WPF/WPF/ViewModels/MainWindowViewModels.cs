using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModels
{
    public class MainWindowViewModels : ObservableObject
    {
        public MainWindowViewModels()
        {
            AddCommand = new RelayCommand(Add);
            SaveCommand = new RelayCommand(Save);
        }

        private double input1;

        public double Input1
        {
            get => input1;
            set => SetProperty(ref input1, value);
        }

        private double input2;

        public double Input2
        {
            get => input2;
            set => SetProperty(ref input2, value);
        }

        private double result;

        public double Result
        {
            get => result;
            set => SetProperty(ref result, value);
        }

        public ICommand AddCommand { get; set; }

        private void Add()
        {
            this.Result = this.Input1 + this.Input2;
        }

        public ICommand SaveCommand { get; set; }

        private void Save()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }
    }
}