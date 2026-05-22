using AccountingService.config;
using AccountingService.context;
using AccountingService.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingService.repository
{
    public static class UserRepository
    {
        public static User? FindByLogin(string login)
        {
            using var db = new AccountingServiceContext();
            return db.Users.FirstOrDefault(u => u.Login == login);
        }
    }
}
