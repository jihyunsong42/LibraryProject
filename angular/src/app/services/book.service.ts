import { Injectable } from '@angular/core'
import { TitlesByKeyword } from '../models/StoredProcedureModels/TitlesByKeyword'
import { Observable, of, BehaviorSubject } from 'rxjs'
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http'
import { BooklistComponent } from '../components/booklist/booklist.component';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http:HttpClient) {
   }

  private keywordSource = new BehaviorSubject<string>("");
  currentKeyword = this.keywordSource.asObservable();

  url:string = "http://localhost:5000/api/Titles/GetByTitle/";
  url2:string = "http://localhost:5000/api/Titles/GetByTitle/";

  // 변경된 url 주소로 http.get 받아오는 함수
  getBooks() : Observable<TitlesByKeyword[]>{ 
    return this.http.get<TitlesByKeyword[]>(this.url2);
  }

  changeURL(keywords:string){ // url 변경 함수 (rxjs로 구현
    this.keywordSource.next(keywords);
    this.currentKeyword.subscribe(keywords =>
    {
      this.url2 = this.url + keywords;
    })
  }
}