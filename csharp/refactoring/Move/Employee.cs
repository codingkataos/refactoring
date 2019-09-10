namespace Refactoring.Move
{

	public class Employee {
	private readonly string name;
    private readonly string email;

		public Employee(string name, string email) {
			this.name = name;
			this.email = email;
		}

		public Project Project { get; set; }

		public string Name{
			get { return name; }
		}

		public string Email{
			get { return email; }
		}
	}
}