namespace XFEExtension.NetCore.XApp;

/// <summary>
/// XApp文件
/// </summary>
public interface IXAppFile
{
    /// <summary>
    /// 文件内容
    /// </summary>
    string? FileContent { get; set; }
    /// <summary>
    /// 文件名
    /// </summary>
    string FileName { get; set; }
    /// <summary>
    /// 文件类型
    /// </summary>
    XAppFileType FileType { get; set; }
}