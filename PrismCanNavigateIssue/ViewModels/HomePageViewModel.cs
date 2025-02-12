using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismCanNavigateIssue.Views;

namespace PrismCanNavigateIssue.ViewModels
{
    internal class HomePageViewModel(INavigationService navigationService) : BindableBase
    {

        private DelegateCommand? _goToChildPageCommandCommand;
        public DelegateCommand GoToChildPageCommand
        {
            get { return _goToChildPageCommandCommand ??= new DelegateCommand(GoToChildPageCommandHandler); }
        }
        private void GoToChildPageCommandHandler()
        {
            navigationService.NavigateAsync(nameof(ChildPage));
        }
    }
}
