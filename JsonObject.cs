using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProtocol {
    class JsonObject {

        public TimeSpan totalTime { get; set; }
        public List<TimeItem> timeItems { get; set; }//All timeItems

        public JsonObject() {
            timeItems = new List<TimeItem>();
        }
    }

    class TimeItem {
        public string Name { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateStop { get; set; }
        public string timeDifference { get; set; }
        public string description { get; set; }
        

        public TimeItem() {
            
        }
    }
}
