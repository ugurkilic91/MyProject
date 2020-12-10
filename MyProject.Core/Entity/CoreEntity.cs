using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Core.Entity
{
    public class CoreEntity
    {
        public CoreEntity()
        {
            this.Status = Status.Active;
            this.CreatedDate = DateTime.Now;
            this.CreatedUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;;
        }

        [Column("CREATEDDATE")]
        public DateTime? CreatedDate { get; set; }
        [Column("CREATEDCOMPUTERNAME")]
        public string CreatedComputerName { get; set; }
        [Column("CREATEDUSERNAME")]
        public string CreatedUserName { get; set; }
        [Column("MODIFIEDDATE")]
        public DateTime? ModifiedDate { get; set; }
        [Column("MODIFIEDCOMPUTERNAME")]
        public string ModifiedComputerName { get; set; }
        [Column("MODIFIEDUSERNAME")]
        public string ModifiedUserName { get; set; }
        [Column("STATUS")]
        public Status Status { get; set; }

    }
    public enum Status
    {
        None = 0,
        Active = 1,
        Updated = 2,
        Deleted = 3
    }
}
