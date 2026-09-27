using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDeliveryManagementSystem
{
    abstract partial class Shipment
    {
        // note: I didn't add TrackingStatus and UpdateTrackingStatus() earlier because they weren't clearly defined in the requirements
        abstract public string TrackingStatus { get; set; }
        abstract public string GetTrackingStatus();
        abstract public void UpdateTrackingStatus(string newTrackingStatus);

    }
}
