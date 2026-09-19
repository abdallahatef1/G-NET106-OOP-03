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










        }

    }
}
