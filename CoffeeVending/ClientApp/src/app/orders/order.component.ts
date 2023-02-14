import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-order-component',
  templateUrl: './order.component.html'
})
export class OrderComponent  implements OnInit{
  public orders :any = [];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  ngOnInit(): void {
   this.getOrders();
  }

  getOrders(){
      this.http.get(this.baseUrl + 'api/order').subscribe(
        (result: any) => {
          this.orders = result;
        },
        (error) => {}
      );
    
  }
}
