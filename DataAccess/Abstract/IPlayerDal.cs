using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IPlayerDal
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
