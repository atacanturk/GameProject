using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerDal _playerDal;
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }
        public void Add(Player player)
        {
            _playerDal.Add(player);
        }

        public void Delete(Player player)
        {
            _playerDal.Delete(player);
        }

        public void Update(Player player)
        {
            _playerDal.Update(player);
        }
    }
}
