import { Component, OnInit } from '@angular/core'
import { BookService } from '../../services/book.service'

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  keywords:string;

  constructor(private bookService: BookService) { }

  ngOnInit() {
    
  }

  onSubmit() {
    this.bookService.url = this.bookService.url + this.keywords;
  }

}
