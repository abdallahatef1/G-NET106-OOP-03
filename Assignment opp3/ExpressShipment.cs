using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp3
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;

        public decimal ExtraFee
        {
            get { return extraFee; }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return base.EstimatedCost + ExtraFee; }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight,
                               decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine();
            PrintCommonDetails();
            PrintLine("Extra Fee", $"{ExtraFee} EGP");
            PrintLine("Estimated Cost", $"{EstimatedCost} EGP");
        }
    }
}
