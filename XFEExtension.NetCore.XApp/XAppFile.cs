﻿using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp;

/// <summary>
/// XApp文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="fileContent">文件内容</param>
[CreateImpl]
public abstract class XAppFile(XAppFileType fileType, string? fileName, string? fileContent)
{
    /// <summary>
    /// 文件类型
    /// </summary>
    public XAppFileType FileType { get; set; } = fileType;
    /// <summary>
    /// 文件名
    /// </summary>
    public string? FileName { get; set; } = fileName;
    /// <summary>
    /// 文件内容
    /// </summary>
    public string? FileContent { get; set; } = fileContent;
}