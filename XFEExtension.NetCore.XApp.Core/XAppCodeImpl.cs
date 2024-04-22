using System.Diagnostics.CodeAnalysis;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppCodeImpl : XAppCode
{
    [SetsRequiredMembers]
    internal XAppCodeImpl(XAppFileType fileType, string fileName, string? code) : base(fileType, fileName, code) { }
    [SetsRequiredMembers]
    internal XAppCodeImpl() : this(default, default!, default) { }
}