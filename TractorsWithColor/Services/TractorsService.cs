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

        public Tractor DeleteTractor(int tractorId)
        {
            var tractorToDelete = _tractors.FirstOrDefault(tractor => tractor.Id == tractorId);
            _tractors.Remove(tractorToDelete);
            return tractorToDelete;
        }

        public List<Tractor> GetAllTractorsByColor(string color)
        {
            var tractorOnColor = _tractors.Where(tractor => tractor.Color == color);
            return tractorOnColor.ToList();
        }

        public Tractor GetTractorDetails(int tractorId)
        {
            return _tractors.FirstOrDefault(tractor => tractor.Id == tractorId);
        }

        public Tractor UpdateTractor(Tractor putTractor)
        {
            foreach (var tractor in _tractors)
            {
                if(tractor.Id == putTractor.Id)
                {
                    tractor.Model = putTractor.Model;
                    tractor.Color = putTractor.Color;
                }
            }   
                return _tractors.FirstOrDefault(tractor => tractor.Id == putTractor.Id);
        }

        private int GetId()
        {
            if (_tractors.Count == 0)
                return 1;

            return _tractors.Max(tractor => tractor.Id) + 1;
        }
    }
}
