namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp程序信息
/// </summary>
/// <param name="appIcon">app图标的Base64字符串</param>
/// <param name="appId">应用的ID</param>
/// <param name="appName">应用名称</param>
/// <param name="appVersion">应用版本</param>
/// <param name="appDescription">描述</param>
/// <param name="author">作者</param>
/// <param name="company">公司</param>
/// <param name="authorMail">作者电子邮件</param>
/// <param name="projectWebSite">项目网站</param>
/// <param name="projectGitHub">项目源码</param>
public class XAPPInformation(string appIcon, string appId, string appName, Version appVersion, string appDescription, string author, string company, string authorMail, string projectWebSite, string projectGitHub)
{
    /// <summary>
    /// 应用图标的Base64字符串
    /// </summary>
    public string AppIcon { get; init; } = appIcon;
    /// <summary>
    /// 应用的ID
    /// </summary>
    public string AppID { get; set; } = appId;
    /// <summary>
    /// 应用名称
    /// </summary>
    public string AppName { get; init; } = appName;
    /// <summary>
    /// 应用版本
    /// </summary>
    public Version AppVersion { get; init; } = appVersion;
    /// <summary>
    /// 应用描述
    /// </summary>
    public string AppDescription { get; init; } = appDescription;
    /// <summary>
    /// 作者
    /// </summary>
    public string Author { get; init; } = author;
    /// <summary>
    /// 公司
    /// </summary>
    public string Company { get; init; } = company;
    /// <summary>
    /// 作者电子邮件
    /// </summary>
    public string AuthorMail { get; init; } = authorMail;
    /// <summary>
    /// 项目网站
    /// </summary>
    public string ProjectWebSite { get; init; } = projectWebSite;
    /// <summary>
    /// 项目源码
    /// </summary>
    public string ProjectGitHub { get; init; } = projectGitHub;
}

