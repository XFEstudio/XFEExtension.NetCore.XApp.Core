namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp的文件类型
/// </summary>
public enum XAppFileType
{
    /// <summary>
    /// XApp页面的后端C#代码
    /// </summary>
    XFCS,
    /// <summary>
    /// XApp页面的前端代码
    /// </summary>
    XFML,
    /// <summary>
    /// C#逻辑代码
    /// </summary>
    CS,
    /// <summary>
    /// XApp的图标
    /// </summary>
    Icon,
    /// <summary>
    /// XApp的图片资源
    /// </summary>
    Image,
    /// <summary>
    /// XApp的资源文件
    /// </summary>
    Resource,
}