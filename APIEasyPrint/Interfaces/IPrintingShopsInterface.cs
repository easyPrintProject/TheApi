﻿using APIEasyPrint.APIModels;
using APIEasyPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEasyPrint.Interfaces
{
   
    public interface IPrintingShopsInterface
    {
        public PrintingShopApiMode.Response GetPrintingShopDetailes(Guid printerId);
        public Task<PrintingShop> PostPrintingShopDetailes(PrintingShop NewPrintirDetailes);
        public Task<List<PrintingShopApiMode.Response>>GtAllPrintingShops();
        public CourceMaterialApiModel.Response GetCourceMaterialDetailes(Guid CourceId);
        public Task<List<CourceMaterialApiModel.Response>> GetMaterialsByID(Guid printerId);
        public Task<bool> PostNewMaterial(CourceMaterialApiModel.Request request);
       // public Task<> PostServiceDetailes(Guid printerId);

        public ApplicationUser FindApplicationUserByEmail(string userEmail);
        public Task<ApplicationUser> PostOwnerDetailes(ApplicationUser newOwner);
        public PrintingShop GetPrintingShopDetailesByOwnerId(string OwnerId);

    }
}
