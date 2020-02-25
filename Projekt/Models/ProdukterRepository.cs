﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public class PodukterRepository : IProdukterRepository
	{
		private readonly AppDbContext _appDbContext;

		public PodukterRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Produkter> AllProdukter
		{
			get
			{
				return _appDbContext.Produkter.Include(c => c.Category);
			}
		}


		public IEnumerable<Produkter> ProductOfTheWeek
		{
			get
			{
				return _appDbContext.Produkter.Include(c => c.Category).Where(p => p.IsProductOfTheWeek);
			}

		}
	public Produkter GetPieById(int ProduktId)
		{
			return _appDbContext.Produkter.FirstOrDefault(p => p.ProduktId == ProduktId);
		}
	}
}
