
using System.Collections.Generic;

namespace Midterm {
    class SearchInBackDir : SearchWord {
        public SearchInBackDir() {
            XDIR = new List<int> { -1, 0, 1, -1 };
            YDIR = new List<int> { 0, -1, -1, -1 };
        }
    }
}
