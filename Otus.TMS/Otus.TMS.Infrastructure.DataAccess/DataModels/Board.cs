﻿using Otus.TMS.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Otus.TMS.Infrastructure.DataAccess.DataModels
{
    public class Board : IAuditableEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid DepartmentId { get; set; }

        public Department Department { get; set; }

        public int BoardType { get; set; }

        public bool IsPrivate { get; set; }

        public List<BoardUser> BoardUsers { get; set; } = [];
        public List<BoardUserRole> BoardUserRoles { get; set; } = [];

        public Board() { }

        public Board(Guid id)
        {
            Id = id;
            CreationDate = DateTime.UtcNow;
        }
    }
}
