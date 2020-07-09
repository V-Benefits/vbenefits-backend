﻿using Benefits_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Repository.IRepositories
{
   public interface IPensionAdminRepository
    {
        void UpdatePensionUserInterface(RoundDate firstRound , RoundDate secondRound, string pensionPolicyURL , string pensionPolicyFilePath);
    }
}
