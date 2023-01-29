﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        ////4 ana metodu tanımla:IGenericDal yaptık hepsini sildik.
        //List<Category> ListAllCategory();
        //void AddCategory(Category category);
        //void DeleteCategory(Category category);
        //void UpdateCategory(Category category);
        //Category GetById(int id);//id ye göre getir.
    }
}
