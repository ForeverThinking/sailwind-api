﻿namespace SailwindApi.Core;

public record class Location
{
    public int Id { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
