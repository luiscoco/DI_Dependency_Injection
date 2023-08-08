using System;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        IEmailService emailService = new EmailService();
        OrderProcessor orderProcessor = new OrderProcessor(emailService);

        // Use the components
        orderProcessor.ProcessOrder(new Order());
    }
}

// Define interfaces
public interface IEmailService
{
    void SendEmail(string message);
}

// Concrete email service implementation
public class EmailService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

public class OrderProcessor
{
    private readonly IEmailService _emailService;

    public OrderProcessor(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void ProcessOrder(Order order)
    {
        // Process order logic
        Console.WriteLine("Order processed");
        _emailService.SendEmail("Order processed successfully.");
    }
}

public class Order { } // Dummy Order class


