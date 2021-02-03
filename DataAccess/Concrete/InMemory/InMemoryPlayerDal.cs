using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    
    public class InMemoryPlayerDal : IPlayerDal
    {
        List<Player> players;
        public InMemoryPlayerDal()
        {
            players = new List<Player> {
                new Player{Id=3, BirthYear=1998, FirstName="Can", LastName="Güngör", IdentiyNumber="1111111111"},
                new Player{Id=4, BirthYear=1970, FirstName="Kemal", LastName="Tanca", IdentiyNumber="999999999"}
            };
        }

        IValidationDal _validationDal;
        public InMemoryPlayerDal(IValidationDal validationDal)
        {
            _validationDal = validationDal;
        }
        public void Add(Player player)
        {
            if (_validationDal.Validate(player)==true)
            {
                players.Add(player);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız");
            }
        }

        public void Delete(Player player)
        {
            var playerToDelete = players.SingleOrDefault(p => p.Id == player.Id);
            players.Remove(playerToDelete);
        }

        public void Update(Player player)
        {
            var playerToUpdate = players.SingleOrDefault(p => p.Id == player.Id);
            players.Remove(playerToUpdate);
        }
    }
}
