using NetAdmin.Domain.Attributes.DataValidation;
using NetAdmin.Domain.DbMaps.Sys;

namespace NetAdmin.Domain.Dto.Sys.Dic.Content;

/// <summary>
///     请求：创建字典内容
/// </summary>
public record CreateDicContentReq : Sys_DicContent
{
    /// <inheritdoc cref="Sys_DicContent.CatalogId" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [CultureRequired(ErrorMessageResourceType = typeof(Ln), ErrorMessageResourceName = nameof(Ln.字典目录编号))]
    public override long CatalogId { get; init; }

    /// <inheritdoc cref="Sys_DicContent.Key" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [CultureRequired(ErrorMessageResourceType = typeof(Ln), ErrorMessageResourceName = nameof(Ln.键名称))]
    public override string Key { get; init; }

    /// <inheritdoc cref="Sys_DicContent.Value" />
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    [CultureRequired(ErrorMessageResourceType = typeof(Ln), ErrorMessageResourceName = nameof(Ln.键值))]
    public override string Value { get; init; }
}