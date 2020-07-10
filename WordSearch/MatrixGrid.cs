using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Midterm {
    class MatrixGrid {
        private int size;
        private char[,] matrix;
        private static List<char> chars = new List<char>();

        public MatrixGrid(int size) {
            matrix = new char[size, size];
        }

        public int SIZE {
            get { return size; }
            set { size = value; }
        }

        public char[,] MATRIX {
            get { return matrix; }
            set { matrix = value; }
        }

        private static void fillChars() {
            chars.Clear();
            for(char ch = 'a'; ch <= 'z'; ch++) {
                chars.Add(ch);
            }
        }

        public void fill() {
            fillChars();
            Random rand = new Random();
            int ran;
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    ran = rand.Next(26);
                    matrix[i, j] = chars[ran];
                }
            }
        }

        public void printMatrix(Grid grid) {
            grid.Children.Clear(); // clearing the grid before printing

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {

                    RowDefinition rd = new RowDefinition();
                    grid.RowDefinitions.Add(rd);

                    ColumnDefinition cd = new ColumnDefinition();
                    grid.ColumnDefinitions.Add(cd);
                    

                    Label lbl = new Label();
                    lbl.SetValue(Grid.RowProperty, i);
                    lbl.SetValue(Grid.ColumnProperty, j);
                    lbl.Name = "matrixContent";
                    lbl.SetResourceReference(Label.StyleProperty, "labelStyle");
                    lbl.Content = matrix[i, j];
                    grid.Children.Add(lbl);

                }
            }
        }

    }
}
