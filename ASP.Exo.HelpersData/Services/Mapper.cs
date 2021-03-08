﻿using ASP.Exo.HelpersData.Models;
using G = ASP.Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Exo.HelpersData.Services
{
    public static class Mapper
    {
        public static AspUser ToClient(this G.AspUser entity)
        {
            if (entity is null) return null;
            return new AspUser(
                entity.Id,
                entity.Mail,
                entity.Password,
                entity.LastName,
                entity.FirstName,
                entity.BirthDate,
                entity.RegNational,
                entity.Bio
                );
        }
        public static G.AspUser ToGlobal(this AspUser entity)
        {
            if (entity is null) return null;
            return new G.AspUser() {
                Id = entity.Id,
                Mail = entity.Mail,
                Password = entity.Password,
                LastName = entity.LastName,
                FirstName = entity.FirstName,
                BirthDate = entity.BirthDate,
                RegNational = entity.RegNational,
                Bio = entity.Bio
                };
        }
    }
}