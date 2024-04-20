using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp资源文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="resourceBase64String">资源文件Base64字符串</param>
/// <param name="resourceType">资源文件扩展名</param>
[CreateImpl]
public abstract class XAppResource(XAppFileType fileType, string fileName, string? resourceBase64String, string? resourceType) : XAppFile(fileType, fileName, resourceBase64String)
{
    /// <summary>
    /// 资源文件Base64字符串
    /// </summary>
    public string? ResourceBase64String { get; set; } = resourceBase64String;
    /// <summary>
    /// 资源文件扩展名
    /// </summary>
    public string? ResourceType { get; set; } = resourceType;
    /// <summary>
    /// 从文件中读取资源
    /// </summary>
    /// <param name="xAppFileType">文件类型</param>
    /// <param name="fileName">文件名</param>
    /// <returns></returns>
    public static XAppResource FromFile(XAppFileType xAppFileType, string fileName) => new XAppResourceImpl(xAppFileType, Path.GetFileName(fileName), Convert.ToBase64String(File.ReadAllBytes(fileName)), Path.GetExtension(fileName));
}
