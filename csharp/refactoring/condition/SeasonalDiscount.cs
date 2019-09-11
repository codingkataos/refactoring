namespace Refactoring.condition
{
	using System;

	public class SeasonalDiscount
	{
		private static DateTime SUMMER_START = new DateTime();
		private static DateTime SUMMER_END = new DateTime();
		private double winterRate = 20;

		public double GetDiscount(DateTime date, int quantity) {
			double discount = 0;

			if (date > SUMMER_START && date < SUMMER_END) {
				discount = winterRate * quantity;
			} else {
				discount = 20 * quantity;
			}

			return discount;
		}
	}
}