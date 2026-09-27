using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace SmartDeliveryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //DeliveryAddress address = new DeliveryAddress("Assiut", "Salam", 5);
            //Shipment shipment1 = new StandardShipment("SH001", "Laptop", 3, 80m, address);

            //Shipment shipment2 = shipment1;
            //Shipment shipmentCopy = shipment1.CopyShipment();

            //Console.WriteLine($"Original shipment : {shipment1.TrackingCode}");
            //Console.WriteLine($"Assigned shipment : {shipment2.TrackingCode}");
            //Console.WriteLine($"Same object: {shipment1 == shipment2}");
            //Console.WriteLine($"Same object: {shipment1 == shipmentCopy}");
            #endregion

            #region Question02
            //DeliveryAddress address = new DeliveryAddress("Assiut", "Salam", 5);
            //Shipment shipment1 = new StandardShipment("SH001", "Laptop", 3, 80m, address);
            //Shipment shallowCopy = shipment1.ShallowCopy();
            //Shipment shipment2 = shipment1;

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.City}");

            //Console.WriteLine("====================\n");
            //shallowCopy.Destination.City = "Cairo";

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address : {shallowCopy.Destination.City}");
            //Console.WriteLine($"Same DeliveryAddress Object : " +$"{shipment1.Destination == shallowCopy.Destination}");
            #endregion

            #region Question03
            //DeliveryAddress address = new DeliveryAddress("Cairo", "Salam", 5);
            //Shipment shipment1 = new StandardShipment("SH001", "Laptop", 3, 80m, address);

            //Shipment deepCopy = shipment1.DeepCopy();

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address : {deepCopy.Destination.City}");

            //Console.WriteLine("====================\n");
            //deepCopy.Destination.City = "Giza";

            //Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            //Console.WriteLine($"Copied Shipment Address : {deepCopy.Destination.City}");
            //Console.WriteLine($"Same DeliveryAddress Object : " + $"{shipment1.Destination == deepCopy.Destination}");
            #endregion

            #region Question06
            //// note: I commented out the code so it outputs 0 instead of 3
            //Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            #endregion

        }


    }
}
