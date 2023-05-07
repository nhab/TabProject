using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FileProjects.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FileProjects.ViewModels
{
    public partial class MainWindow_ViewModel:ObservableObject
    {
        [ObservableProperty]
        private DataView dataView1=new DataView();

        [ObservableProperty]
         string? thePath = @"C:\root";


        private bool CanClick() => true;

        [RelayCommand(CanExecute = nameof(CanClick))]
        private  async Task Click()
        {
             DataView1 = FileFolder.Get(ThePath).DefaultView;
            int a = 0;
        }
    }
}
