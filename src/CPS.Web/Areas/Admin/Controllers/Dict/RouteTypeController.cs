// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//     可以在此类进行继承重写来扩展基类 RouteTypeControllerBase
// </once-generated>
//
//  <copyright file="RouteType.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor></last-editor>
// -----------------------------------------------------------------------

using System;

using OSharp.Filter;

using CPS.Dict;


namespace CPS.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 管理控制器: 线路类型信息
    /// </summary>
    public class RouteTypeController : RouteTypeControllerBase
    {
        /// <summary>
        /// 初始化一个<see cref="RouteTypeController"/>类型的新实例
        /// </summary>
        public RouteTypeController(IDictContract dictContract,
            IFilterService filterService)
            : base(dictContract, filterService)
        { }
    }
}
