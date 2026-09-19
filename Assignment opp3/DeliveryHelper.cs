using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_opp3
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment == null)
                return;

            shipment.PrintShipment();
        }
    }
}
