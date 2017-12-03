﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.Api.Models
{
    public class RootResource : Resource
    {
		public Link Artists
		{
			get; set;
		}

		public Link Albums
		{
			get; set;
		}
	}
}