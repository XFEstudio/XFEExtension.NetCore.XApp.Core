using System.Text.Json.Serialization;

namespace XFEExtension.NetCore.XApp.Core;

internal class XAppImageImpl : XAppImage
{
    [JsonConstructor]
    internal XAppImageImpl(XAppFileType fileType, string fileName, string imageBase64String, ImageType imageType) : base(fileType, fileName, imageBase64String, imageType) { }
}