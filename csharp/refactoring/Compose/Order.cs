namespace Refactoring.Compose
{

	public class Order
	{

		private readonly double orderCost = 1000.25;
		private readonly bool orderedWithinTime = true;

		public double CalculatePrice()
		{
			int festiveDiscount = 10;
			int memberDiscount = 5;

			double firstDiscountedPrice = orderCost * festiveDiscount / 100;

			if (orderedWithinTime)
			{
				firstDiscountedPrice += firstDiscountedPrice + 10;
			}

			double memberDiscountedPrice = orderCost * memberDiscount / 100;

			double totalDiscount = firstDiscountedPrice + memberDiscountedPrice;

			double price = orderCost - totalDiscount;

			return price;
		}
	}
}