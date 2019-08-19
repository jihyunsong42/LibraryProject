import { Component, OnInit } from '@angular/core';
import { BookService } from '../../services/book.service'
import { TitlesByKeyword } from 'src/app/models/StoredProcedureModels/TitlesByKeyword';

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
    
    this.bookService.getBooks().subscribe(books => {
      this.books = books;
      console.log(books);
    })
  }

}
