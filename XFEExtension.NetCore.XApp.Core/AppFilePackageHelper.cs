using System.Text.Json;
using XFEExtension.NetCore.FormatExtension;

namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// App文件打包工具
/// </summary>
public static class AppFilePackageHelper
{
    /// <summary>
    /// 打包文件
    /// </summary>
    /// <param name="appFiles">app文件</param>
    /// <returns></returns>
    public static XFEMultiDictionary Package(AppFileCollection appFiles)
    {
        var appFileDictionary = new XFEMultiDictionary();
        foreach (var codeFile in appFiles.CodeFiles)
            appFileDictionary.Add("Code", JsonSerializer.Serialize(codeFile));
        foreach (var resourceFile in appFiles.ResourceFiles)
            appFileDictionary.Add("Resource", JsonSerializer.Serialize(resourceFile));
        foreach (var imageFile in appFiles.ImageFiles)
            appFileDictionary.Add("Image", JsonSerializer.Serialize(imageFile));
        return appFileDictionary;
    }
    /// <summary>
    /// 解包文件
    /// </summary>
    /// <param name="appFileDictionary">文件字典</param>
    /// <returns></returns>
    public static AppFileCollection UnPackage(XFEMultiDictionary appFileDictionary)
    {
        var appFiles = new AppFileCollection();
        foreach (var appFile in appFileDictionary)
        {
            switch (appFile.Header)
            {
                case "Code":
                    appFiles.Add(JsonSerializer.Deserialize<XAppCodeImpl>(appFile.Content)!);
                    break;
                case "Resource":
                    appFiles.Add(JsonSerializer.Deserialize<XAppResourceImpl>(appFile.Content)!);
                    break;
                case "Image":
                    appFiles.Add(JsonSerializer.Deserialize<XAppImageImpl>(appFile.Content)!);
                    break;
                default:
                    break;
            }
        }
        return appFiles;
    }
}
