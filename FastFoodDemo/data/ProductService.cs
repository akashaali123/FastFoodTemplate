﻿using FastFoodDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.data
{
    public class ProductService
    {
        private readonly MedicalStoreEntities _context;

        public ProductService()
        {
            _context = new MedicalStoreEntities();
        }

        public bool AddProduct(ProductModel model)
        {
            try
            {
                tblProduct product = new tblProduct
                {
                    ProductName = model.ProductName,
                    Formula = model.Formula,
                    CategoryId = model.CategoryId,
                    SoldPricePerUnit = model.SoldPricePerUnit,
                    RetailPricePerUnit = model.RetailPricePerUnit,
                    Quantity = model.Quantity,
                    TabletQuantityPerPacket = model.TotalQuantityPerPacket,
                    TotalSoldPrice = model.TotalSoldPrice,
                    TotalPurchasePrice = model.TotalPurchasePrice,
                    TotalTabletStock = model.TotalTabletStock,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };
                _context.tblProducts.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<ProductModel> GetAllProductInfo()
        {
            try
            {
                return _context.tblProducts.Select(x => new ProductModel
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    Formula = x.Formula

                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public tblProduct GetProductById(int id)
        {
            try
            {
                return _context.tblProducts.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<ProductModel> GetProductByCategory(int categoryId)
        {
            try
            {
                return _context.tblProducts.Where(x=>x.CategoryId == categoryId).Select(x => new ProductModel
                {
                    Id = x.Id,
                    ProductName = x.ProductName,
                    Formula = x.Formula

                }).ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
