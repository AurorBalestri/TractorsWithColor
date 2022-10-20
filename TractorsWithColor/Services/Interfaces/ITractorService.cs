using TractorsWithColor.Models;

namespace TractorsWithColor.Services.Interfaces
{
    public interface ITractorService
    {
        public Tractor AddTractor(PostTractorModel postTractor);

        public Tractor GetTractorDetails(int tractorId);

        public List<Tractor> GetAllTractorsByColor(string color);

        public Tractor UpdateTractor(Tractor putTractor);

        public Tractor DeleteTractor(int tractorId);

    }
}
