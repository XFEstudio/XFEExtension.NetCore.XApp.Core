namespace XFEExtension.NetCore.XApp;

public abstract class XAppResource : XAppFile
{
    protected XAppResource(string? resourceBase64String, string? resourceType)
    {
        ResourceBase64String = resourceBase64String;
        ResourceType = resourceType;
    }

    public string? ResourceBase64String { get; set; }
    public string? ResourceType { get; set; }
}
