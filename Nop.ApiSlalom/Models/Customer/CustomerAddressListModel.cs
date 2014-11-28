using System.Collections.Generic;
using Nop.Web.Framework.Mvc;
using Nop.ApiSlalom.Models.Common;

namespace Nop.ApiSlalom.Models.Customer
{
    public partial class CustomerAddressListModel : BaseNopModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}