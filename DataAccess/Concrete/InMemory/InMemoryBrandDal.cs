﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        private List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{Id = 1, Name = "Mercedes"},
                new Brand{Id = 2, Name = "BMW"},
                new Brand{Id = 3, Name = "Volvo"},
                new Brand{Id = 4, Name = "Audi"},
                new Brand{Id = 5, Name = "Dodge"},
            };
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int brandId)
        {
            return _brands.SingleOrDefault(b=> b.Id == brandId);
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Update(Brand brand)
        {
            var brandToUpdate = _brands.SingleOrDefault(b=>b.Id == brand.Id);
            brandToUpdate.Id = brand.Id;
            brandToUpdate.Name = brand.Name;
        }

        public void Delete(Brand brand)
        {
            var brandToDelete = _brands.SingleOrDefault(b => b.Id == brand.Id);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
