// -----------------------------------------------------------------------
//  <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//  </once-generated>
//
//  <copyright file="dict.routing.ts">
//      
//  </copyright>
//  <site></site>
//  <last-editor></last-editor>
// -----------------------------------------------------------------------

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ACLGuard } from '@delon/acl';
import { FieldInputRuleComponent } from './field-input-rule/field-input-rule.component';
import { RouteTypeComponent } from './route-type/route-type.component';

const routes: Routes = [
  { path: 'field-input-rule', component: FieldInputRuleComponent, canActivate: [ACLGuard], data: { title: '字段输入规则', reuse: true, guard: 'Root.Admin.Dict.FieldInputRule.Read' } },
  { path: 'route-type', component: RouteTypeComponent, canActivate: [ACLGuard], data: { title: '线路类型', reuse: true, guard: 'Root.Admin.Dict.RouteType.Read' } },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DictRoutingModule { }
