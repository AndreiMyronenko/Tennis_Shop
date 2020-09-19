using FinalProject.ViewModels;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Infra
{
    class ViewModelLocator
    {
        IKernel kernel;
        public ViewModelLocator()
        {
            kernel = new StandardKernel(new Module());
        }
        public MainViewModel MainViewModel
        {
            get => kernel.Get<MainViewModel>();
        }

        public InfoViewModel InfoViewModel
        {
            get => kernel.Get<InfoViewModel>();
        }

        public AdminViewModel AdminViewModel
        {
            get => kernel.Get<AdminViewModel>();
        }
    }
}
