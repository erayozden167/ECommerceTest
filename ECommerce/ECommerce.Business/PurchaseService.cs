﻿using ECommerce.Domain;
using ECommerce.DTOs;
using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business
{
    public class PurchaseService
    {
        //private readonly IPurchaseRepository _purchaseRepository;
        //public PurchaseService(IPurchaseRepository purchaseRepository)
        //{
        //    _purchaseRepository = purchaseRepository;
        //}
        //public async Task<bool> PurchaseAddAsync(PurchaseDto request)
        //{
        //    Purchase purchase = new Purchase
        //    {
        //        UserId = request.UserId,
        //        ProductId = request.ProductId,
        //        Quantity = request.Quantity,
        //        PurchaseDate = DateTime.Now
        //    };
        //    bool response = await _purchaseRepository.(purchase);
        //    if (!response)
        //    {
        //        return false;
        //    }

        //    return true;
        //}

        //public async Task<PurchaseDto> GetPurchaseAsync(int id)
        //{

        //    Purchase response = await _purchaseRepository.GetPurchaseAsync(id);

        //    if (response == null)
        //    {
        //        return new PurchaseDto();
        //    }
        //    return new PurchaseDto()
        //    {
        //        PurchaseId = response.PurchaseId,
        //        Quantity = response.Quantity,
        //        ProductId = response.ProductId
        //    };
        //}
    }
}
