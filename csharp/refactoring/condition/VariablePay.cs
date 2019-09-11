namespace Refactoring.Condition
{

	public class VariablePay
	{

		protected enum EmployeeType
		{
			CEO,
			DIRECTOR,
			ARCHITECT
		}

		protected double GetPay(EmployeeType employeeType)
		{
			switch (employeeType)
			{
				case EmployeeType.CEO: return 50 + (131.23);
				case EmployeeType.DIRECTOR: return 40 + (42.89);
				case EmployeeType.ARCHITECT: return 30 + (2.45);
				default: return 0;
			}
		}
	}
}