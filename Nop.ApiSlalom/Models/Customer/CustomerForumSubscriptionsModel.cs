using System.Collections.Generic;
using Nop.ApiSlalom.Models.Common;

namespace Nop.ApiSlalom.Models.Customer
{
    public partial class CustomerForumSubscriptionsModel
    {
        public CustomerForumSubscriptionsModel()
        {
            this.ForumSubscriptions = new List<ForumSubscriptionModel>();
        }

        public IList<ForumSubscriptionModel> ForumSubscriptions { get; set; }
        public CustomerNavigationModel NavigationModel { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}