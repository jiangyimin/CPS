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
import { RouteTypeComponent } from './route-type/route-type.component';

const routes: Routes = [
  { path: 'route-type', component: RouteTypeComponent, canActivate: [ACLGuard], data: { title: '线路类型管理', reuse: true, guard: 'Root.Admin.Dict.RouteType.Read' } },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DictRoutingModule { }
