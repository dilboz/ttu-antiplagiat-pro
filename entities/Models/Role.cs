using System.ComponentModel.DataAnnotations;
using entities.Enums;

namespace entities.Models;

public class Role
{ 
    public Roles Id { get; set; }
    public string Name { get; set; }

    public virtual IEnumerable<User> Users { get; set; }
}