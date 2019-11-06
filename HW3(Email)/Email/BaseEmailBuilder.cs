using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class BaseEmailBuilder : IEmailBuilder
    {
        public IEmailAdditional BaseBuildEmail(IRecipient recipient, string body) =>
            new AdditionalBaseEmailBuilder(new Email
            {
                Recipients = new List<IRecipient> { recipient },
                Body = body
            });

        private class AdditionalBaseEmailBuilder : IEmailAdditional
        {
            private readonly Email newEmail;

            public AdditionalBaseEmailBuilder(Email baseEmail)
            {
                newEmail = baseEmail;
            }

            public IEmail BuildEmail => newEmail;

            public IEmailAdditional AddRecipient(IRecipient recipient)
            {
                newEmail.Recipients.Add(recipient);
                return new AdditionalBaseEmailBuilder(newEmail);
            }

            public IEmailAdditional AddTopic(string topic)
            {
                newEmail.Topic = topic;
                return new AdditionalBaseEmailBuilder(newEmail);
            }
        }

        private class Email : IEmail
        {
            public List<IRecipient> Recipients { get; set; }
            public string Topic { get; set; }
            public string Body { get; set; }
        }
    }
}
