using AccountingService.config;
using AccountingService.context;
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
        public static List<Request> FindAllByUser(long userId)
        {
            using var db = new AccountingServiceContext();
            return db.Requests.Where(r => r.UserId == userId).ToList();
        }

        public static List<AccounantRequest> JoinUsersAndRequests()
        {
            using var db = new AccountingServiceContext();
            return db.Requests.OrderBy(r => r.Date).Join(
                db.Users,
                r => r.UserId,
                u => u.Id,
                (r, u) => new AccounantRequest
                {
                    Id = r.Id,
                    UserId = r.UserId,
                    Name = $"{u.Firstname} {u.Lastname} {u.Middlename}",
                    ReferenceType = r.ReferenceType,
                    CopiesCount = r.CopiesCount,
                    Reason = r.Reason,
                    Status = r.Status,
                    Date = r.Date
                }).ToList();
        }

        public static Request? FindByUserIdAndReferenceType(long userId, string referenceType)
        {
            using var db = new AccountingServiceContext();
            return db.Requests
                .OrderBy(r => r.Date)
                .FirstOrDefault(r => r.UserId == userId && r.ReferenceType == referenceType);
        }

        public static void Create(Request request)
        {
            using var db = new AccountingServiceContext();
            db.Requests.Add(request);
            db.SaveChanges();
        }

        public static void Update(Request request)
        {
            using var db = new AccountingServiceContext();
            db.Requests.Update(request);
            db.SaveChanges();
        }
    }
}
