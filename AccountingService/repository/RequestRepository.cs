using AccountingService.config;
using AccountingService.context;
using AccountingService.dto;
using AccountingService.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AccountingService.repository
{
    public static class RequestRepository
    {
        public static List<Request> FindAllByUser(User user)
        {
            using var db = new AccountingServiceContext();
            return db.Requests.Where(r => r.User == user).ToList();
        }

        public static void Create(Request request)
        {
            using var db = new AccountingServiceContext();
            db.Requests.Add(request);
            db.SaveChanges();
        }

        public static void Load()
        {
            using var db = new AccountingServiceContext();
            db.Requests.Load();
        }
    }
}
