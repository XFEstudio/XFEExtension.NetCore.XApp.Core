using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp;

/// <summary>
/// XApp的代码文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="code">代码内容</param>
[CreateImpl]
public abstract class XAppCode(XAppFileType fileType, string fileName, string? code) : XAppFile(fileType, fileName, code)
{
    /// <summary>
    /// 代码内容
    /// </summary>
    public string? Code { get; set; } = code;
}
