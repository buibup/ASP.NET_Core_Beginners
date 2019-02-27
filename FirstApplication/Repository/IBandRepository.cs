using FirstApplication.Models;
using System.Collections.Generic;

namespace FirstApplication.Repository
{
    public interface IBandRepository
    {
        /// <summary>
        /// get all bands in the database.
        /// </summary>
        /// <returns>list of bands.</returns>
        List<Band> GetBands();

        Band GetBand(int id);
    }
}