﻿namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp的代码文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="code">代码内容</param>
public abstract class XAppCode(XAppFileType fileType, string fileName, string? code) : XAppFile(fileType, fileName, code)
{
    /// <summary>
    /// 代码内容
    /// </summary>
    public string? Code { get; set; } = code;
    /// <summary>
    /// 从代码中创建
    /// </summary>
    /// <param name="fileType">代码文件类型</param>
    /// <param name="fileName">文件名</param>
    /// <param name="code">代码</param>
    /// <returns></returns>
    public static XAppCode FromCode(XAppFileType fileType, string fileName, string? code) => new XAppCodeImpl(fileType, fileName, code);
}
