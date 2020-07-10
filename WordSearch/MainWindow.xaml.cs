using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Midterm {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        MatrixGrid grid = new MatrixGrid(0);

        public MainWindow() {
            InitializeComponent();
        }

        private void btn_genMatrix_Click(object sender, RoutedEventArgs e) {
            lbl_Result.Content = "";
            try {
                int size = Convert.ToInt32(tb_size.Text);
                if (size < 5 || size > 20) {
                    throw new FormatException();
                }
                grid.MATRIX = new char[size, size];
                grid.fill();
                grid.printMatrix(matrixContainer);

                lbl_enterWord.Content = "Enter a word to search in the matrix";
                tb_word.Visibility = Visibility.Visible;
                btn_searchWord.Content = "Search Word";
                btn_searchWord.Visibility = Visibility.Visible;
            } catch (FormatException ex) {
                MessageBox.Show("The size should be a positive number between 5 to 20", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void btn_searchWord_Click(object sender, RoutedEventArgs e) {
            try {
                string wordToSearch = tb_word.Text.ToLower();
                //if no word is entered throw error
                if (wordToSearch == "") {
                    throw new ArgumentException("You must provide a word!");
                }

                //entering the word into a list
                List<char> word = new List<char>();
                for(int i = 0; i < wordToSearch.Length; i++) {
                    word.Add(wordToSearch[i]);
                }
             
                SearchWord search = new SearchInForDir();

                if (search.searchWord(word, grid.MATRIX)) {
                    lbl_Result.Content = "Success! Found the word in forward direction!";
                    lbl_Result.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                } else {
                    search = new SearchInBackDir();
                    if (search.searchWord(word, grid.MATRIX)) {
                        lbl_Result.Content = "Success! Found the word in backward direction!";
                        lbl_Result.Foreground = new SolidColorBrush(Color.FromRgb(0, 128, 0));
                    } else {
                        lbl_Result.Content = "Failed! Word not found. Try Again!";
                        lbl_Result.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                    }
                }
            } catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void darkTheme_Click(object sender, RoutedEventArgs e) {
            ResourceDictionary skin =
             Application.LoadComponent(new Uri("DarkTheme.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);

        }

        private void lightTheme_Click(object sender, RoutedEventArgs e) {
            ResourceDictionary skin =
           Application.LoadComponent(new Uri("LightTheme.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);
        }

        private void SuperSaiyanTheme_Click(object sender, RoutedEventArgs e) {
            ResourceDictionary skin =
          Application.LoadComponent(new Uri("SuperSaiyan.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);
        }

        private void default_theme_Click(object sender, RoutedEventArgs e) {
            ResourceDictionary skin =
        Application.LoadComponent(new Uri("DefaultTheme.xaml", UriKind.Relative)) as ResourceDictionary;
            Resources.MergedDictionaries.Add(skin);
        }
    }
}
