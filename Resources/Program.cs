using System;

namespace Yadley_Louidort_Functions_Asignment
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/*
			 * Yadley Louidort
			 * 11-19-2015
			 * Functions Asignment
			 * Section 02
			*/

			//We are going to calculate your debt
			Console.WriteLine ("Welcome lets calculate your debt!");


			//Asking customer how much they owe for car
			Console.WriteLine ("How much do you owe on your car?");

			//Capture the users response
			string carPrice = Console.ReadLine();

			//Declare a variable to hold the converted value
			double price;

			//Validate the user is typing in a valid number using a while loop
			while ( ! double.TryParse (carPrice, out price)) {
				//Alert the user to the error
				Console.WriteLine ("Opp's please use numbers only!\r\nHow much do you owe on your car?");
				//Recapture the user response in the same variable
				carPrice = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, Great deal on the car.", carPrice);


			//Monthly Payments
			//How much is the customer paying for the car a month
			Console.WriteLine ("How much do you pay for the car a month"); 

			//Capture the response
			string monthCarPrice = Console.ReadLine();

			//Creat a variable to hold the converted value
			double monthCar;

			//Validate the users response
			while( ! double.TryParse(monthCarPrice, out monthCar)){

				//Tell the user what is wrong!
				Console.WriteLine("Oops, please only type in numbers.\r\nHow much do you pay for the car a month?");
				monthCarPrice = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, monthly car payment.", monthCar);



			//Second Question
			Console.WriteLine ("How much is your student loan?");

			//Create a variable to capture the users response 
			string studentLoan = Console.ReadLine();

			//Declare the variable to hold the converted value
			double loan;

			//Validate using a while loop
			while( ! double.TryParse(studentLoan, out loan)){
				//Alert the user to the error
				Console.WriteLine ("Opp's please use numbers only!\r\nHow much is your student loan?");
				//Recapture the user response in the same variable
				studentLoan = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, It will be paid off once you get a job.", studentLoan);

			//Monthly Payments
			//How much is the customer paying for the car a month
			Console.WriteLine ("How much is your monthly student loan?"); 

			//Capture the response
			string monthStudentLoan = Console.ReadLine();

			//Creat a variable to hold the converted value
			double monthloan;

			//Validate the users response
			while( ! double.TryParse(monthStudentLoan, out monthloan)){

				//Tell the user what is wrong!
				Console.WriteLine("Oops, please only type in numbers.\r\nHow much is your monthly student loan?");
				monthStudentLoan = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, monthly student loan payment", monthloan);
				

			//Third Question
			Console.WriteLine ("How much is your morgage?");

			//Create a variable to capture the users response 
			string morgageLoan = Console.ReadLine();

			//Declare the variable to hold the converted value
			double morgage;

			//Validate using a while loop
			while( ! double.TryParse(morgageLoan, out morgage)){
				//Alert the user to the error
				Console.WriteLine ("Opp's please use numbers only!\r\nHow much is your morgage?");
				//Recapture the user response in the same variable
				morgageLoan = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, hope it's a great place to rest your head.", morgageLoan);

			//Monthly Payments
			//How much is the customer paying for their morgage a month
			Console.WriteLine ("How much is your morgage monthly?"); 

			//Capture the response
			string monthMorgagestring = Console.ReadLine();

			//Creat a variable to hold the converted value
			double monthMorgage;

			//Validate the users response
			while( ! double.TryParse(monthMorgagestring, out monthMorgage)){

				//Tell the user what is wrong!
				Console.WriteLine("Oops, please only type in numbers.\r\nHow much is your morgage monthly");
				monthMorgagestring = Console.ReadLine ();

			}

			//Print user information with feedback
			Console.WriteLine ("${0}, monthly morgage payment", monthMorgage);


			//Function call debtCalc
			double debt = debtCalc (price, loan, morgage);

			Console.WriteLine ("You are ${0}, in dept.", debt);


			//create call function for payments
			double yearlyDept = yearlyDeptCal (monthCar, monthloan, monthMorgage);

			Console.WriteLine ("Your yearly dept equals to ${0}.", yearlyDept);

			//TEST

			/*
			 * Test total debt
			 * 20,000 owed on car + 5,000 student loan + 60,000 morgage = 85,000
			 * 
			 * Test yearly debt
			 * 400*12 + 100*12 + 1,000+12 = 18,000
			 * 
			*/

			//end of test


		}

		public static double debtCalc (double c, double l, double m){

			//Create a variable for perimeter and do the math
			double priceInterest = c + l + m;

			//Return the perimeter value
			return priceInterest;

		}

		public static double yearlyDeptCal (double c, double l, double m){

			//Create a variable for perimeter and do the math
			double priceInterest = c*12 + l*12 + m*12;

			//Return the perimeter value
			return priceInterest;


			//end of code
		}


	}
}
