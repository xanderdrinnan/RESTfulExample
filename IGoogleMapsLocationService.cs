

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static RESTfulExample.Location;

namespace RESTfulExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGoogleMapsLocationService" in both code and config file together.
    [ServiceContract]
    public interface IGoogleMapsLocationService
    {
        [OperationContract]
        LocationInfo locationReturn(string locationName);
    }
}
