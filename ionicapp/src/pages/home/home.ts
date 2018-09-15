import { Component } from '@angular/core';
import { NavController, NavParams } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  //inputnumber:number;
  shownumber:number;
  constructor(public navCtrl: NavController, public navParams: NavParams, private http: HttpClient) {

  }

  consecutive(){
    this.http.get<number>("localhost:5000/api/Values"+this.navParams.data.inputnumber, {})
    .subscribe(data => {

    });
  }

}
