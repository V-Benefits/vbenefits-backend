﻿using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Repository.IRepositories
{
   public interface ISuccessFactorRepository
    {
        SuccessFactor GetEmpolyeeSuccessFactorObject(int staffId);
        string GetEmpolyeeSuccessFactorBand(int staffId);
    }
}
