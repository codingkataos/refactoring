namespace Refactoring.Vacation
{
	using System;
	public class CarRental
	{
		Vehicle vehicle;
		RentalAgreement rentalAgreement;
		private int curKM;
		private int curFuel;
		private int curDamage;
		private double finalPrice;
		private DateTime currDate;
		private bool tripStarted;
		private bool tripEnded;

		public void StartTrip(RentalAgreement rentalAgreement)
		{
			currDate = new DateTime();
			this.rentalAgreement = rentalAgreement;
			tripStarted = true;

			// record odomoterReading, fuel level(1 to 4) and damage level( 1 to 4)
			vehicle = rentalAgreement.Vehicle;
			curKM = vehicle.CurrentReading;
			curFuel = vehicle.CurrentFuelLevel;
			curDamage = vehicle.DamageLevel;
		}

		public void EndTrip()
		{
			tripEnded = true;
			DateTime endDate = new DateTime();
			int endKM = vehicle.CurrentReading;
			int endFuel = vehicle.CurrentFuelLevel;
			int damage = vehicle.DamageLevel;
			double fuelPrice = 80;


			double price = rentalAgreement.BasePrice;

			// Add distance travelled expenses
			int total = endKM - curKM;
			int extra = total - rentalAgreement.CoveredKilometers;

			if (extra > 0)
				price = price + total + (extra * rentalAgreement.PricePerExtraKilometer);


			// Add fuel expenses
			if (endFuel < curFuel)
			{
				price = price + (curFuel - endFuel) * fuelPrice;
			}

			// Add any damage expenses.
			price = price + GetDamageExpenses(damage);

			// Add additional time expenses
			if ((endDate.Ticks - currDate.Ticks) / 1000 / 60 / 60 / 24 > rentalAgreement.ValidDuration)
			{
				double charges = rentalAgreement.ValidityChargesPerDay;
				long days = (endDate.Ticks - currDate.Ticks) / 1000 / 60 / 60 / 24 - rentalAgreement.ValidDuration;
				price = price + (days * charges);
			}

			finalPrice = price;
		}

		private double GetDamageExpenses(int damage)
		{
			double damageCost = 0.0;

			if (damage > curDamage && !rentalAgreement.IsInsured())
			{
				int diff = damage - curDamage;
				double pricePercent = 10.0 / 100;

				if (diff == 2) pricePercent = 20.0 / 100;
				if (diff == 3) pricePercent = 30.0 / 100;
				if (diff == 4) pricePercent = 40.0 / 100;

				damageCost = pricePercent * rentalAgreement.BasePrice;
			}
			return damageCost;
		}

		public bool IsTripStarted()
		{
			return tripStarted;
		}

		public bool IsTripEnded()
		{
			return tripEnded;
		}

		public double FinalPrice
		{
			get{ return finalPrice; }
		}
	}
}