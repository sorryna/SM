import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  inputnumber:number;
  shownumber:any;
  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient) {

  }

  consecutive(){
    this.http.get("http://localhost:5001/api/Values/"+this.inputnumber)
    .subscribe(data => {
      this.shownumber = data
    });
  }

}
