﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
	public interface IProdukterRepository
	{
		IEnumerable<Produkter> AllProdukter { get; }
		IEnumerable<Produkter> ProductOfTheWeek { get; }
		Produkter GetPieById(int pieId);
	}
}
