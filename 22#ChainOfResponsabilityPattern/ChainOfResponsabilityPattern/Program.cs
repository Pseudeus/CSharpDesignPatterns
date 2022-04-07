using System;

namespace ChainOfResponsabilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Chain of Responsability Pattern Demo***\n");

        /*
            Making the chain:
                IssueRaiser->FaxErrorHandler->EmailErrorHandler
        */
            IReceiver faxHandler, emailHandler;

            emailHandler = new EmailErrorHandler(null);
            faxHandler = new FaxErrorHandler(emailHandler);

            IssueRaiser raiser = new IssueRaiser(faxHandler);

            Message m1 = new Message("Fax is reaching late to the destination.", MessagePriority.Normal);
            Message m2 = new Message("Emails are not raching to destinations.", MessagePriority.High);
            Message m3 = new Message("In Email, CC field is disabled always.", MessagePriority.Normal);
            Message m4 = new Message("Fax is not reaching destination.", MessagePriority.High);

            raiser.RaiseMessage(m1);
            raiser.RaiseMessage(m2);
            raiser.RaiseMessage(m3);
            raiser.RaiseMessage(m4);

        }
    }
}
