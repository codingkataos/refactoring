namespace Refactoring.Condition
{

	public class Pension
	{
		readonly bool alive;
		readonly bool retired;
		readonly bool poverty;

		public double Pay()
		{
			double amount;
			if (!alive)
			{
				amount = 100;
			}
			else
			{
				if (retired)
				{
					amount = 1000;
				}
				else
				{
					if (poverty)
					{
						amount = 100000;
					}
					else
					{
						amount = 500;
					}
				}
			}

			return amount;
		}
	}
}