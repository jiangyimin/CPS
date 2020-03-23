// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“FieldInputRuleInputDto.cs”的分部类“public partial class FieldInputRuleInputDto”}添加属性
// </auto-generated>
//
//  <copyright file="FieldInputRuleInputDto.generated.cs">
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
    /// 输入DTO：字段输入规则信息
    /// </summary>
    [MapTo(typeof(FieldInputRule))]
    [Description("字段输入规则信息")]
    public partial class FieldInputRuleInputDto : IInputDto<int>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }

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

    }
}