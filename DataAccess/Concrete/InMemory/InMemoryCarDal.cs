﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2010, DailyPrice=80000, Description="Ford"},
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear=2020, DailyPrice=380000, Description="BMW"},
                new Car{Id=3, BrandId=3, ColorId=3, ModelYear=2018, DailyPrice=150000, Description="Toyota"},
                new Car{Id=4, BrandId=1, ColorId=4, ModelYear=2019, DailyPrice=120000, Description="Ford"},
                new Car{Id=5, BrandId=3, ColorId=5, ModelYear=2019, DailyPrice=180000, Description="Toyota"}

        }; 
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);


        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.Description = car.Description;

            

        }
    }
}
