using System.Collections.Generic;
using Nop.ApiSlalom.Models.Common;

namespace Nop.ApiSlalom.Models.PrivateMessages
{
    public partial class PrivateMessageListModel
    {
        public IList<PrivateMessageModel> Messages { get; set; }
        public PagerModel PagerModel { get; set; }
    }
}