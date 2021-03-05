import { Component, OnInit } from '@angular/core';
import { LazyLoadEvent } from "primeng/api";
import { WebBoard } from "./webboard";
import { HomeService } from "./home.service";
import { Table } from 'primeng/table';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  datasource: WebBoard[];
  totalRecords: number;
  loading: boolean;

  constructor(private homeService: HomeService) {
  }

  async ngOnInit(): Promise<void> {
  }

  async onLoadWebBoard(event: LazyLoadEvent) {
    this.loading = true;
    const result = await this.homeService.getWebBoardLarge(event);
    this.datasource = result.data;
    this.totalRecords = result.total;
    this.loading = false;
  }

  clear(table: Table) {
    table.clear();
  }
}
