using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Infrastructure
{
   public class Country:BaseEntity
    {
        public Country(Guid ownerId) : base(ownerId)
        {
        }
        #region public Country CountryCode { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        public int CountryCode { get; set; } = 0;
        #endregion /public Country Country { get; set; }

        #region public StatusCountry Status{ get; set; }
        /// <summary>
        /// Active/Deactivate Country
        /// </summary>
        public StatusCountry Status { get; set; }
        #endregion /public StatusCountry Status { get; set; }

        #region public ICollection<City> Cities { get; set; }
        /// <summary>
        /// relation to Entity Country
        /// </summary>
        public ICollection<City> Cities { get; set; }
        #endregion /public ICollection<City> Cities { get; set; }
    }
}
