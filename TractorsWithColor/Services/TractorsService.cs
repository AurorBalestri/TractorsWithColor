using TractorsWithColor.Models;
using TractorsWithColor.Services.Interfaces;

namespace TractorsWithColor.Services
{
    public class TractorsService : ITractorService
    {
        private IList<Tractor> _tractors;

        public TractorsService(IList<Tractor> tractors)
        {
            _tractors = tractors;
        }

        public Tractor AddTractor(PostTractorModel tractor)
        {
            var tractorToAdd = MappingTractorWithId(tractor);
            _tractors.Add(tractorToAdd);
            return tractorToAdd;
        }

        public Tractor MappingTractorWithId(PostTractorModel tractorModel)
        {
            var TractorWithId = new Tractor();
            TractorWithId.Id = GetId();
            TractorWithId.Model = tractorModel.Model;
            TractorWithId.Color = tractorModel.Color;

            return TractorWithId;
        }

        public void DeleteTractor(int tractorId)
        {
            throw new NotImplementedException();
        }

        public List<Tractor> GetAllTractorsByColor(string color)
        {
            throw new NotImplementedException();
        }

        public List<Tractor> GetTractorDetails(int tractorId)
        {
            throw new NotImplementedException();
        }

        public Tractor UpdateTractor(PutTractorModel putTractor)
        {
            throw new NotImplementedException();
        }

        private int GetId()
        {
            if (_tractors.Count == 0)
                return 1;

            return _tractors.Max(teamMember => teamMember.Id) + 1;
        }
    }
}
