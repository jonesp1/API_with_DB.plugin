using System;
using Database.plugin;

namespace API.Entities
{

    public class User : IEntity
    {

        public string Id { get; set; }
        public string Name { get; set; }
    }
}