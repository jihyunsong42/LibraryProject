import { Injectable } from '@angular/core'
import { TitlesByKeyword } from '../models/StoredProcedureModels/TitlesByKeyword'
import { Observable, of, BehaviorSubject } from 'rxjs'
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { BooklistComponent } from '../components/booklist/booklist.component';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http:HttpClient) { }
  result : TitlesByKeyword;
  private keywordSource = new BehaviorSubject<string>("");
  currentKeyword = this.keywordSource.asObservable();

  Books:TitlesByKeyword[];
  url:string = "http://localhost:5000/api/Titles/GetByTitle/";
  url2:string;

  getBooks(keywords:string) : Observable<TitlesByKeyword[]>{
    console.log(keywords);
    return this.http.get<TitlesByKeyword[]>("http://localhost:5000/api/Titles/GetByTitle/" + keywords);
  }

  changeKeywords(keywords:string){
    this.keywordSource.next(keywords);
  }
}
