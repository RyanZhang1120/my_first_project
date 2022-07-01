using System;
using System.Collections.Generic;
using System.Linq;
public class book_ticket
{
	public static void Main()
	{
		//Create a list with all the seating options to avoid repetition
		int[] A = new int[10];
		//Create the seating type option users need to input
		int next;
		//Create the total price of tickets
		int price = 0;
		//Create array of booked seats
		int[] booked = new int[] { };
		List<int> ls = booked.ToList();
		Console.WriteLine("Welcome to Ryan's theater:");
		Console.WriteLine("1 Book Luxury Lounger Recliners(No.1-5 seat) $200\n2 Book Stadium Seating(No.6-10 Seat) $100\n-1 Check out");
		//use the do/while loop to buy multiple tickets
		do
		{
			Console.WriteLine("Please choose seating type:");
			next = int.Parse(Console.ReadLine());
			//Use the switch statement to execute every option users input 
			switch (next)
			{
				//Luxury Lounger Recliners
				case 1:
					Console.WriteLine("Please choose seat number:");
					int next1 = int.Parse(Console.ReadLine());
					//if user input invalid seat number, then use continue to skip the wrong input and let user choose again
					if ((next1 < 1) || (next1 > 5))
					{
						Console.WriteLine("Whoops, this is no such seat number, please reenter a valid seat number(The range of First class is 1-5)");
					}
					//if the user pick a marked seat, then don't add the price
					else if (A[next1 - 1] == 1)
					{
						Console.WriteLine("Sorry...the seat {0} has already been taken!", next1);
					}
					else
					{
						//Mark the seat as "already been taken"
						A[next1 - 1] = 1;
						Console.WriteLine("Congrats...book successfully,your seat number is {0}.", next1);
						//add 200 when book successfully
						price += 200;
						//Add next1 to Array booked
						ls.Add(next1);
						booked = ls.ToArray();
					}
					break;
				//Stadium Seating
				case 2:
					Console.WriteLine("Please choose seat number:");
					int next2 = int.Parse(Console.ReadLine());
					if ((next2 < 6) || (next2 > 10))
					{
						Console.WriteLine("Whoops, this is no such seat number, please reenter a valid seat number(The range of First class is 6-10)");
					}
					else if (A[next2 - 1] == 1)
					{
						Console.WriteLine("Sorry...the seat {0} has already been taken!", next2);
					}
					else
					{
						A[next2 - 1] = 1;
						Console.WriteLine("Congrats...book successfully,your seat number is {0}.", next2);
						price += 100;
						ls.Add(next2);
						booked = ls.ToArray();
					}
					break;
				//check out and print the total price and seats booked
				case -1:
					Console.WriteLine("The total price is ${0}, \nthe seats you booked are: ", price);
					foreach (int s in booked)
					{
						Console.Write("{0} ",s);
					}
					break;
				default:
					Console.WriteLine("Invalid input, please reenter a valid seating type\n(1 Luxury Lounger Recliners 2. Stadium Seating -1. Cheak out)");
					break;
			}
		} while (next != -1);//End the loop when user input -1
	}
}
