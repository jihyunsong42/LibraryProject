import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service'
import { TitlesByKeyword } from 'src/app/models/StoredProcedureModels/TitlesByKeyword';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-booklist',
  templateUrl: './booklist.component.html',
  styleUrls: ['./booklist.component.css']
})
export class BooklistComponent implements OnInit {

  books:TitlesByKeyword[];
  constructor(private bookService : BookService) { }
  keywords:string = "";

  ngOnInit() { // 시작 시 getBooks Subscribe해서 지역 변수로 받음


    
    this.bookService.getBooks(this.keywords).subscribe(books => {
      this.books = books;
      console.log(books);
    });
  }

  callfunc(){
    this.bookService.currentKeyword.subscribe(res => {
      this.keywords = res;
    });
    this.bookService.getBooks(this.keywords).subscribe(books => {
      this.books = books;
      console.log(books);
    });
  }

}
