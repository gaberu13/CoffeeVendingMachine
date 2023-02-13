import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public coffees: any ;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get(baseUrl + 'coffeevending').subscribe(result => {
      this.coffees = result;
    }, error => console.error(error));
  }
}

interface Coffee {
  name: string;
  description: string;
  price: number;
  country: string;
  image: string;
}
