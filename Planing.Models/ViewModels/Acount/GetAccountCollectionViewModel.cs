using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planing.Models.ViewModels.Acount
{
    public class GetAccountCollectionViewModel
    {
        public GetAccountCollectionViewModel()
        {
            GetAccountViewModels = new List<GetAccountViewModel>();
        }
        public IList<GetAccountViewModel> GetAccountViewModels { get; set; }
    }
}
