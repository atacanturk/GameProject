using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryValidationDal : IValidationDal
    {
        List<Player> _validPlayers;
        public InMemoryValidationDal()
        {
            _validPlayers = new List<Player> {
                new Player{Id=1, BirthYear=1997, FirstName="Ata Can", LastName="Türk", IdentiyNumber="1234567890"},
                new Player{Id=2, BirthYear=1985, FirstName="Engin", LastName="Demiroğ", IdentiyNumber="9876543210"}

            };
        }
        public bool Validate(Player player)
        {
            //if ()
            //{
            //    return true;
            //}
            //else
            //{
            //    return false,
            //}
            var playerToValid = _validPlayers.SingleOrDefault(p => p.Id == player.Id);
            return true;
            
        }
    }
}
