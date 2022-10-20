using TractorsWithColor.Models;
using TractorsWithColor.Services.Interfaces;

namespace TractorsWithColor.Services
{
    public class TractorsService : ITractorService
    {
        /*private IList<Tractor> _tractors;

        public TractorsService(IList<Tractor> tractors)
        {
            _tractors = tractors;
        }*/

        private static IList<Tractor> _tractors = new List<Tractor>();

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
            var tractorOnColor = _tractors.Where(tractor => tractor.Color == color);
            return tractorOnColor.ToList();
        }

        public Tractor GetTractorDetails(int tractorId)
        {
            var tractorOnId = _tractors.FirstOrDefault(tractor => tractor.Id == tractorId);
            return tractorOnId;
        }

        public Tractor UpdateTractor(PutTractorModel putTractor)
        {
            throw new NotImplementedException();
        }

        private int GetId()
        {
            if (_tractors.Count == 0)
                return 1;

            return _tractors.Max(tractor => tractor.Id) + 1;
        }
    }
}
