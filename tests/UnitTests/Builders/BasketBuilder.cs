﻿using Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate;
using NSubstitute;

namespace Microsoft.eShopWeb.UnitTests.Builders;

public class BasketBuilder
{
    private Basket _basket;
    public string BasketBuyerId => "testbuyerId@test.com";

    public int BasketId => 1;

    public BasketBuilder()
    {
        _basket = WithNoItems();
    }

    public Basket Build()
    {
        return _basket;
    }

    public Basket WithNoItems()
    {
        var basketMock = Substitute.For<Basket>(BasketBuyerId);
        basketMock.Id.Returns(BasketId);

        _basket = basketMock;
        return _basket;
    }

    public Basket WithOneBasketItem()
    {
        var basketMock = Substitute.For<Basket>(BasketBuyerId);
        _basket = basketMock;
        _basket.AddItem(2, 3.40m, 4);
        return _basket;
    }

    public Basket WithBasketItems(int ct)
    {
        var basketMock = Substitute.For<Basket>(BasketBuyerId);
        _basket = basketMock;
        for (int i = 0; i < ct; i++)
        {
            _basket.AddItem(2+i, i + 0.40m, (4 % i) + 1);
        }
        return _basket;
    }
}
