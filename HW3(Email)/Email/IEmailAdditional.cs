using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public interface IEmailAdditional
    {
        IEmail BuildEmail { get; }
        IEmailAdditional AddTopic(string topic);

        IEmailAdditional AddRecipient(IRecipient recipient);

        
    }
}
