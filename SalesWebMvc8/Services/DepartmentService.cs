﻿using Microsoft.EntityFrameworkCore;
using SalesWebMvc8.Data;
using SalesWebMvc8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc8.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc8Context _context;

        public DepartmentService(SalesWebMvc8Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
