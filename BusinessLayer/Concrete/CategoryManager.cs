using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {



        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBL(Category p)
        //{

        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata mesajı
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }

        //}

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            //throw new NotImplementedException();
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            //throw new NotImplementedException();
            return _categoryDal.List();
        }



        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryStatus == false || p.CategoryName.Length <= 2)
        //    {
        //        hata mesajı
        //    }
        //    else
        //    {
        //        _categoryDal.Insert(p);
        //    }
        //}
    }
}
