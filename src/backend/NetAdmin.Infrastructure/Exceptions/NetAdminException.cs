namespace NetAdmin.Infrastructure.Exceptions;

/// <summary>
///     NetAdmin异常基类
/// </summary>
#pragma warning disable RCS1194
public abstract class NetAdminException : Exception
#pragma warning restore RCS1194
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="NetAdminException" /> class.
    /// </summary>
    protected NetAdminException() { }

    /// <summary>
    ///     Initializes a new instance of the <see cref="NetAdminException" /> class.
    /// </summary>
    protected NetAdminException(ErrorCodes code, string message = null, Exception innerException = null) //
        : this(message, innerException)
    {
        Code = code;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="NetAdminException" /> class.
    /// </summary>
    protected NetAdminException(string message, Exception innerException) //
        : base(message, innerException) { }

    /// <summary>
    ///     错误码
    /// </summary>
    public ErrorCodes Code { get; set; }
}