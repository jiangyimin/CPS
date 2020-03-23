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
import { WorkerCategoryComponent } from './worker-category/worker-category.component';
import { VehicleTypeComponent } from './vehicle-type/vehicle-type.component';
import { ArticleTypeComponent } from './article-type/article-type.component';

const routes: Routes = [
  { path: 'field-input-rule', component: FieldInputRuleComponent, canActivate: [ACLGuard], data: { title: '字段输入规则', reuse: true, guard: 'Root.Admin.Dict.FieldInputRule.Read' } },
  { path: 'route-type', component: RouteTypeComponent, canActivate: [ACLGuard], data: { title: '线路类型', reuse: true, guard: 'Root.Admin.Dict.RouteType.Read' } },
  { path: 'worker-category', component: WorkerCategoryComponent, canActivate: [ACLGuard], data: { title: '人员类别', reuse: true, guard: 'Root.Admin.Dict.WorkerCategory.Read' } },
  { path: 'vehicle-type', component: VehicleTypeComponent, canActivate: [ACLGuard], data: { title: '车辆类型', reuse: true, guard: 'Root.Admin.Dict.VehicleType.Read' } },
  { path: 'article-type', component: ArticleTypeComponent, canActivate: [ACLGuard], data: { title: '物品类型', reuse: true, guard: 'Root.Admin.Dict.ArticleType.Read' } }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DictRoutingModule { }
