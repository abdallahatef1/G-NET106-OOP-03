using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp3
{
    internal class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight,
                                decimal deliveryFee, DeliveryAddress destination)
           : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Completed Shipment");
            Console.WriteLine();
            PrintCommonDetails();
            PrintLine("Estimated Cost", $"{EstimatedCost} EGP");
        }
    }
}
