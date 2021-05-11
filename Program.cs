using System;
using System.IO;
using System.Collections.Generic;

namespace TicketingClasses
{
    class Program 
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Welcome to the Ticketing System");
            Console.Write("Would you like to create a ticket (Y/N)? ");
            char choice = Console.ReadLine().ToUpper()[0];
            string file = "Tickets.csv";
            StreamWriter sw = new StreamWriter(file);
            Ticket ticket = new Ticket();

            do
            {
                Console.Write("TicketNumber: ");
                ticket.ticketNumber = Console.ReadLine();

                Console.Write("Summary: ");
                ticket.ticketSummary = Console.ReadLine();

                Console.Write("Status ");
                ticket.ticketStatus = Console.ReadLine();

                Console.Write("Priority ");
                ticket.ticketPriority = Console.ReadLine();

                Console.Write("Submitter ");
                ticket.ticketSubmitter = Console.ReadLine();

                Console.Write("Assigned: ");
                ticket.ticketAssignedTo = Console.ReadLine();

                Console.Write("add a watcher? (Y/N)? ");
                char addWatcher = Console.ReadLine().ToUpper()[0];
                
                while (addWatcher != 'N')
                {
                    Console.Write("Enter the name of the watcher: ");
                    string addName = Console.ReadLine();
                    ticket.ticketWatchers.Add(addName);
                    Console.Write("Would you like to add another watcher (Y/N)? ");
                    addWatcher = Console.ReadLine().ToUpper()[0];

                } 

                sw.WriteLine(ticket.Display());
                sw.Close();
                Console.Write("Would you like to create another ticket (Y/N)? ");
                choice = Console.ReadLine().ToUpper()[0];

            } while (choice != 'N');
            Console.WriteLine("Would you like to read the tickets? (Y/N)?");
            choice = Console.ReadLine().ToUpper()[0];
            if (choice != 'N')
            {
                 StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                            
                        }
                        sr.Close();

            }
            else
            {
                Console.WriteLine("thank you for using the ticketing system");
            }
           
        }
    }
}