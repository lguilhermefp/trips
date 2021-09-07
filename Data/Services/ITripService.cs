using System.Collections.Generic;

namespace Trips.Data
{
	public interface ITripService
	{
		List<Trip> GetAllTrips();
		Trip GetTripById(int tripId);
		void UpdateTrip
	}
}