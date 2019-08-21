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

  keywords:string;
  books:TitlesByKeyword[];
  constructor(private bookService : BookService) { }
  

  ngOnInit() {
    this.bookService.currentKeyword.subscribe(keywords => {
      this.keywords = keywords;
      console.log("'" + this.keywords + "' in booklist");
    });
    this.bookService.getBooks(this.keywords).subscribe(books => {
      this.books = books;
      console.log(books);
    });
  }
  

}
