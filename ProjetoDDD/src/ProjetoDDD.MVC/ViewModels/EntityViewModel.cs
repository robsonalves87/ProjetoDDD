using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD.MVC.ViewModels
{
    public class EntityViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
