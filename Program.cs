using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

int numberofSandwiches = 0;
int numberofToppings = 0;
double tip = 0;
double totalsandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;


const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPINGS = 0.55;
const double DISCOUNT_AMOUNT = 0.10;

System.Console.WriteLine("How many sandwiches?");
numberofSandwiches= int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches "+numberofSandwiches);

System.Console.WriteLine("How many toppings?");
numberofToppings= int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings "+numberofToppings);

System.Console.WriteLine("Tip amount?");
tip= double.Parse(Console.ReadLine());
System.Console.WriteLine("Tip "+tip);

totalsandwichCost = COST_OF_SANDWICH*numberofSandwiches;
totalToppingCost = COST_OF_TOPPINGS*numberofToppings;
baseCost = totalsandwichCost + totalToppingCost;

orderCost = tip + baseCost * (1- DISCOUNT_AMOUNT);

System.Console.WriteLine("Your total is "+ orderCost);


