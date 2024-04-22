using System.Text.Json.Serialization;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppResourceImpl : XAppResource
{
    [JsonConstructor]
    internal XAppResourceImpl(XAppFileType fileType, string fileName, string? resourceBase64String, string? resourceType) : base(fileType, fileName, resourceBase64String, resourceType) { }
}
