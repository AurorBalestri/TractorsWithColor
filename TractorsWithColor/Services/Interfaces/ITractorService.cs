using TractorsWithColor.Models;

namespace TractorsWithColor.Services.Interfaces
{
    public interface ITractorService
    {
        public Tractor AddTractor(PostTractorModel postTractor);

        public List<Tractor> GetTractorDetails(int tractorId);

        public List<Tractor> GetAllTractorsByColor(string color);

        public Tractor UpdateTractor(PutTractorModel putTractor);

        public void DeleteTractor(int tractorId);

    }
}
