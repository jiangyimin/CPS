// -----------------------------------------------------------------------
//  <copyright file="FunctionAuthorizationPack.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2020 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2020-02-27 0:29</last-date>
// -----------------------------------------------------------------------

using CPS.Authorization.Dtos;
using CPS.Authorization.Entities;

using OSharp.Authorization;
using OSharp.Authorization.Dtos;
using OSharp.Authorization.Functions;


namespace CPS.Authorization
{
    public class FunctionAuthorizationPack
        : FunctionAuthorizationPackBase<FunctionAuthManager, FunctionAuthorization, FunctionAuthCache, ModuleHandler, Function,
            FunctionInputDto, Module, ModuleInputDto, int, ModuleFunction, ModuleRole, ModuleUser, int, int>
    { }
}