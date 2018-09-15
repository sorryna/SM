import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  inputnumber:string;
  shownumber:string;
  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient) {

  }

  consecutive(){
    this.http.get<string>("/api/Item/GetItem/", {})
    .subscribe(data => {

    });
  }

}
