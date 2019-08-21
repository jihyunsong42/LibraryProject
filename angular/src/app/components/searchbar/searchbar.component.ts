import { Component, OnInit } from '@angular/core'
import { BookService } from '../../services/book.service'

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  constructor(private bookService: BookService) { }

  keywords:string="the";

  ngOnInit() {
    //this.bookService.currentKeyword.subscribe(keyword => )
  }

  onSubmit() {
    console.log("submitted");
    this.bookService.changeKeywords(this.keywords);
  }

}
