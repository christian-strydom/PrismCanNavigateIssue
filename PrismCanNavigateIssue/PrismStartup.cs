using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismCanNavigateIssue.ViewModels;
using PrismCanNavigateIssue.Views;

namespace PrismCanNavigateIssue
{
    internal class PrismStartup
    {
        public static void Configure(PrismAppBuilder builder)
        {
            builder.RegisterTypes(RegisterTypes)
                .OnInitialized(OnInitialized)
                .CreateWindow($"/NavigationPage/{nameof(HomePage)}");
        }

        private static void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ChildPage, ChildPageViewModel>();
        }

        private static void OnInitialized(IContainerProvider container)
        {
        }


    }
}
