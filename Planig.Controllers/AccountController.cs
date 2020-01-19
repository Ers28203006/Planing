using Planing.DataAccess;
using Planing.DataAccess.Repository;
using Planing.DataAccess.Repository.Implementation;
using Planing.Models;
using Planing.Models.ViewModels.Acount;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planig.Controllers
{
    class AccountController
    {
        static DataModel _context = new DataModel();
        IRepository<Account> _repository = new SqlRepository<Account>(_context);
        public void Create(AccountViewModel accountViewModel)
        {
            var account = new Account()
            {
                Email = accountViewModel.CreateAccountViewModel.Email,
                Name = accountViewModel.CreateAccountViewModel.Name,
                Password = accountViewModel.CreateAccountViewModel.Password,
                Surname = accountViewModel.CreateAccountViewModel.Surname

            };
            _repository.Create(account); 
            
        }

        public void Delete(int id)
        {
            var account = _repository.GetById(id);
            if (account!=null)
                _repository.Remove(account);
        }

        public void Update(int id, AccountViewModel accountViewModel)
        {
            var account = _repository.GetById(id);
            account.Name = accountViewModel.UpdateAccountView.Name;
            account.Password = accountViewModel.UpdateAccountView.Password;
            account.Surname = accountViewModel.UpdateAccountView.Surname;
            account.Email = accountViewModel.UpdateAccountView.Email;
            if (account != null) _repository.Udate(account);
        }

        public IList<GetAccountViewModel> GetCollection()
        {
            var accounts = _repository.GetCollection().ToList();
            var accountViewModel = new AccountViewModel();
            foreach (var account in accounts)
            {
                GetAccountViewModel getAccountViewModel = new GetAccountViewModel()
                {
                    Email = account.Email,
                    Id=account.Id,
                    Name=account.Name,
                    Surname=account.Surname,
                    Password=account.Password
                };
                accountViewModel.GetAccountCollectionViewModel.GetAccountViewModels.Add(getAccountViewModel);
            }
            return accountViewModel.GetAccountCollectionViewModel.GetAccountViewModels;
        }
    }
}
