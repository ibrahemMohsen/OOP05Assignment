using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SmartDeliveryManagementSystem
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = shipment switch
            {
                StandardShipment => "Standard",
                ExpressShipment => "Express",
                InternationalShipment => "International",
                _ => "Shipment"
            };
            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} | {shipment.TrackingStatus}";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
