using System;
using System.Collections.Generic;
using System.Globalization;

namespace Practical_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Expense> expenses = new List<Expense>();
            int choice;

            do
            {
                Console.WriteLine("\n===== Expense Tracker =====");
                Console.WriteLine("1. Enter Expense");
                Console.WriteLine("2. Display All Expenses");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Expense e = new Expense();

                            if (e.AcceptExpenseDetails())
                            {
                                expenses.Add(e);
                                Console.WriteLine("Expense Added Successfully!");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        try
                        {
                            if (expenses.Count == 0)
                            {
                                throw new Exception("No Expense Details Found!");
                            }

                            Console.WriteLine("\n===== Expense Details =====");

                            foreach (Expense exp in expenses)
                            {
                                exp.DisplayExpenseDetails();
                                Console.WriteLine("---------------------------");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank You!");
                        break;

                    default:
                        try
                        {
                            throw new Exception("Invalid Choice!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

            } while (choice != 3);

            Console.ReadKey();
        }

        class Expense
        {
            public int expId;
            public string category;
            public double amt;
            public string paymentmode;
            public DateTime expDate;

            // Method 1: Accept Expense Details
            public bool AcceptExpenseDetails()
            {
                try
                {
                    Console.Write("Enter Expense ID: ");
                    expId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Category: ");
                    category = Console.ReadLine();

                    Console.Write("Enter Amount: ");
                    amt = Convert.ToDouble(Console.ReadLine());

                    if (amt <= 0)
                    {
                        throw new Exception("Amount must be greater than 0.");
                    }

                    Console.Write("Enter Payment Mode: ");
                    paymentmode = Console.ReadLine();

                    Console.Write("Enter Expense Date (dd/MM/yyyy): ");
                    expDate = DateTime.ParseExact(
                        Console.ReadLine(),
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture);

                    return true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input!");
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            // Method 2: Display Expense Details
            public void DisplayExpenseDetails()
            {
                Console.WriteLine("Expense ID   : " + expId);
                Console.WriteLine("Category     : " + category);
                Console.WriteLine("Amount       : " + amt);
                Console.WriteLine("Payment Mode : " + paymentmode);
                Console.WriteLine("Expense Date : " + expDate.ToString("dd/MM/yyyy"));
            }
        }
    }
}