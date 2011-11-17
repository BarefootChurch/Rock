//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Rock.Models;

namespace Rock.Models.Util
{
    [Table( "utilJob" )]
    public partial class Job : ModelWithAttributes<Job>
    {
		[DataMember]
		public bool? System { get; set; }
		
		[DataMember]
		public bool? Active { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Name { get; set; }
		
		[MaxLength( 500 )]
		[DataMember]
		public string Description { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Assemby { get; set; }
		
		[MaxLength( 100 )]
		[DataMember]
		public string Class { get; set; }
		
		[MaxLength( 120 )]
		[DataMember]
		public string CronExpression { get; set; }
		
		[DataMember]
		public DateTime? LastSuccessfulRun { get; set; }
		
		[DataMember]
		public DateTime? LastRunDate { get; set; }
		
		[DataMember]
		public int? LastRunDuration { get; set; }
		
		[MaxLength( 50 )]
		[DataMember]
		public string LastStatus { get; set; }
		
		[DataMember]
		public string LastStatusMessage { get; set; }
		
		[MaxLength( 1000 )]
		[DataMember]
		public string NotificationEmails { get; set; }
		
		[DataMember(Name = "NotificationStatus")]
		internal int? NotificationStatusInternal { get; set; }

		[NotMapped]
		public JobNotificationStatus NotificationStatus
		{
			get { return (JobNotificationStatus)this.NotificationStatusInternal; }
			set { this.NotificationStatusInternal = (int)value; }
		}
		
		[DataMember]
		public DateTime? CreatedDateTime { get; set; }
		
		[DataMember]
		public DateTime? ModifiedDateTime { get; set; }
		
		[DataMember]
		public int? CreateByPersonId { get; set; }
		
		[DataMember]
		public int? ModifiedByPersonId { get; set; }
		
		[NotMapped]
		public override string AuthEntity { get { return "Util.Job"; } }

		public virtual Crm.Person CreateByPerson { get; set; }

		public virtual Crm.Person ModifiedByPerson { get; set; }

        public static Job Read(int id)
        {
            return new Rock.Services.Util.JobService().Get( id );
        }

    }

    public partial class JobConfiguration : EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
			this.HasOptional( p => p.CreateByPerson ).WithMany().HasForeignKey( p => p.CreateByPersonId );
			this.HasOptional( p => p.ModifiedByPerson ).WithMany().HasForeignKey( p => p.ModifiedByPersonId );
		}
    }
}
