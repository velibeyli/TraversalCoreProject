using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutService : IAboutService
    {
        IAboutDAL _aboutDAL;
        public AboutService(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void Add(About entity)
        {
            _aboutDAL.Insert(entity);
        }

        public void Delete(About entity)
        {
            _aboutDAL.Delete(entity);
        }

        public List<About> GetAll()
        {
            return _aboutDAL.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(About entity)
        {
            _aboutDAL.Update(entity);
        }
    }
}
