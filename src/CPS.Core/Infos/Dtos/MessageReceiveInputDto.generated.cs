// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类：可遵守如下规则进行扩展：
//      1.横向扩展：如需添加额外的属性，可新建文件“MessageReceiveInputDto.cs”的分部类“public partial class MessageReceiveInputDto”}添加属性
// </auto-generated>
//
//  <copyright file="MessageReceiveInputDto.generated.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 Liuliu. All rights reserved.
//  </copyright>
//  <site>https://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using OSharp.Entity;
using OSharp.Mapping;

using CPS.Infos.Entities;


namespace CPS.Infos.Dtos
{
    /// <summary>
    /// 输入DTO：站内信接收记录信息
    /// </summary>
    [MapTo(typeof(MessageReceive))]
    [Description("站内信接收记录信息")]
    public partial class MessageReceiveInputDto : IInputDto<Guid>
    {
        /// <summary>
        /// 获取或设置 编号
        /// </summary>
        [DisplayName("编号")]
        public Guid Id { get; set; }

    }
}
