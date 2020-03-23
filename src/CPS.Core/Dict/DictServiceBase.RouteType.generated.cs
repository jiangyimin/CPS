// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1.横向扩展：如需给当前实体 RouteType 添加方法，可新建文件“DictServiceBase.RouteType.cs”的分部类“public abstract partial class DictServiceBase”添加功能
//      2.纵向扩展：如需要重写当前实体 RouteType 的业务实现，可新建文件“DictService.RouteType.cs”的分部类“public partial class DictService”对现有方法进行方法重写实现
// </auto-generated>
//
//  <copyright file="DictServiceBase.RouteType.generated.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor>Jiangyimin</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using OSharp.Data;
using OSharp.Dependency;
using OSharp.Extensions;
using OSharp.Mapping;

using CPS.Dict.Dtos;
using CPS.Dict.Entities;


namespace CPS.Dict
{
    public abstract partial class DictServiceBase
    {
        /// <summary>
        /// 获取 线路类型信息查询数据集
        /// </summary>
        public IQueryable<RouteType> RouteTypes
        {
            get { return RouteTypeRepository.QueryAsNoTracking(); }
        }

        /// <summary>
        /// 检查线路类型信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的线路类型信息编号</param>
        /// <returns>线路类型信息是否存在</returns>
        public virtual Task<bool> CheckRouteTypeExists(Expression<Func<RouteType, bool>> predicate, int id = default(int))
        {
            return RouteTypeRepository.CheckExistsAsync(predicate, id);
        }
        
        /// <summary>
        /// 添加线路类型信息
        /// </summary>
        /// <param name="dtos">要添加的线路类型信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> CreateRouteTypes(params RouteTypeInputDto[] dtos)
        {
            Check.Validate<RouteTypeInputDto, int>(dtos, nameof(dtos));
            return RouteTypeRepository.InsertAsync(dtos);
        }
        
        /// <summary>
        /// 更新线路类型信息
        /// </summary>
        /// <param name="dtos">包含更新信息的线路类型信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> UpdateRouteTypes(params RouteTypeInputDto[] dtos)
        {
            Check.Validate<RouteTypeInputDto, int>(dtos, nameof(dtos));
            return RouteTypeRepository.UpdateAsync(dtos);
        }
        
        /// <summary>
        /// 删除线路类型信息
        /// </summary>
        /// <param name="ids">要删除的线路类型信息编号</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> DeleteRouteTypes(params int[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            return RouteTypeRepository.DeleteAsync(ids);
        }
    }
}