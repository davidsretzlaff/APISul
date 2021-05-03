import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@ANGULAR/common/http';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }

  andarMenosUtilizado : {};
  ngOnInit() {
    this.getAndarMenosUtilizado();
  }

  getAndarMenosUtilizado() {
    this.http.get('http://localhost:5000/api/Elevator/andarMenosUtilizado').subscribe
    (
      response => {this.andarMenosUtilizado = response; console.log(response);},
      error => {console.log(error);}
    );
  }
}
