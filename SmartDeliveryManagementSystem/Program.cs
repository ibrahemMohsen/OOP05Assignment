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
            DeliveryAddress address = new DeliveryAddress("Assiut", "Salam", 5);
            Shipment shipment1 = new StandardShipment("SH001", "Laptop", 3, 80m, address);

            Shipment shipment2 = shipment1;
            Shipment shipmentCopy = shipment1.CopyShipment();

            Console.WriteLine($"Original shipment : {shipment1.TrackingCode}");
            Console.WriteLine($"Assigned shipment : {shipment2.TrackingCode}");
            Console.WriteLine($"Same object: {shipment1 == shipment2}");
            Console.WriteLine($"Same object: {shipment1 == shipmentCopy}");

        }


    }
}
