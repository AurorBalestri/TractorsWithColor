using System;
using System.Security.Permissions;

namespace TractorsWithColor.Models
{
    public class Tractor
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
    }

}
