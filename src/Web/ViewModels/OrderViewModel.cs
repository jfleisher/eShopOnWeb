﻿using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.Web.ViewModels;

public class OrderViewModel
{
    private const string DEFAULT_STATUS = "Pending";

    public int OrderNumber { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public decimal Total { get; set; }
    public decimal Tax { get; set; }
    public decimal TotalWithTax { get; set; }
    public string Status => DEFAULT_STATUS;
    public Address? ShippingAddress { get; set; }
}
