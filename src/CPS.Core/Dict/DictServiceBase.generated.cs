// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，请在控制器类型 DictService 进行继承重写
// </auto-generated>
//
//  <copyright file="IDictServiceBase.generated.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor>Jiangyimin</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;

using OSharp.Core.Systems;
using OSharp.Data;
using OSharp.Entity;
using OSharp.EventBuses;
using OSharp.Extensions;
using OSharp.Identity;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using CPS.Dict.Dtos;
using CPS.Dict.Entities;


namespace CPS.Dict
{
    /// <summary>
    /// 业务实现基类：字典管理模块
    /// </summary>
    public abstract partial class DictServiceBase : IDictContract
    {
        /// <summary>
        /// 初始化一个<see cref="DictService"/>类型的新实例
        /// </summary>
        protected DictServiceBase(IServiceProvider provider)
        {
            ServiceProvider = provider;
            Logger = provider.GetLogger(GetType());
        }
    
        #region 属性

        /// <summary>
        /// 获取或设置 服务提供者对象
        /// </summary>
        protected IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// 获取或设置 日志对象
        /// </summary>
        protected ILogger Logger { get; }

        /// <summary>
        /// 获取或设置 线路类型信息仓储对象
        /// </summary>
        protected IRepository<RouteType, int> RouteTypeRepository => ServiceProvider.GetService<IRepository<RouteType, int>>();
        
        /// <summary>
        /// 获取或设置 字段输入规则信息仓储对象
        /// </summary>
        protected IRepository<FieldInputRule, int> FieldInputRuleRepository => ServiceProvider.GetService<IRepository<FieldInputRule, int>>();
        
        /// <summary>
        /// 获取或设置 人员类别信息仓储对象
        /// </summary>
        protected IRepository<WorkerCategory, int> WorkerCategoryRepository => ServiceProvider.GetService<IRepository<WorkerCategory, int>>();
        
        /// <summary>
        /// 获取或设置 车辆类型信息仓储对象
        /// </summary>
        protected IRepository<VehicleType, int> VehicleTypeRepository => ServiceProvider.GetService<IRepository<VehicleType, int>>();
        
        /// <summary>
        /// 获取或设置 物品类型信息仓储对象
        /// </summary>
        protected IRepository<ArticleType, int> ArticleTypeRepository => ServiceProvider.GetService<IRepository<ArticleType, int>>();
        
        /// <summary>
        /// 获取 事件总线
        /// </summary>
        protected IEventBus EventBus => ServiceProvider.GetService<IEventBus>();

        /// <summary>
        /// 获取 设置存储对象
        /// </summary>
        protected IKeyValueStore KeyValueStore => ServiceProvider.GetService<IKeyValueStore>();

        #endregion
    }
}