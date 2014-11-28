using Nop.Web.Framework.Mvc;
using Nop.ApiSlalom.Models.Common;

namespace Nop.ApiSlalom.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseNopModel
    {
        public CustomerAddressEditModel()
        {
            this.Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
    }
}