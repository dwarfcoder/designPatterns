using System.Text;

//
Message msg = new Message {
    Title = "Hello, world!",
    Body = $@"Hi everyone!
    This is a test message to demonstrate some things.
    I try to 'send' this message via different senders.",
    Sender = "Some guy"
};

msg.Recepients.Add("john@company.com");
msg.Recepients.Add("eva@company.com");

IMessageSender sender = new TextMessageSender();
sender.Send(msg);