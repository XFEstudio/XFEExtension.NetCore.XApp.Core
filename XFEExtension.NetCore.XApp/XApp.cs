using XFEExtension.NetCore.FormatExtension;

namespace XFEExtension.NetCore.XApp;

public class XApp
{
    public XAPPInformation AppInfomation { get; set; }
    public List<XAppFile> AppFiles { get; set; }
    public string Package()
    {
        var appDictionary = new XFEDictionary();
        foreach (var appFile in AppFiles)
        {
            var fileDictionary = new XFEDictionary();
        }
    }
}