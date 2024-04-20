using System.Collections;
using System.Text.Json;

namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// App文件集合
/// </summary>
public class AppFileCollection : IList<XAppFile>
{
    private List<XAppFile> appFiles = [];
    /// <summary>
    /// 代码文件
    /// </summary>
    public XAppCode[] CodeFiles { get => appFiles.OfType<XAppCode>().ToArray(); }
    /// <summary>
    /// 资源文件
    /// </summary>
    public XAppResource[] ResourceFiles { get => appFiles.OfType<XAppResource>().ToArray(); }
    /// <summary>
    /// 图片文件
    /// </summary>
    public XAppImage[] ImageFiles { get => appFiles.OfType<XAppImage>().ToArray(); }
    /// <summary>
    /// 索引器
    /// </summary>
    /// <param name="index">索引</param>
    /// <returns></returns>
    public XAppFile this[int index] { get => ((IList<XAppFile>)appFiles)[index]; set => ((IList<XAppFile>)appFiles)[index] = value; }
    /// <summary>
    /// 数量
    /// </summary>
    public int Count => ((ICollection<XAppFile>)appFiles).Count;
    /// <summary>
    /// 是否只读
    /// </summary>
    public bool IsReadOnly => ((ICollection<XAppFile>)appFiles).IsReadOnly;
    /// <summary>
    /// 添加文件
    /// </summary>
    /// <param name="item">文件</param>
    public void Add(XAppFile item)
    {
        ((ICollection<XAppFile>)appFiles).Add(item);
    }
    /// <summary>
    /// 清空
    /// </summary>
    public void Clear()
    {
        ((ICollection<XAppFile>)appFiles).Clear();
    }
    /// <summary>
    /// 是否包含
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Contains(XAppFile item)
    {
        return ((ICollection<XAppFile>)appFiles).Contains(item);
    }
    /// <summary>
    /// 复制到
    /// </summary>
    /// <param name="array">数组</param>
    /// <param name="arrayIndex">起始索引</param>
    public void CopyTo(XAppFile[] array, int arrayIndex)
    {
        ((ICollection<XAppFile>)appFiles).CopyTo(array, arrayIndex);
    }
    /// <summary>
    /// 获取枚举器
    /// </summary>
    /// <returns></returns>
    public IEnumerator<XAppFile> GetEnumerator()
    {
        return ((IEnumerable<XAppFile>)appFiles).GetEnumerator();
    }
    /// <summary>
    /// 获取指定文件索引
    /// </summary>
    /// <param name="item">文件</param>
    /// <returns></returns>
    public int IndexOf(XAppFile item)
    {
        return ((IList<XAppFile>)appFiles).IndexOf(item);
    }
    /// <summary>
    /// 插入
    /// </summary>
    /// <param name="index">索引</param>
    /// <param name="item">文件</param>
    public void Insert(int index, XAppFile item)
    {
        ((IList<XAppFile>)appFiles).Insert(index, item);
    }
    /// <summary>
    /// 打包
    /// </summary>
    /// <returns></returns>
    public string Package() => JsonSerializer.Serialize(appFiles);
    /// <summary>
    /// 从Json创建对象
    /// </summary>
    /// <param name="json">json字符串</param>
    /// <returns></returns>
    public static AppFileCollection? FromJson(string json)
    {
        var appFileCollection = new AppFileCollection();
        var appFileList = JsonSerializer.Deserialize<List<XAppFile>>(json);
        if (appFileList is null)
        {
            return null;
        }
        else
        {
            appFileCollection.appFiles = appFileList;
            return appFileCollection;
        }
    }
    /// <summary>
    /// 移除指定文件
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Remove(XAppFile item)
    {
        return ((ICollection<XAppFile>)appFiles).Remove(item);
    }
    /// <summary>
    /// 移除指定索引的文件
    /// </summary>
    /// <param name="index">索引</param>
    public void RemoveAt(int index)
    {
        ((IList<XAppFile>)appFiles).RemoveAt(index);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)appFiles).GetEnumerator();
    }
}
