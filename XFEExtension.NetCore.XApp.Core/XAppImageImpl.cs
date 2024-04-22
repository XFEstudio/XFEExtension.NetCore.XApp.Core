using System.Diagnostics.CodeAnalysis;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppImageImpl : XAppImage
{
    [SetsRequiredMembers]
    internal XAppImageImpl(XAppFileType fileType, string fileName, string imageBase64String, ImageType imageType) : base(fileType, fileName, imageBase64String, imageType) { }
    [SetsRequiredMembers]
    internal XAppImageImpl() : this(default, default!, default!, default) { }
}