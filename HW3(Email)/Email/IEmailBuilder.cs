using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public interface IEmailBuilder
    {
        IEmailAdditional BaseBuildEmail(IRecipient recipient, string body);
    }
}
