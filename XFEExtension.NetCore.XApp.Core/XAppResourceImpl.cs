using System.Diagnostics.CodeAnalysis;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppResourceImpl : XAppResource
{
    [SetsRequiredMembers]
    internal XAppResourceImpl(XAppFileType fileType, string fileName, string? resourceBase64String, string? resourceType) : base(fileType, fileName, resourceBase64String, resourceType) { }
    [SetsRequiredMembers]
    internal XAppResourceImpl() : this(default, default!, default, default) { }
}
