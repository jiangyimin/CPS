// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//     可以在此类进行继承重写来扩展基类 FieldInputRuleControllerBase
// </once-generated>
//
//  <copyright file="FieldInputRule.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor>Jiangyimin</last-editor>
// -----------------------------------------------------------------------

using System;

using OSharp.Filter;

using CPS.Dict;


namespace CPS.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 管理控制器: 字段输入规则信息
    /// </summary>
    public class FieldInputRuleController : FieldInputRuleControllerBase
    {
        /// <summary>
        /// 初始化一个<see cref="FieldInputRuleController"/>类型的新实例
        /// </summary>
        public FieldInputRuleController(IDictContract dictContract,
            IFilterService filterService)
            : base(dictContract, filterService)
        { }
    }
}
