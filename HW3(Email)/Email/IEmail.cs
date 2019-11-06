using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public interface IEmail
    {
        List<IRecipient> Recipients { get; }
        string Topic { get; }
        string Body { get; }
    }
}
