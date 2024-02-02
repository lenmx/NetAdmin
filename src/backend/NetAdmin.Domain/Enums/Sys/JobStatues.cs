namespace NetAdmin.Domain.Enums.Sys;

/// <summary>
///     计划作业状态
/// </summary>
[Export]
public enum JobStatues
{
    /// <summary>
    ///     空闲
    /// </summary>
    [ResourceDescription<Ln>(nameof(Ln.空闲))]
    Idle = 1

   ,

    /// <summary>
    ///     运行
    /// </summary>
    [ResourceDescription<Ln>(nameof(Ln.运行))]
    Running = 2
}