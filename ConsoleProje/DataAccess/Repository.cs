using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<A> : IRepository<A> where A : class
    {

        Context cn = new Context();
        DbSet<A> _data;

        public Repository()
        {
            _data = cn.Set<A>();
        }

        public int Delete(A p)
        {
            _data.Remove(p);
            return cn.SaveChanges();
        }

        public A GetById(int id)
        {
            return _data.Find(id);
        }

        public List<A> List()
        {
            return _data.ToList();
        }

        public int Update(A p)
        {
            _data.Update(p);
            return cn.SaveChanges();
        }

        public int İnsert(A p)
        {
            _data.Add(p);
            return cn.SaveChanges();
        }
    }
}
