﻿using CommonServiceLocator;
using PoolGuy.Mobile.CustomControls;
using PoolGuy.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoolGuy.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WCustomerPage : ContentPage
    {
        CustomerViewModel _viewModel;
        public WCustomerPage()
        {
            InitializeComponent();
        }

        public WCustomerPage(CustomerViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }
    }
}