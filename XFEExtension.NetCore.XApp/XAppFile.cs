using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp;

[CreateImpl]
public abstract class XAppFile
{
    public XAppFileType FileType { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public string FileContent { get; set; }
}