﻿using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class MetlifeDataMap
    {
        public MetlifeDataMap(EntityTypeBuilder<PhoneProgramRequest> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
        }
    }
}
