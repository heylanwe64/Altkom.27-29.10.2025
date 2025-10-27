namespace SOLID
{

    interface IMessage
    {
        void Send();
    }

    class Sms : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendSms()
        {
            Console.WriteLine($"Sending SMS to {PhoneNumber}: {Message}");
        }

        public void Send()
        {
            SendSms();
        }
    }

    class Mms : IMessage
    {
        public string PhoneNumber { get; set; }
        public byte[] Message { get; set; }

        public void SendMms()
        {
            Console.WriteLine($"Sending MMS to {PhoneNumber}");
        }

        public void Send()
        {
            SendMms();
        }
    }

    class Email : IMessage
    {
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void Send()
        {
            SendEmail();
        }


        public void SendEmail()
        {
            Console.WriteLine($"Sending Email to {EmailAddress}: {Subject}");
        }
    }



    class Messanger
    {
        //wstrzykiwanie przez konstruktor
        public Messanger(IEnumerable<IMessage?> messages)
        {
            Messages = messages;
        }

        //wstrzykiwanie przez właściwość
        public IEnumerable<IMessage?> Messages { get; set; }

        //wstrzykiwanie przez metodę
        public void Send(IEnumerable<IMessage> messages)
        {
            Messages = messages;
            Send();
        }

        public void Send()
        {
            foreach (var message in Messages)
            {
                message?.Send();
            }
        }
    }
}
