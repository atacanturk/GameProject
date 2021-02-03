using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        InMemoryValidationDal InMemoryValidationDal = new InMemoryValidationDal();
        static void Main(string[] args)
        {
            Player player1 = new Player() { 
                Id = 1, 
                BirthYear = 1997, 
                FirstName = "Ata Can", 
                IdentiyNumber = "1234567890",
                LastName = "Türk" 
            };
            
                
            

            PlayerManager playerManager = new PlayerManager(new InMemoryPlayerDal());
            playerManager.Add(player1);
        }
    }
}
