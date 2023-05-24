using System.Collections.Generic;

namespace CustomerProductClasses {
	public class CustomerList {
		private List<Customer> customers;

		public CustomerList() {
			customers = new List<Customer>();
		}

		public int Count {
			get { return customers.Count; }
			set { }
		}

		public void Fill() {
			customers = CustomerDB.GetCustomers();
		}

		public void Save() {
			CustomerDB.SaveCustomers(customers);
		}

		public void Add(Customer customer) {
			customers.Add(customer);
		}

		public void Add(int id, string email, string firstName, string lastName, string phone) {
			Customer p = new Customer(id, email, firstName, lastName, phone);

			customers.Add(p);
		}

		public void Remove(Customer customer) {
			customers.Remove(customer);
		}

		public override string ToString() {
			string output = "";

			foreach (Customer p in customers) output += p.ToString() + "\n";

			return output;
		}

		public Customer this[int i] {
			get => customers[i];
			set => customers[i] = value;
		}

		public Customer this[string email] {
			get {
				foreach (Customer p in customers) if (p.Email == email) return p;

				return null;
			}
		}

		public static CustomerList operator +(CustomerList cL, Customer c) {
			cL.Add(c);

			return cL;
		}

		public static CustomerList operator -(CustomerList cL, Customer c) {
			cL.Remove(c);

			return cL;
		}
	}
}