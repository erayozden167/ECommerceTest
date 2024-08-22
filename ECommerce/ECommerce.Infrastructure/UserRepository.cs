﻿using ECommerce.Data;
using ECommerce.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure
{
    public class UserRepository
    {
        private readonly UserSellerContext _userSellerContext;
        public UserRepository(UserSellerContext userSellerContext)
        {
            _userSellerContext = userSellerContext;
        }
        public async Task<User?> GetByIdAsync(int id)
        {
            return await _userSellerContext.Users
                .FirstOrDefaultAsync(u => u.UserId == id);
        }
        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _userSellerContext.Users
                .Include(u => u.Seller)
                .FirstOrDefaultAsync(u=> u.Email == email);
        }
        public async Task<bool> AddAsync(User user)
        {
            try
            {
                await _userSellerContext.Users.AddAsync(user);
                await _userSellerContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public async Task<Seller?> GetSellerAsync(int id)
        {
            User? user = await _userSellerContext.Users
                .Include(u => u.Seller).FirstOrDefaultAsync(u => u.UserId == id);
            return user?.Seller;
        }
        public async Task<Seller?> AddSellerAsync(Seller seller)
        {
            User? user = await _userSellerContext.Users.FirstOrDefaultAsync(s => s.UserId == seller.UserId);
            if (user == null || user.Role != "User")
            {
                return null;
            }
            seller.UserId = user.UserId;
            seller.User = user;
            user.Seller = seller;
            _userSellerContext.Users.Update(user);
            await _userSellerContext.SaveChangesAsync();

            return seller;
        }
    }
}
