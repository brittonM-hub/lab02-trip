//Part 1 Road Trip
using System.Security.Cryptography;

Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of the car you are using? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

// Part 2 Pizza Party
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

Console.WriteLine("Total Slices: " + totalSlices.ToString("F2"));
Console.WriteLine("SLices Per Person: " + slicesPerPerson.ToString("F2"));
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

//Part 3 PayCheck
Console.Write("How many hours worked this week?: ");
int hoursWorked = Convert.ToInt32(Console.ReadLine()); 

Console.Write("What is your hourly rate? ");
decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

const decimal taxRate = 0.18m;

decimal grossPay = hoursWorked * hourlyRate;

decimal taxWitheld = grossPay * taxRate;

decimal takeHomePay = grossPay - taxWitheld;

Console.WriteLine("Gross Pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax Withheld: " + taxWitheld.ToString("C"));
Console.WriteLine("Take Home Pay: " + takeHomePay.ToString("C"));

//Part 4 The Whole Trip
double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double takeHomePayPerHour = (double)takeHomePay / hoursWorked;

double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work to cover your share: " + hoursMustWork.ToString("F2"));