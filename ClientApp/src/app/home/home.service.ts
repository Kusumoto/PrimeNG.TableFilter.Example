import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LazyLoadEvent } from "primeng/api";
import { WebBoard } from "./webboard";
import {GenericResponse} from "./genericResponse";

@Injectable()
export class HomeService {
  constructor(private http: HttpClient) { }

  getWebBoardLarge(payload: LazyLoadEvent) {
    return this.http.post<any>('/home', payload)
      .toPromise()
      .then(res => <GenericResponse<WebBoard[]>>res)
      .then(data => { return data; });
  }
}
