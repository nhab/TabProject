using FileProjects.Services;
using FileProjects.ViewModels;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows;

using Path = System.IO.Path;

namespace FileProjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainWindow_ViewModel();
            InitializeComponent();
       
        }

      
    }
}
