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
            return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} | {shipment.GetTrackingStatus()}";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus().Contains("has been delivered");
        }
    }
}
