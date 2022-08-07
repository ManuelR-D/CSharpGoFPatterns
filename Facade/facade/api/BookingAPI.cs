using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFPatterns.Facade.facade.api
{
    internal class BookingAPI
    {
        public void book(DateTime initialDate, DateTime returnDate, String from, String to)
        {
            //Get the data
            List<String> hotels = new service.HotelService().searchHotels(initialDate, returnDate, from, to);
            List<DateTime> flights = new service.PlaneService().searchFlights(initialDate, returnDate, from, to);
            //Do something.
        }
    }
}
