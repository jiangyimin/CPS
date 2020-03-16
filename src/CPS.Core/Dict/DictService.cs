// -----------------------------------------------------------------------
// <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//     可以在此类进行继承重写来扩展基类 DictServiceBase
// </once-generated>
//
//  <copyright file="IDictService.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor></last-editor>
// -----------------------------------------------------------------------

using System;


namespace CPS.Dict
{
    /// <summary>
    /// 业务实现基类：字典管理模块
    /// </summary>
    public partial class DictService : DictServiceBase
    {
        /// <summary>
        /// 初始化一个<see cref="DictService"/>类型的新实例
        /// </summary>
        public DictService(IServiceProvider provider)
            : base(provider)
        { }
    }
}
