using XFEExtension.NetCore.ImplExtension;

namespace XFEExtension.NetCore.XApp;

/// <summary>
/// XApp图片文件
/// </summary>
/// <param name="fileType">文件类型</param>
/// <param name="fileName">文件名</param>
/// <param name="imageBase64String">图片Base64字符串</param>
/// <param name="imageType">图片类型</param>
[CreateImpl]
public abstract class XAppImage(XAppFileType fileType, string? fileName, string imageBase64String, ImageType imageType) : XAppFile(fileType, fileName, imageBase64String)
{
    /// <summary>
    /// 图片Base64字符串
    /// </summary>
    public string ImageBase64String { get; set; } = imageBase64String;
    /// <summary>
    /// 图片类型
    /// </summary>
    public ImageType ImageType { get; set; } = imageType;
    /// <summary>
    /// 从图片中读取
    /// </summary>
    /// <param name="xAppFileType">文件类型</param>
    /// <param name="fileName">文件名</param>
    /// <returns></returns>
    public static XAppImage FromImage(XAppFileType xAppFileType, string fileName) => new XAppImageImpl(xAppFileType, fileName, Convert.ToBase64String(File.ReadAllBytes(fileName)), GetImageType(Path.GetExtension(fileName)));
    /// <summary>
    /// 获取图片类型
    /// </summary>
    /// <param name="extension">文件扩展名</param>
    /// <returns></returns>
    /// <exception cref="XAppException"></exception>
    public static ImageType GetImageType(string extension) => extension.ToLower() switch
    {
        ".png" => ImageType.Png,
        ".jpg" => ImageType.Jpg,
        ".jpeg" => ImageType.Jpeg,
        ".bmp" => ImageType.Bmp,
        ".gif" => ImageType.Gif,
        _ => throw new XAppException("不支持的图片格式")
    };
}