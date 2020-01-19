namespace Planing.Models.ViewModels.Acount
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            CreateAccountViewModel = new CreateAccountViewModel();
            DeleteAccountViewModel = new DeleteAccountViewModel();
            UpdateAccountView = new UpdateAccountViewModel();
            GetAccountViewModel = new GetAccountViewModel();
            GetAccountCollectionViewModel = new GetAccountCollectionViewModel();
        }
        public CreateAccountViewModel CreateAccountViewModel { get; set; }
        public DeleteAccountViewModel DeleteAccountViewModel { get; set; }
        public UpdateAccountViewModel UpdateAccountView { get; set; }
        public GetAccountCollectionViewModel GetAccountCollectionViewModel { get; set; }
        public GetAccountViewModel GetAccountViewModel { get; set; }
    }
}
