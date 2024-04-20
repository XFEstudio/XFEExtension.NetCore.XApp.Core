using XFEExtension.NetCore.FormatExtension;

namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp类
/// </summary>
public class XApp
{
    /// <summary>
    /// XApp的信息
    /// </summary>
    public required XAPPInformation AppInformation { get; set; }
    /// <summary>
    /// XApp的文件集合
    /// </summary>
    public AppFileCollection AppFiles { get; set; } = [];
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
                    { "AppName", AppInformation.AppName },
                    { "AppVersion", AppInformation.AppVersion.ToString() },
                    { "AppDescription", AppInformation.AppDescription },
                    { "Author", AppInformation.Author },
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
        return appDictionary;
    }
    /// <summary>
    /// 从字典中解包为XApp
    /// </summary>
    /// <param name="appDictionary">字典对象或字符串</param>
    /// <returns></returns>
    public static XApp UnPackage(XFEDictionary appDictionary)
    {
        XFEDictionary appInformation = appDictionary["AppInformation"]!;
        return new XApp
        {
            AppInformation = new XAPPInformation(appInformation["AppIcon"]!.ToString(),
                                                 appInformation["AppName"]!.ToString(),
                                                 Version.Parse(appInformation["AppVersion"]!.ToString()),
                                                 appInformation["AppDescription"]!.ToString(),
                                                 appInformation["Author"]!.ToString(),
                                                 appInformation["Company"]!.ToString(),
                                                 appInformation["AuthorEmail"]!.ToString(),
                                                 appInformation["ProjectWebSite"]!.ToString(),
                                                 appInformation["ProjectGitHub"]!.ToString()),
            AppFiles = AppFileCollection.FromJson(appDictionary["AppFiles"]!) ?? []
        };
    }
}