using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismCanNavigateIssue.ViewModels
{
    internal class ChildPageViewModel(IPageDialogService dialogService) : BindableBase, IConfirmNavigation
    {

        private bool _isCheckBoxChecked;
        public bool IsCheckBoxChecked
        {
            get => this._isCheckBoxChecked;
            set => SetProperty(ref this._isCheckBoxChecked, value);
        }

        public bool CanNavigate(INavigationParameters parameters)
        {
            if (!IsCheckBoxChecked)
            {
                dialogService.DisplayAlertAsync("Select the checkbox", "You have to select the checkbox to be able to navigate back", "OK");
                return false;
            }

            return true;
        }
    }
}
