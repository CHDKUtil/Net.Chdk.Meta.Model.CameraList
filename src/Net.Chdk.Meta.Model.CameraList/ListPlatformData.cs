using System.Collections.Generic;

namespace Net.Chdk.Meta.Model.CameraList
{
    public sealed class ListPlatformData
    {
        public IDictionary<string, ListRevisionData> Revisions { get; set; }
    }
}
