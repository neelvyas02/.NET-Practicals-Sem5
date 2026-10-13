using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practicle_7.Controllers
{
    public class GameController : Controller
    {
        // Question 1
        public string Game(string name)
        {
            return "Welcome to " + name;
        }

        // Question 2
        public string FullName(string firstName, string lastName)
        {
            return "Your First Name = " + firstName + "<br/>" +
                   "Your Last Name = " + lastName;
        }

        // Question 3
        public string Age(string name, int birthYear)
        {
            int age = DateTime.Now.Year - birthYear;

            return "Name = " + name + "<br/>" +
                   "Birth Year = " + birthYear + "<br/>" +
                   "Age = " + age;
        }

        // Question 4
        public string Product(string name, int price)
        {
            double discountedPrice = price - (price * 0.10);

            return "Product Name = " + name + "<br/>" +
                   "Product Price = " + price + "<br/>" +
                   "Discounted Price (10%) = " + discountedPrice;
        }

        // Question 5
        public string Interest(int p, int r, int t)
        {
            int simpleInterest = (p * r * t) / 100;

            return "Principal = " + p + "<br/>" +
                   "Rate = " + r + "<br/>" +
                   "Time = " + t + "<br/>" +
                   "Simple Interest = " + simpleInterest;
        }

        // Question 6
        public string Email(string first, string last)
        {
            return "Generated Email = " + first + "." + last + "@gmail.com";
        }

        // Question 7
        public string Login(string username)
        {
            if (username == "admin")
            {
                return "Welcome " + username + "<br/>" +
                       "Login Successful";
            }
            else
            {
                return "Login Failed";
            }
        }

        // Question 8
        public string UserDetails(string first, string last, string city)
        {
            return "Name = " + first + " " + last + "<br/>" +
                   "City = " + city;
        }

        // Question 9
        public string Result(string name, int marks)
        {
            string result;
            string grade;

            if (marks >= 40)
            {
                result = "Pass";

                if (marks >= 80)
                    grade = "A";
                else if (marks >= 70)
                    grade = "B";
                else if (marks >= 60)
                    grade = "C";
                else
                    grade = "D";
            }
            else
            {
                result = "Fail";
                grade = "F";
            }

            return "Student Name = " + name + "<br/>" +
                   "Marks = " + marks + "<br/>" +
                   "Result = " + result + "<br/>" +
                   "Grade = " + grade;
        }

        // Question 10
        public string Temp(int celsius)
        {
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;

            return "Celsius = " + celsius + "<br/>" +
                   "Fahrenheit = " + fahrenheit;
        }
    }
}