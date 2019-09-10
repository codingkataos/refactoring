namespace Refactoring.Move
{

	public class Customer
	{

		public void Appreciate(Employee employee)
		{
			Employee manager = employee.Project.Manager;
			string appreciation = "Dear " + manager.Name + ", A job well done by " + employee.Name + ".";
			Send(appreciation, manager);
		}

		private void Send(string appreication, Employee manager)
		{
			string email = manager.Email;
			// email sent!
		}
	}
}