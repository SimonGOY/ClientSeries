using ClientSeries.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using ClientSeries.Services;

namespace ClientSeries.ViewModels
{
    public class ControllerInsertViewModel: ObservableObject
    {
        public Serie serieToAdd { get; set; }
        public WSService Service { get; set; }
        public IRelayCommand BtnAddSerie { get; set; }

        public ControllerInsertViewModel()
        {
            Service = new WSService();
            //BtnAddSerie = new RelayCommand(AjouterSerie);
            serieToAdd = new Serie();
        }
    } 
}
