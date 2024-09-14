using System;

namespace ConstructionApp.Models
{
    public class Vehicle
    {
        private string regNo;
        private string numberPlate;
        private string fuelType;
        private string model;
        private DateTime licenseRenewDate;
        private DateTime insuranceRenewDate;
        private decimal fuelUsage;

        public string RegNo
        {
            get => regNo;
            set
            {
                // Assuming numberPlate is already set and has at least one '-' character
                if (numberPlate != null)
                {
                    var parts = numberPlate.Split('-');
                    if (parts.Length > 1)
                    {
                        regNo = parts[1]; // Setting regNo to the part after '-'
                    }
                    else
                    {
                        // Handle cases where numberPlate does not contain '-' as needed
                        regNo = value;
                    }
                }
                else
                {
                    regNo = value;
                }
            }
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

        public string Model
        {
            get => model;
            set => model = value;
        }

        public DateTime LicRenewDate
        {
            get => licenseRenewDate;
            set => licenseRenewDate = value;
        }

        public decimal FuelUsage
        {
            get => fuelUsage;
            set => fuelUsage = value;
        }
        public DateTime InsuranceRenewDate { get => insuranceRenewDate; set => insuranceRenewDate = value; }
        public string NumberPlate
        {
            get => numberPlate;
            set
            {
                numberPlate = value;
                // Optionally update regNo if numberPlate changes
                if (numberPlate != null)
                {
                    var parts = numberPlate.Split('-');
                    if (parts.Length > 1)
                    {
                        regNo = parts[1];
                    }
                }
            }
        }
    }
}
