using System.Text.Json.Serialization;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppCodeImpl : XAppCode
{
    [JsonConstructor]
    internal XAppCodeImpl(XAppFileType fileType, string fileName, string? code) : base(fileType, fileName, code) { }
}