namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="fileContent">文件内容</param>
public abstract class XAppFile(XAppFileType fileType, string fileName, string? fileContent) : IXAppFile
{
    /// <summary>
    /// 文件类型
    /// </summary>
    public XAppFileType FileType { get; set; } = fileType;
    /// <summary>
    /// 文件名
    /// </summary>
    public string FileName { get; set; } = fileName;
    /// <summary>
    /// 文件内容
    /// </summary>
    public string? FileContent { get; set; } = fileContent;
}