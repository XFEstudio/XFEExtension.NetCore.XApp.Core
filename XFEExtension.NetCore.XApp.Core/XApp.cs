﻿using XFEExtension.NetCore.FormatExtension;

namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp类
/// </summary>
public class XApp
{
    /// <summary>
    /// 应用名称
    /// </summary>
    public string Name { get => AppInformation.AppName; }
    /// <summary>
    /// 应用ID
    /// </summary>
    public string ID { get => AppInformation.AppID; }
    /// <summary>
    /// 作者的UID
    /// </summary>
    public string AuthorUID { get => AppInformation.AuthorUID; }
    /// <summary>
    /// XApp的信息
    /// </summary>
    public required XAppInformation AppInformation { get; set; }
    /// <summary>
    /// XApp的文件集合
    /// </summary>
    public AppFileCollection AppFiles { get; set; } = [];
    /// <summary>
    /// 程序集字符
    /// </summary>
    public byte[]? AssemblyBytes { get; set; }
    /// <summary>
    /// 打包为完整的XApp字典
    /// </summary>
    /// <returns></returns>
    public XFEDictionary Package()
    {
        var appDictionary = new XFEDictionary
        {
            {
                "AppInformation", new XFEDictionary
                {
                    { "AppIcon", AppInformation.AppIcon },
                    { "AppId", AppInformation.AppID },
                    { "AppName", AppInformation.AppName },
                    { "AppVersion", AppInformation.AppVersion.ToString() },
                    { "AppDescription", AppInformation.AppDescription },
                    { "Author", AppInformation.Author },
                    { "AuthorUID", AppInformation.AuthorUID },
                    { "Company", AppInformation.Company },
                    { "AuthorEmail", AppInformation.AuthorMail },
                    { "ProjectWebSite", AppInformation.ProjectWebSite },
                    { "ProjectGitHub", AppInformation.ProjectGitHub }
                }
            },
            {
                "AppFiles", AppFiles.Package()
            }
        };
        if (AssemblyBytes is not null)
            appDictionary.Add("Assembly", Convert.ToBase64String(AssemblyBytes));
        return appDictionary;
    }
    /// <summary>
    /// 从字典中加载App文件
    /// </summary>
    /// <param name="fileDictionary">文件字典</param>
    public void LoadFiles(XFEMultiDictionary fileDictionary) => AppFiles = AppFileCollection.UnPackage(fileDictionary)!;
    /// <summary>
    /// 从字典中解包为XApp
    /// </summary>
    /// <param name="appDictionary">字典对象或字符串</param>
    /// <returns></returns>
    public static XApp UnPackage(XFEDictionary appDictionary)
    {
        XFEDictionary appInformation = appDictionary["AppInformation"]!;
        var assemblyBase64String = appDictionary["Assembly"];
        return new XApp
        {
            AppInformation = XAppInformation.UnPackage(appInformation),
            AppFiles = AppFileCollection.UnPackage(appDictionary["AppFiles"]!) ?? [],
            AssemblyBytes = assemblyBase64String is not null ? Convert.FromBase64String(assemblyBase64String) : null
        };
    }
}