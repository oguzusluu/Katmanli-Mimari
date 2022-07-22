using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<A>
    {
        int İnsert(A p);
        int Update(A p);

        int Delete(A p);



        List<A> List();

        A GetById(int id);



    }
}
