﻿using System;

namespace ScooterInstanceAPI.Data
{
    public class ScooterInstance
    {
        public Guid ScooterInstanceId { get; set; }

        public int ScooterAutonomy { get; set; } //km

        public Scooter Scooter { get; set; }

        public decimal Price { get; set; }

        public ScooterInstance()
        {
            ScooterInstanceId = Guid.NewGuid();
        }

        public static ScooterInstance Create(int scooterAutonomy, decimal price, Scooter scooter)
        {
            return new ScooterInstance
            {
                ScooterInstanceId = Guid.NewGuid(),
                ScooterAutonomy = scooterAutonomy,
                Price = price,
                Scooter = scooter           
            };
        }

        public void Update(int scooterAutonomy)
        {
            ScooterAutonomy = scooterAutonomy;
        }
    }
}