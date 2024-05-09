using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Infrastructure
{
    public class City:BaseEntity
    {
        public City(Guid ownerId) : base(ownerId)
        {
        }
        #region public bool Status{ get; set; }
        /// <summary>
        /// Active/Deactivate City
        /// </summary>
        public bool Status { get; set; }
        #endregion /public bool Status { get; set; }

        public TypeCity TypeCity { get; set; }
        #region public Guid CountryId { get; set; }
        /// <summary>
        /// Country Id
        /// </summary>
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        #endregion /public Guid CountryId { get; set; }
        #region public Country Country { get; set; }
        /// <summary>
        /// relation to Entity Country
        /// </summary>

        public Country Country { get; set; }
        #endregion /public Country Country { get; set; }
    }
}
