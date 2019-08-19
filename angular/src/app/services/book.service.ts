import { Injectable } from '@angular/core'
import { TitlesByKeyword } from '../models/StoredProcedureModels/TitlesByKeyword'
import { Observable } from 'rxjs'
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { BooklistComponent } from '../components/booklist/booklist.component';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http:HttpClient) { }
  Books:TitlesByKeyword[];
  keywords:string;
  url:string="http://localhost:5000/api/Titles/GetByTitle";
  url2:string="http://localhost:5000/api/Titles/GetByTitle/the"

  getBooks() : Observable<TitlesByKeyword[]>{
    return this.http.get<TitlesByKeyword[]>(this.url);
  }
}
