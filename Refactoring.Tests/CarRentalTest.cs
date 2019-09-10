namespace Refactoring.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using Refactoring.Vacation;

	[TestClass]
	public class CarRentalTest
	{
		private CarRental carRental;

		private RentalAgreement rentalAgreement;



		[TestInitialize]

		public void SetUp()
		{
			carRental = new CarRental();

			Vehicle vehicle = new Vehicle(1000, 4, 1);

			rentalAgreement = new RentalAgreement(vehicle, 5, 5000, 1000, 10, true);
		}



		[TestMethod]

		public void start_trip_status_should_be_started()
		{
			carRental.StartTrip(rentalAgreement);

			Assert.IsTrue(carRental.IsTripStarted());

			Assert.IsFalse(carRental.IsTripEnded());
		}



		[TestMethod]

		public void end_trip_status_should_be_completed()
		{
			carRental.StartTrip(rentalAgreement);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
		}



		[TestMethod]

		public void no_additional_fuel_or_damage_trip_price_should_be_package_price()
		{

			carRental.StartTrip(rentalAgreement);
			rentalAgreement.Vehicle.SetOdomoterReading(1500);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
			Assert.AreEqual(5000.0, carRental.FinalPrice);
		}



		[TestMethod]

		public void more_km_trip_price_should_be_more()
		{

			carRental.StartTrip(rentalAgreement);
			rentalAgreement.Vehicle.SetOdomoterReading(2500);
			rentalAgreement.Vehicle.SetFuel(4);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
			Assert.AreEqual(11500.0, carRental.FinalPrice);

		}



		[TestMethod]

		public void less_fuel_trip_price_should_be_more()
		{

			carRental.StartTrip(rentalAgreement);
			rentalAgreement.Vehicle.SetOdomoterReading(1000);
			rentalAgreement.Vehicle.SetFuel(3);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
			Assert.AreEqual(5080.0, carRental.FinalPrice);
		}



		[TestMethod]

		public void damage_insured_trip__price_should_be_package_price()
		{

			carRental.StartTrip(rentalAgreement);
			rentalAgreement.Vehicle.SetOdomoterReading(1500);
			rentalAgreement.Vehicle.SetDamage(2);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
			Assert.AreEqual(5000.0, carRental.FinalPrice);
		}



		[TestMethod]

		public void damage_not_insured_trip__price_should_be_more()
		{
			Vehicle vehicle = new Vehicle(1000, 2, 1);
			rentalAgreement = new RentalAgreement(vehicle, 5, 5000, 1000, 10, false);
			carRental.StartTrip(rentalAgreement);
			rentalAgreement.Vehicle.SetOdomoterReading(1500);
			rentalAgreement.Vehicle.SetDamage(2);

			carRental.EndTrip();

			Assert.IsTrue(carRental.IsTripEnded());
			Assert.AreEqual(5500.0, carRental.FinalPrice);
		}
	}
}
