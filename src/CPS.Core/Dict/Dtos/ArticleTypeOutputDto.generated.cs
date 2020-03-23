// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“ArticleTypeOutputDto.cs”的分部类“public partial class ArticleTypeOutputDto”}添加属性
// </auto-generated>
//
//  <copyright file="ArticleTypeOutputDto.generated.cs">
//      
//  </copyright>
//  <site></site>
//  <last-editor>Jiangyimin</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;
using OSharp.Mapping;

using CPS.Dict.Entities;

namespace CPS.Dict.Dtos
{
    /// <summary>
    /// 输入DTO：物品类型信息
    /// </summary>
    [MapFrom(typeof(ArticleType))]
    [Description("物品类型信息")]
    public partial class ArticleTypeOutputDto : IOutputDto
    {
        /// <summary>
        /// 初始化一个<see cref="ArticleTypeOutputDto"/>类型的新实例
        /// </summary>
        public ArticleTypeOutputDto()
        { }

        /// <summary>
        /// 初始化一个<see cref="ArticleTypeOutputDto"/>类型的新实例
        /// </summary>
        public ArticleTypeOutputDto(ArticleType entity)
        {
            Id = entity.Id;
            Cn = entity.Cn;
            Name = entity.Name;
            CreatedTime = entity.CreatedTime;
            LastUpdaterId = entity.LastUpdaterId;
            LastUpdatedTime = entity.LastUpdatedTime;
        }

        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 显示编号
        /// </summary>
        [DisplayName("显示编号")]
        public string Cn { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [DisplayName("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// 获取或设置 更新者
        /// </summary>
        [DisplayName("更新者")]
        public int? LastUpdaterId { get; set; }

        /// <summary>
        /// 获取或设置 更新时间
        /// </summary>
        [DisplayName("更新时间")]
        public DateTime? LastUpdatedTime { get; set; }

    }
}
