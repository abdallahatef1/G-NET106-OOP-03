using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp3
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, decimal weight,
                               decimal deliveryFee, DeliveryAddress destination)
           : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        // EstimatedCost is NOT overridden: it uses the inherited calculation.

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            PrintCommonDetails();
            PrintLine("Estimated Cost", $"{EstimatedCost} EGP");
        }
    }
}
