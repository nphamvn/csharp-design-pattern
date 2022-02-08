public static class ManufacturerDataProvider
{
    public static IEnumerable<Manufacturer> GetData()
    {
        return new List<Manufacturer>
        {
            new Manufacturer { Name = "BMW", City = "Munich", Year = 1916 },
            new Manufacturer { Name = "Mercedes", City = "Dusseldorf", Year = 1926 },
            new Manufacturer { Name = "Volvo", City = "Göteborg", Year = 1878 },
            new Manufacturer { Name = "Audi", City = "Munich", Year = 1919 },
            new Manufacturer { Name = "VW", City = "Dortmund", Year = 1937 },
            new Manufacturer { Name = "Ford", City = "Detroit", Year = 1903 },
            new Manufacturer { Name = "Fiat", City = "Torino", Year = 1887 },
            new Manufacturer { Name = "Renault", City = "Paris", Year = 1885 },
            new Manufacturer { Name = "Opel", City = "Karlsruhe", Year = 1882 },
            new Manufacturer { Name = "Peugeot", City = "Besançon", Year = 1871 },
            new Manufacturer { Name = "Citroën", City = "Le Mans", Year = 1892 },
            new Manufacturer { Name = "Honda", City = "Tokyo", Year = 1948 },
            new Manufacturer { Name = "Toyota", City = "Yokohama", Year = 1937 },
            new Manufacturer { Name = "Chevrolet", City = "Detroit", Year = 1908 },
            new Manufacturer { Name = "Nissan", City = "Tokyo", Year = 1892 },
            new Manufacturer { Name = "Mazda", City = "Nagoya", Year = 1926 },
            new Manufacturer { Name = "Subaru", City = "Osaka", Year = 1921 },
            new Manufacturer { Name = "Suzuki", City = "Nagoya", Year = 1923 },
            new Manufacturer { Name = "Hyundai", City = "Seoul", Year = 1938 },
            new Manufacturer { Name = "Kia", City = "Seoul", Year = 1938 },
            new Manufacturer { Name = "Mitsubishi", City = "Yokohama", Year = 1937 },
        };
    }
}