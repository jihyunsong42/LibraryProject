import { Component, OnInit } from '@angular/core'
import { BookService } from '../../services/book.service'
import { Observable } from 'rxjs';
import { TitlesByKeyword } from '../../models/StoredProcedureModels/TitlesByKeyword';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  keywords:string="";
  books:TitlesByKeyword[];
  route:string="";

  constructor(private bookService: BookService) { }

  loadBookList() {
    var elements = <NodeListOf<HTMLInputElement>> document.getElementsByName("radio");
    for(var i = 0; i < elements.length; i++)
    {
      if(elements[i].checked)
      {
        this.route = elements[i].value;
      }
    }
    console.log(this.bookService.url + this.route + this.keywords);
    
    this.bookService.getBooks(this.route + this.keywords).subscribe(res => { 
      this.books = res;
      this.bookService.streamBooks.next(this.books);
    });
  }

  ngOnInit() {
    this.loadBookList();
  }

  onSubmit() {
    this.loadBookList();
  }

}
