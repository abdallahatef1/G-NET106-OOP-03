namespace Assignment_opp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region qA
            Driver driver = new Driver("Abdallah atef");
            #endregion
            #region qB
            DeliveryCenter center = new DeliveryCenter("Suez");

            #endregion

            #region qC
            center.Driver = driver;

            #endregion

            #region q D-e-f
            DeliveryAddress address = new DeliveryAddress("SUEZ", "Nile Street", 10);

            StandardShipment standard = new StandardShipment("SH001", "Laptop", 3, 80, address);
            ExpressShipment express = new ExpressShipment("SH002", "Mobile Phone", 2, 60, address, 30);
            InternationalShipment international = new InternationalShipment("SH003", "Television", 8, 120, address, "Spain", 100);


            #endregion

            #region qG
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);

            #endregion

            #region qH
            center.PrintAllShipments();

            #endregion

            #region qI
            Console.WriteLine();
            Console.WriteLine("Printing Using DeliveryHelper...");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(standard);
            Console.WriteLine("Standard Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(express);
            Console.WriteLine("Express Shipment Printed Successfully.");
            Console.WriteLine();

            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("International Shipment Printed Successfully.");
            Console.WriteLine();
            Console.WriteLine("==========================================");

            #endregion

            #region qJ
            Console.WriteLine();
            Console.WriteLine("Updating Weight...");
            Console.WriteLine();
            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            standard.UpdateWeight(5);                 // version 1
            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            standard.UpdateWeight(5, 0.5m);           // version 2 (5 + 0.5 packing)
            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");
            Console.WriteLine();
            Console.WriteLine("==========================================");

            #endregion 
            #region qK
            Console.WriteLine();
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine();

            #endregion












        }

    }
}
