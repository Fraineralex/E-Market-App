﻿namespace EMarketApp.Core.Application.ViewModels.Ads
{
    public class AdViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ImagePathOne { get; set; }
        public string? ImagePathTwo { get; set; }
        public string? ImagePathThree { get; set; }
        public string? ImagePathFour { get; set; }

        public double? Price { get; set; }

        public string? Description { get; set; }

        public string? Category { get; set; }

        public int? CategoryId { get; set; }
    }
}
