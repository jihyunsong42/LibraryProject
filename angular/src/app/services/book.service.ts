import { Injectable } from '@angular/core'
import { TitlesByKeyword } from '../models/StoredProcedureModels/TitlesByKeyword'
import { Subject, Observable, of, BehaviorSubject } from 'rxjs'
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http:HttpClient) {
  }
  streamBooks = new Subject<TitlesByKeyword[]>();
  receiveBooks = this.streamBooks.asObservable();

  url:string = "http://localhost:5000/api/Titles/GetByTitle/";
  

  //$books:Observable<TitlesByKeyword[]>;

  // 변경된 url 주소로 http.get 받아오는 함수
  getBooks(keywords:string) : Observable<TitlesByKeyword[]>{
    return this.http.get<TitlesByKeyword[]>(this.url + keywords);
  }

}