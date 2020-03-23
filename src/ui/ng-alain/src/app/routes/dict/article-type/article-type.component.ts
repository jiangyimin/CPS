// ------------------------------------------------------------------------------
//  <once-generated>
//     这个文件只生成一次，再次生成不会被覆盖。
//  </once-generated>
//
//  <copyright file="article-type.module.ts">
//      
//  </copyright>
//  <site></site>
//  <last-editor>Jiangyimin</last-editor>
// -----------------------------------------------------------------------

import { Component, OnInit, Injector } from '@angular/core';
import { SFUISchema, SFSchema } from '@delon/form';
import { OsharpSTColumn } from '@shared/osharp/services/alain.types';
import { STComponentBase } from '@shared/osharp/components/st-component-base';

@Component({
  selector: 'app-article-type',
  templateUrl: './article-type.component.html',
  styles: []
})
export class ArticleTypeComponent extends STComponentBase implements OnInit {

  constructor(injector: Injector) {
    super(injector);
    this.moduleName = 'articleType';
  }

  ngOnInit() {
    super.InitBase();
  }

  protected GetSTColumns(): OsharpSTColumn[] {
    let columns: OsharpSTColumn[] = [
      {
        title: '操作', fixed: 'left', width: 65, buttons: [{
          text: '操作', children: [
            { text: '编辑', icon: 'edit', acl: 'Root.Admin.Dict.ArticleType.Update', click: row => this.edit(row) },
            { text: '删除', icon: 'delete', type: 'del', acl: 'Root.Admin.Dict.ArticleType.Delete', click: row => this.delete(row) },
          ]
        }]
      },
      { title: '编号', index: 'Id', sort: true, readOnly: true, editable: true, filterable: true, ftype: 'number' },
      { title: '显示编号', index: 'Cn', sort: true, editable: true, ftype: 'string' },
      { title: '名称', index: 'Name', editable: true, ftype: 'string' },
      { title: '创建时间', index: 'CreatedTime', sort: true, filterable: true, type: 'date' },
      { title: '更新者', index: 'LastUpdaterId', type: 'number' },
      { title: '更新时间', index: 'LastUpdatedTime', type: 'date' },
    ];
    return columns;
  }

  protected GetSFSchema(): SFSchema {
    let schema: SFSchema = {
      properties: this.ColumnsToSchemas(this.columns),
      required: ['Cn', 'Name']
    };
    return schema;
  }

  protected GetSFUISchema(): SFUISchema {
    let ui: SFUISchema = {
      '*': { spanLabelFixed: 100, grid: { span: 12 } },
      $Cn: { grid: { span: 24 } },
      $Name: { grid: { span: 24 } }
    };
    return ui;
  }
}

