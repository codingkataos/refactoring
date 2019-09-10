namespace Refactoring.Vacation
{

	public class RentalAgreement
	{
		readonly Vehicle vehicle;
		readonly double price;
		readonly int includedKM;
		readonly double extraKMPrice;
		readonly bool insured;
		readonly int durationInDays;

		public RentalAgreement(Vehicle vehicle,
							   int durationInDays,
							   double price,
							   int includedKM,
							   double extraKMPrice,
							   bool insured)
		{
			this.vehicle = vehicle;
			this.price = price;
			this.includedKM = includedKM;
			this.extraKMPrice = extraKMPrice;
			this.insured = insured;
			this.durationInDays = durationInDays;
		}

		public Vehicle Vehicle
		{
			get { return vehicle; }
		}

		public double BasePrice
		{
			get { return price; }
		}

		public int CoveredKilometers
		{
			get { return includedKM; }
		}

		public double PricePerExtraKilometer
		{
			get { return extraKMPrice; }
		}

		public bool IsInsured()
		{
			return insured;
		}

		public int ValidDuration
		{
			get { return durationInDays; }
		}

		public double ValidityChargesPerDay
		{
			get { return 100; }
		}
	}
}