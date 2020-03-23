// -----------------------------------------------------------------------
//  <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//  </once-generated>
//
//  <copyright file="dict.module.ts">
//      
//  </copyright>
//  <site></site>
//  <last-editor></last-editor>
// -----------------------------------------------------------------------

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '@shared';
import { DictRoutingModule } from './dict.routing';
import { FieldInputRuleComponent } from './field-input-rule/field-input-rule.component';
import { RouteTypeComponent } from './route-type/route-type.component';

@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    DictRoutingModule
  ],
  declarations: [
    FieldInputRuleComponent,
    RouteTypeComponent,
  ]
})
export class DictModule { }
