
using System.Collections.Generic;

namespace Midterm {
     class SearchWord {
        private List<int> xDir;
        private List<int> yDir;
        private bool found = false;
        private int dir, x, y;


        public string WORD {
            get;
            set;
        }
        public List<int> XDIR {
            get { return xDir; }
            set { xDir = value; }
        }

        public List<int> YDIR {
            get { return yDir; }
            set { yDir = value; }
        }

        public int DIR {
            get { return dir; }
            set { dir = value; }
        }
        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; }
            set { y = value; }
        }

        public bool FOUND {
            get { return found; }
            set { found = value; }
        }

        public bool searchWord(List<char> word, char[,] matrix) {
            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    DIR = 0;
                    int i;
                    FOUND = false;

                    while (!FOUND && DIR < 4) {

                        X = row + XDIR[DIR];
                        Y = col + YDIR[DIR];


                        if (matrix[row, col] == word[0]) {
                            for ( i = 1; i < word.Count; i++) {
                                if (X < 0 || X >= matrix.GetLength(0) || Y < 0 || Y >= matrix.GetLength(1)) {
                                    DIR++;
                                    break;
                                } else {
                                    if (matrix[X, Y] == word[i]) {
                                        X += XDIR[DIR];
                                        Y += YDIR[DIR];
                                        FOUND = true;
                                    } else {
                                        DIR++;
                                        FOUND = false;
                                        break;
                                    }
                                }
                            } 
                            if (FOUND && i==word.Count) {
                                return FOUND;
                            }
                        } else {
                            break;
                        }
                    }
                }
            }
            return FOUND;
        }
    }
}
