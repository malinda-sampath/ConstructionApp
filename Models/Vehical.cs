using System;

namespace ConstructionApp.Models
{
    internal abstract class Vehical
    {
        private string regNo;
        private string fuelType;
        private string model;
        private DateOnly licenseRenewDate;
        private decimal fuelUsage;

        public string RegNo
        {
            get => regNo;
            set => regNo = value;
        }

        public string FuelType
        {
            get => fuelType;
            set
            {
                if (value == "Petrol" || value == "Diesel")
                {
                    fuelType = value;
                }
                else
                {
                    throw new ArgumentException("Fuel type must be either 'Petrol' or 'Diesel'.");
                }
            }
        }

        public string Model1
        {
            get => model;
            set => model = value;
        }

        public DateOnly LicRenewDate
        {
            get => licenseRenewDate;
            set => licenseRenewDate = value;
        }

        public decimal FuelUsage
        {
            get => fuelUsage;
            set => fuelUsage = value;
        }
    }
}
