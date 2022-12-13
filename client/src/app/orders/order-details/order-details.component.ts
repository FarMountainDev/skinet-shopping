import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IOrder } from 'src/app/shared/models/order';
import { BreadcrumbService } from 'xng-breadcrumb';
import { OrdersService } from '../orders.service';

// Note: The HTML Template for this component is essentially composed of
//  copies of the 'basket-summary' and 'order-totals' components.  Could be
//  refactored to be more reusable if I need this code again?

@Component({
  selector: 'app-orders-details',
  templateUrl: './order-details.component.html',
  styleUrls: ['./order-details.component.scss']
})
export class OrderDetailsComponent implements OnInit {
  order: IOrder;

  constructor(private orderService: OrdersService, private activatedRoute: ActivatedRoute,
    private bcService: BreadcrumbService) {
      this.bcService.set('@orderDetails', '');
    }

  ngOnInit(): void {
    this.loadOrder();
  }

  loadOrder() {
    this.orderService.getOrder(+this.activatedRoute.snapshot.paramMap.get('id')).subscribe(order =>  {
      this.order = order;
      this.bcService.set('@orderDetails', ('Order ' + order.id + ' - ' + order.status));
    }, error => {
      console.log(error);
    });
  }

}
