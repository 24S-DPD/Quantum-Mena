namespace Quantum.Models
{
    public static class EventsRepository
    {
        private static List<Event> LstObjEvent = new List<Event>()
        {
            new Event {Id = 10001, Name = "Developers Exhibtion."},
            new Event {Id = 10002, Name = "Majic Learning Exhibtion."},
            new Event {Id = 10003, Name = "Technology of SomeThing Conference."},
            new Event {Id = 10004, Name = "Graduation Party"}

        };


        //* Add New event Instance 
        public static void AddEvents(Event eventOBJ) 
        {
            var maxID = LstObjEvent.Max(row => row.Id);
            eventOBJ.Id = maxID + 1;
            LstObjEvent.Add(eventOBJ);
        }


        //* Get List of events
        public static List<Event> GetEvents() => LstObjEvent;


        public static Event? GetEventByID(int intEventID)
        {
            var thisEventINS = LstObjEvent.FirstOrDefault(row => row.Id == intEventID);
          
            if(thisEventINS != null)
            {
                return new Event { Id = thisEventINS.Id, Name = thisEventINS.Name };
            }

            return null;

        }

        public static void UpdateEvent(int intEventID, Event thisEvent)
        {
            if(intEventID != thisEvent.Id) return;

            var eventToUpdate = GetEventByID(intEventID);

            if(eventToUpdate != null) 
            {
                eventToUpdate.Name = thisEvent.Name;
            }

        }

        public static void DeleteEvent(int intEventID)
        {
            var thisEvent = LstObjEvent.FirstOrDefault(row => row.Id == intEventID);

             if(thisEvent != null)
             {
                LstObjEvent.Remove(thisEvent);
             }

        }













    }
}
