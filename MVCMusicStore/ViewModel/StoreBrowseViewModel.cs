﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMusicStore.Models;

namespace MVCMusicStore.ViewModel
{
	public class StoreBrowseViewModel
	{
		public Genre Genre { get; set; }
		public List<Album> Albums { get; set; }
	}
}