//------------------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“FieldInputRule.cs”的分部类“public partial class FieldInputRule”}添加属性
// </auto-generated>
//
//  <copyright file="FieldInputRule.generated.cs">
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


namespace CPS.Dict.Entities
{
    /// <summary>
    /// 实体类：字段输入规则信息
    /// </summary>
    [Description("字段输入规则信息")]
    public partial class FieldInputRule : EntityBase<int>, ICreatedTime, IUpdateAudited<int>
    {
        /// <summary>
        /// 获取或设置 实体名称
        /// </summary>
        [DisplayName("实体名称"), Required]
        public string EntityName { get; set; }

        /// <summary>
        /// 获取或设置 字段名称
        /// </summary>
        [DisplayName("字段名称"), Required]
        public string FieldName { get; set; }

        /// <summary>
        /// 获取或设置 正则表达式
        /// </summary>
        [DisplayName("正则表达式"), Required]
        public string Regexp { get; set; }

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

