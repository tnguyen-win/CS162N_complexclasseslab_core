namespace CustomerProductClasses {
	public class Customer {
		private int id;
		private string email;
		private string firstName;
		private string lastName;
		private string phone;

		public Customer() { }

		public Customer(int customerId, string customEmail, string customerFirstName, string customerLastName, string customerPhone) {
			id = customerId;
			email = customEmail;
			firstName = customerFirstName;
			lastName = customerLastName;
			phone = customerPhone;
		}

		public int Id {
			get => id;
			set => id = value;
		}

		public string Email {
			get => email;
			set => email = value;
		}

		public string FirstName {
			get => firstName;
			set => firstName = value;
		}

		public string LastName {
			get => lastName;
			set => lastName = value;
		}

		public string Phone {
			get => phone;
			set => phone = value;
		}

		public override string ToString() {
			return $"Id: {id} Email: {email} FirstName: {firstName} LastName: {lastName} Phone: {phone}";
		}

		public override bool Equals(object obj) {
			if (obj == null || obj.GetType() != this.GetType()) return false;
			else {
				Customer other = (Customer)obj;
				return other.Id == Id && other.Email == Email && other.FirstName == FirstName && other.LastName == LastName && other.Phone == Phone;
			}
		}

		public override int GetHashCode() {
			return 13 + 7 * id.GetHashCode() + 7 * email.GetHashCode() + 7 * firstName.GetHashCode() + 7 * lastName.GetHashCode() + 7 * phone.GetHashCode();
		}


		public static bool operator ==(Customer p1, Customer p2) {
			return p1.Equals(p2);
		}

		public static bool operator !=(Customer p1, Customer p2) {
			return !p1.Equals(p2);
		}
	}
}