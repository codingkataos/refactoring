namespace Refactoring.Vacation
{

	public class Vehicle
	{
		private int odomoterReading;
		private int fuel;
		private int damage;

		public Vehicle(int reading, int fuel, int damage)
		{
			this.odomoterReading = reading;
			this.fuel = fuel;
			this.damage = damage;
		}

		public int CurrentReading
		{
			get { return odomoterReading; }
		}

		public int CurrentFuelLevel
		{
			get { return fuel; }
		}

		public int DamageLevel
		{
			get { return damage; }
		}

		public void SetOdomoterReading(int odomoterReading)
		{
			this.odomoterReading = odomoterReading;
		}

		public void SetFuel(int fuel)
		{
			this.fuel = fuel;
		}

		public void SetDamage(int damage)
		{
			this.damage = damage;
		}
	}
}