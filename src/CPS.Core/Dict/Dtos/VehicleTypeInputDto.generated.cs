// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“VehicleTypeInputDto.cs”的分部类“public partial class VehicleTypeInputDto”}添加属性
// </auto-generated>
//
//  <copyright file="VehicleTypeInputDto.generated.cs">
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
    /// 输入DTO：车辆类型信息
    /// </summary>
    [MapTo(typeof(VehicleType))]
    [Description("车辆类型信息")]
    public partial class VehicleTypeInputDto : IInputDto<int>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public int Id { get; set; }

        /// <summary>
        /// 获取或设置 序号
        /// </summary>
        [DisplayName("序号"), Required]
        public string Cn { get; set; }

        /// <summary>
        /// 获取或设置 名称
        /// </summary>
        [DisplayName("名称"), Required]
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置 载重
        /// </summary>
        [DisplayName("载重")]
        public int Load { get; set; }

        /// <summary>
        /// 获取或设置 容量
        /// </summary>
        [DisplayName("容量")]
        public int Capacity { get; set; }

    }
}
