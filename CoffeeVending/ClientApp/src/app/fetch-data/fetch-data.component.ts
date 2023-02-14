import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html',
})
export class FetchDataComponent implements OnInit {
  coffees: any;
  ordered : any = false;
  model: any = {
    coffeeId: '',
    suger: 'no',
    milk: false,
    caramelle: false,
    creamer: false,
    decofe: false,
  };

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  ngOnInit(): void {
    this.getCoffees();
  }

  getCoffees (){
    this.http.get(this.baseUrl + 'api/coffeevending').subscribe(
      (result: any) => {
        this.coffees = result;
      },
      (error) => {}
    );
  }

  orderCoffee(id: any) {
    this.model.coffeeId = id;
    this.http.post(this.baseUrl + 'api/coffeevending',this.model).subscribe(
      (result: any) => {
        this.ordered = true;
      },
      (error) => {}
    );
  }
}
