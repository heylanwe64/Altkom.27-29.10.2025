namespace DesignPatterns.Structural.Decorator
{
    internal class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(INotification notification) : base(notification)
        {
        }

        public const int MAX_LENGTH = 16;


        protected override void ExtraSend(string message)
        {
            foreach (var part in SplitMessage(message))
            {
                Console.WriteLine("Sending SMS: " + part);
            }
        }

        private IEnumerable<string> SplitMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                yield break;
            }
            for (int i = 0; i < message.Length; i += MAX_LENGTH)
            {
                yield return message.Substring(i, Math.Min(MAX_LENGTH, message.Length - i));
            }
        }
    }
}
