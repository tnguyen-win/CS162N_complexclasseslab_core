using System;
using CustomerProductClasses;

namespace CustomerProductListTests {
	class Program {
		static void Main() {
			/* USE AT OWN RISK - I discovered that low window size values can cause unexpected text wrapping with the logs */
			//if (OperatingSystem.IsWindows()) Console.SetWindowSize(120, 40);

			// get its count
			GetCustomersCount();
			Console.WriteLine("\n");
			// get a customer based on its position in the list
			GetCustomerAtIndex();
			Console.WriteLine("\n");
			// change the customer object in a specific position in the list
			ChangeCustomerAtIndex();
			Console.WriteLine("\n");
			// get a customer based on its email address
			GetCustomerFromEmail();
			Console.WriteLine("\n");
			// add a customer object
			AddCustomerToList();
			Console.WriteLine("\n");
			// add a customer given the individual attributes of a customer
			AddCustomerWithIndividualAttributes();
			Console.WriteLine("\n");
			// add a customer object using the + operator
			AddCustomerOperatorPlus();
			Console.WriteLine("\n");
			// save its contents to an xml file
			SaveCustomers();
			Console.WriteLine("\n");
			// fill its contents from the same xml file
			LoadCustomers();
			Console.WriteLine("\n");
			// remove a customer based on a customer object
			RemoveCustomer();
			Console.WriteLine("\n");
			// remove a customer using the - operator
			RemoveCustomerOperatorMinus();
			Console.WriteLine("\n");
			// convert its attributes to a string for displaying on the screen
			DisplayCustomerAttributes();
			Console.WriteLine("");
		}

		static void GetCustomersCount() {
			Customer customer1 = new();
			Customer customer2 = new();
			Customer customer3 = new();
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			Console.WriteLine("[Get Customer List Count]");
			Console.WriteLine("Expecting [3].");
			Console.WriteLine($"Got [{customerList.Count}].");
		}

		static void GetCustomerAtIndex() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			Console.WriteLine("[Get Customer At Index]");
			Console.WriteLine("Expecting [Id: 2 Email: fake2@gmail.com FirstName: john2 LastName: smith2 Phone: 541-456-456].");
			Console.WriteLine($"Got [{customerList[1]}].");
		}

		static void ChangeCustomerAtIndex() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			customerList[0].Id = 1234;
			customerList[0].Email = "someone@gmail.com";
			customerList[0].FirstName = "jane";
			customerList[0].LastName = "smith";
			customerList[0].Phone = "911-911-911";

			Console.WriteLine("[Change Customer At Index]");
			Console.WriteLine("Expecting [Id: 1234 Email: someone@gmail.com FirstName: jane LastName: smith Phone: 911-911-911].");
			Console.WriteLine($"Got [{customerList[0]}].");
		}

		static void GetCustomerFromEmail() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			Console.WriteLine("[Get Customer From Email]");
			Console.WriteLine("Expecting [Id: 2 Email: fake2@gmail.com FirstName: john2 LastName: smith2 Phone: 541-456-456]].");

			for (var i = 0; i < customerList.Count; i++) if (customerList[i].Email == "fake2@gmail.com") {
					Console.WriteLine($"Got [{customerList[i]}].");
					return;
				}

			Console.WriteLine("Got [].");
		}

		static void AddCustomerToList() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			CustomerList customerList = new();

			customerList.Add(customer1);

			Console.WriteLine("[Add Customer To List]");
			Console.WriteLine("Expecting [Id: 1 Email: fake1@gmail.com FirstName: john1 LastName: smith1 Phone: 541-123-123].");
			Console.WriteLine($"Got [{customerList[0]}].");
		}

		static void AddCustomerWithIndividualAttributes() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			customerList[0].Id = 1234;
			customerList[0].Email = "someone@gmail.com";
			customerList[0].FirstName = "jane";
			customerList[0].LastName = "smith";
			customerList[0].Phone = "911-911-911";

			Console.WriteLine("[Add Customer With Individual Attributes]");
			Console.WriteLine("Expecting [Id: 1234 Email: someone@gmail.com FirstName: jane LastName: smith Phone: 911-911-911].");
			Console.WriteLine($"Got [{customerList[0]}].");
		}

		static void AddCustomerOperatorPlus() {
			CustomerList customerList = new();
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");

			customerList += customer1;

			Console.WriteLine("[Add Customer Operator Plus]");
			Console.WriteLine("Expecting [Id: 1 Email: fake1@gmail.com FirstName: john1 LastName: smith1 Phone: 541-123-123].");
			Console.WriteLine($"Got [{customerList}].");
		}

		static void SaveCustomers() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			Console.WriteLine("[Save Customers]");

			customerList.Save();

			Console.WriteLine("Successfully saved customers to a local XML file.");
		}

		static void LoadCustomers() {
			CustomerList customerList = new();

			customerList.Fill();

			Console.WriteLine("[Load Customers]");
			Console.WriteLine("Expecting [Id: 1 Email: fake1@gmail.com FirstName: john1 LastName: smith1 Phone: 541-123-123\nId: 2 Email: fake2@gmail.com FirstName: john2 LastName: smith2 Phone: 541-456-456\nId: 3 Email: fake3@gmail.com FirstName: john3 LastName: smith3 Phone: 541-789-789].");
			Console.WriteLine($"Got [{customerList}].");
		}

		static void RemoveCustomer() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Remove(customerList[0]);

			Console.WriteLine("[Remove Customer]");
			Console.WriteLine("Expecting [].");
			Console.WriteLine($"Got [{customerList}].");
		}

		static void RemoveCustomerOperatorMinus() {
			CustomerList customerList = new();
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");

			customerList.Add(customer1);
			customerList -= customer1;

			Console.WriteLine("[Remove Customer Operator Negative]");
			Console.WriteLine("Expecting [].");
			Console.WriteLine($"Got [{customerList}].");
		}

		static void DisplayCustomerAttributes() {
			Customer customer1 = new(1, "fake1@gmail.com", "john1", "smith1", "541-123-123");
			Customer customer2 = new(2, "fake2@gmail.com", "john2", "smith2", "541-456-456");
			Customer customer3 = new(3, "fake3@gmail.com", "john3", "smith3", "541-789-789");
			CustomerList customerList = new();

			customerList.Add(customer1);
			customerList.Add(customer2);
			customerList.Add(customer3);

			Console.WriteLine("[Display Custom Attributes]");
			Console.WriteLine("Expecting [Id: 1 Email: fake1@gmail.com FirstName: john1 LastName: smith1 Phone: 541-123-123\nId: 2 Email: fake2@gmail.com FirstName: john2 LastName: smith2 Phone: 541-456-456\nId: 3 Email: fake3@gmail.com FirstName: john3 LastName: smith3 Phone: 541-789-789].");
			Console.Write("Got [");
			for (var i = 0; i < customerList.GetType().GetProperties().Length; i++) Console.WriteLine($"{customerList[i]}");
			Console.WriteLine("].");
		}
	}
}