﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Dto
{
    public class ProductScoreDto
    {
        public Guid ProductId { get; set; }

        public Guid UserId { get; set; }

        public Score Score { get; set; }
    }
}