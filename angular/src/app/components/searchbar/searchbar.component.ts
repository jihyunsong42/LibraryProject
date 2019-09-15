import { Component, OnInit } from '@angular/core'
import { BookService } from '../../services/book.service'
import { EventEmitter } from 'protractor';
import { Observable, BehaviorSubject, Subject } from 'rxjs';
import { TitlesByKeyword } from '../../models/StoredProcedureModels/TitlesByKeyword';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  keywords:string="";
  books:TitlesByKeyword[];

  constructor(private bookService: BookService) { }


  ngOnInit() {
    this.bookService.getBooks("").subscribe(res => { this.books = res; });
    this.bookService.streamBooks.next(this.books);
  }

  onSubmit() {
    this.bookService.getBooks(this.keywords).subscribe(res => { this.books = res; });
    this.bookService.streamBooks.next(this.books);
    console.log(this.books.length);
    //this.books.forEach(res => console.log(res));
  }

}
