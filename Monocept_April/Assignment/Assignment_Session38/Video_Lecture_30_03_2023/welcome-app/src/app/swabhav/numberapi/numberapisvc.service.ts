import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { INumberApiResponse } from './number.api.response';
import { map, Observable } from 'rxjs';

@Injectable()

export class NumberapisvcService {

  constructor(private http: HttpClient) {

  }
  getFactFor(no: number): Observable<INumberApiResponse> {
    console.log("Inside getFact",+no)
    return this.http.get(`http://numberapi.com/${no}?json`)
      .pipe(map(resp => {
        console.log("Inside Pipe & Map")
        return <INumberApiResponse>resp
      }))
  }
}
