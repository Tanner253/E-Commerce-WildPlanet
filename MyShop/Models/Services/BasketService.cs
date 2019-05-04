﻿using MyShop.data;
using MyShop.Models.Interfaces;
using MyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace MyShop.Models.Services
{
    public class BasketService : IBasketManager

    {
        private MyShopDbContext _context;
        private ApplicationDbContext _appcontext;

        public BasketService(MyShopDbContext context, ApplicationDbContext appcontext)
        {
            _context = context;
            _appcontext = appcontext;
        }
        public async Task AddBasketItem(int productID, string username)
        {
            try
            {
                Basket basket = await _context.Basket
                                         .FirstOrDefaultAsync(x => x.UserName == username);

                Product product = await _context.Product
                                         .FirstOrDefaultAsync(x => x.ID == productID);

                BasketItems basketItem = new BasketItems()
                {
                    
                    BasketID = basket.ID,
                    ProductID = product.ID,
                    Product = product,
                    Quantity = 1,
                    LineItemAmount = product.Price

                   
                };
                basket.BasketList.Add(basketItem);
                _context.Basket.Add(basket);
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool BasketExists(int id)
        {
            try
            {
                return _context.BasketItems.Any(e => e.ID == id);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }

        public async Task<IEnumerable<BasketItems>> GetAllItems()
        {
            try
            {
                return await _context.BasketItems.ToListAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task UpdateBasketItem(int id, [Bind("ID,BasketID,ProductID,Product,Quantity,LineItemAmount")]BasketItems basketItems)
        { 
            try
            {
                _context.Update(basketItems);
                await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);

            }
        }

        public async Task<BasketItems> RemoveBasketItem(int basketID)
        {
            try
            {
                BasketItems basketitem = await _context.BasketItems
                                            .FirstOrDefaultAsync(x => x.ID == basketID);
                return basketitem;
        
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        public async Task RemoveBasketItemFR(int basketID)
        {
            try
            {
                var item = await _context.BasketItems.FindAsync(basketID);
                _context.BasketItems.Remove(item);
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
