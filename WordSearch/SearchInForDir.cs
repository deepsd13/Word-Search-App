    using System.Collections.Generic;

    namespace Midterm {
        class SearchInForDir : SearchWord {

            public SearchInForDir() {
                XDIR = new List<int> { 1, 0, 1, -1 };
                YDIR = new List<int> { 0, 1, 1, 1 };
            }
        }
    }
