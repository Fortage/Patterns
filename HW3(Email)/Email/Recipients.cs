using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class Recipient : IRecipient
    {
        public Recipient(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
