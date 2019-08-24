import { Component, OnInit } from '@angular/core'
import { BookService } from '../../services/book.service'

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.css']
})
export class SearchbarComponent implements OnInit {

  constructor(private bookService: BookService) { }

  keywords:string;

  ngOnInit() {
  }

  onSubmit() { // 버튼 클릭 시 url 변경
    console.log("submitted");
    this.bookService.changeURL(this.keywords);
  }

}
