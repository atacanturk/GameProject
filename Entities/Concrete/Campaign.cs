using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public int CampainName { get; set; }
        public bool IsActive { get; set; }
    }
}
