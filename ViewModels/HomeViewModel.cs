using System;
using dotnet.Models;

namespace dotnet.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Pie> PiesOfTheWeek{ get; }
        public string? CurrentCategory{ get; }

		public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
		{
			PiesOfTheWeek = piesOfTheWeek;
		}
	}
}

