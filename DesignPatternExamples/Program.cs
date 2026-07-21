//Tạo interface
interface IMessage
{
    void Send();
}

//Tạo component
class EmailMessage : IMessage
{
    public void Send()
    {
        Console.WriteLine("Send Email");
    }
}

//Tạo decorator
class LogDecorator : IMessage
{
    private readonly IMessage message;

    public LogDecorator(IMessage message)
    {
        this.message = message;
    }

    public void Send()
    {
        Console.WriteLine("Write Log");
        message.Send();
    }
}

class Program
{
    static void Main()
    {
        IMessage message = new LogDecorator(new EmailMessage());

        message.Send();
    }
}