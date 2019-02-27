using FirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.Repository
{
    public class BandRepository : IBandRepository
    {
        public Band GetBand(int id)
        {
            throw new NotImplementedException();
        }

        public List<Band> GetBands()
        {
            var listOfBands = new List<Band>
            {
                new Band
                {
                    Title = "new title",
                    Biography = "bio",
                    Genre = "genre",
                    Origin = "origin"
                },
                new Band
                {
                    Title = "new title2",
                    Biography = "bio2",
                    Genre = "genre2",
                    Origin = "origin2"
                },
                new Band
                {
                    Title = "new title3",
                    Biography = "bio3",
                    Genre = "genre3",
                    Origin = "origin3"
                }
            };

            return listOfBands;
        }
    }
}
