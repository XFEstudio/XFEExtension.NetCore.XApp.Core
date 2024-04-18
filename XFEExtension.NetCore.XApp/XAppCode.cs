using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp;

/// <summary>
/// XApp的代码文件
/// </summary>
/// <param name="code"></param>
[CreateImpl]
public abstract class XAppCode(string code): XAppFile
{
    /// <summary>
    /// 代码
    /// </summary>
    public string Code { get; set; } = code;
}
