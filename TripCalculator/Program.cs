/*
 * Name: Matthew Britton
 * Course: CSCI 1250, Section 002
 * Assignment 2: Lab 2, Trip Calculator
 * Date: September 23rd, 2026
 * Description: Calculates the fuel, food, and work hours behind one road trip. 
*/

//Part 1 Road Trip : Calculates gallons needed and fuel cost.
using System.Security.Cryptography;

Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

Console.WriteLine("=== Part 1 Road Trip ===");
Console.WriteLine("Round trip miles: " + milesForTheTrip);
Console.WriteLine("Miles per gallon: " + milesPerGallon);
Console.WriteLine("Price per gallon: " + gasPrice);
Console.WriteLine();
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

// Part 2 Pizza Party: Calculates total slices, slices per person, and pizza cost.
Console.Write("How many People are going? ");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas? ");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const int slicesPerPizza = 8;

double totalSlices = pizzas * slicesPerPizza;

double slicesPerPerson = totalSlices / peopleGoing;

double pizzaCost = pizzas * pricePerPizza;

Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("How many people are going: " + peopleGoing);
Console.WriteLine("How many pizzas: " + pizzas);
Console.WriteLine("Price per pizza: " + pricePerPizza);
Console.WriteLine();
Console.WriteLine("Total Slices: " + totalSlices.ToString("F2"));
Console.WriteLine("SLices Per Person: " + slicesPerPerson.ToString("F2"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

//Part 3 PayCheck: Calculates gross pay, tax witheld, and take home pay.
Console.Write("How many hours worked this week?: ");
int hoursWorked = Convert.ToInt32(Console.ReadLine()); 

Console.Write("What is your hourly rate? ");
decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

const decimal taxRate = 0.18m;

decimal grossPay = hoursWorked * hourlyRate;

decimal taxWitheld = grossPay * taxRate;

decimal takeHomePay = grossPay - taxWitheld;

Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("Hours worked this week: " + hoursWorked);
Console.WriteLine("Hourly Rate: " + hourlyRate);
Console.WriteLine();
Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax Withheld: " + taxWitheld.ToString("C"));
Console.WriteLine("Take Home Pay: " + takeHomePay.ToString("C"));

//Part 4 The Whole Trip: Calculates total cost of the trip.
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double takeHomePayPerHour = (double)takeHomePay / hoursWorked;

double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine();
Console.WriteLine("=== Part 4: The Whole Trip ===");
Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("F2"));