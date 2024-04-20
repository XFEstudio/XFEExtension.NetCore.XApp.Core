namespace XFEExtension.NetCore.XApp.Core;

/// <summary>
/// XApp的异常
/// </summary>
public class XAppException : Exception
{
	/// <summary>
	/// XApp的异常
	/// </summary>
	public XAppException() { }
	/// <summary>
	/// XApp的异常
	/// </summary>
	/// <param name="message">错误消息</param>
	public XAppException(string message) : base(message) { }
	/// <summary>
	/// XApp的异常
	/// </summary>
	/// <param name="message">错误消息</param>
	/// <param name="inner">内部错误</param>
	public XAppException(string message, Exception inner) : base(message, inner) { }
}