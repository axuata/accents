using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Accents {
  /// <summary>
  /// MainWindow.xaml の相互作用ロジック
  /// </summary>
  public partial class MainWindow {
    private string mark = "";

    public MainWindow() {
      InitializeComponent();

      Properties.Settings.Default.SettingsLoaded += Default_SettingsLoaded;
      Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
    }

    private void ConvertText(string mark) {
      bool doConvertSpace = Properties.Settings.Default.doConvertSpace;
      string text = beforeConvertedTextbox.Text;
      string result = "";

      foreach (char c in text) {
        string combinedString = c.ToString();
        if (doConvertSpace) {
          if (c == ' ') {
            combinedString += mark;
          } else {
            combinedString += mark;
          }
        } else {
          if (c == ' ') {
            combinedString += "";
          } else {
            combinedString += mark;
          }
        }
        result += combinedString;
      }

      afterConvertedTextbox.Text = result;
    }

    private void Default_SettingsLoaded(object sender, SettingsLoadedEventArgs e) {
      Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
    }

    private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e) {
      if (e.PropertyName == nameof(Properties.Settings.Default.doConvertSpace)) {
        ConvertText(mark);
      }
    }

    private void beforeConvertedTextbox_TextChanged(object sender, TextChangedEventArgs e) {
      ConvertText(mark);
    }

    private void buttonAccentsListReset_Click(object sender, RoutedEventArgs e) {
      mark = "";
      beforeConvertedTextbox.Text = "";
      afterConvertedTextbox.Text = "";
    }

    private void buttonCopy_Click(object sender, RoutedEventArgs e) {
      Clipboard.SetText(afterConvertedTextbox.Text);
    }

    private void buttonSettings_Click(object sender, RoutedEventArgs e) {
      var settingsDialog = new SettingsDialog();

      settingsDialog.ShowDialog();
    }

    private void MainFluentWindow_Loaded(object sender, RoutedEventArgs e) {
      MainFluentWindow.MaxHeight = MainFluentWindow.Height;
      MainFluentWindow.MaxWidth = MainFluentWindow.Width;
      MainFluentWindow.MinHeight = MainFluentWindow.Height;
      MainFluentWindow.MinWidth = MainFluentWindow.Width;
    }

    #region marks
    private void buttonListFirstAcute_Click(object sender, RoutedEventArgs e) {
      mark = "\u0301";
      ConvertText(mark);
    }

    private void buttonListFirstDoubleacute_Click(object sender, RoutedEventArgs e) {
      mark = "\u030B";
      ConvertText(mark);
    }

    private void buttonListFirstGrave_Click(object sender, RoutedEventArgs e) {
      mark = "\u0300";
      ConvertText(mark);
    }

    private void buttonListFirstDoublegrave_Click(object sender, RoutedEventArgs e) {
      mark = "\u030F";
      ConvertText(mark);
    }

    private void buttonListFirstBreve_Click(object sender, RoutedEventArgs e) {
      mark = "\u0306";
      ConvertText(mark);
    }

    private void buttonListFirstCaron_Click(object sender, RoutedEventArgs e) {
      mark = "\u030C";
      ConvertText(mark);
    }

    private void buttonListFirstCedilla_Click(object sender, RoutedEventArgs e) {
      mark = "\u0327";
      ConvertText(mark);
    }

    private void buttonListFirstCircumflex_Click(object sender, RoutedEventArgs e) {
      mark = "\u0302";
      ConvertText(mark);
    }

    private void buttonListFirstDiaeresis_Click(object sender, RoutedEventArgs e) {
      mark = "\u0308";
      ConvertText(mark);
    }

    private void buttonListFirstTilde_Click(object sender, RoutedEventArgs e) {
      mark = "\u0303";
      ConvertText(mark);
    }

    private void buttonListFirstDot_Click(object sender, RoutedEventArgs e) {
      mark = "\u0307";
      ConvertText(mark);
    }

    private void buttonListFirstHook_Click(object sender, RoutedEventArgs e) {
      mark = "\u0309";
      ConvertText(mark);
    }

    private void buttonListSecondHorn_Click(object sender, RoutedEventArgs e) {
      mark = "\u031B";
      ConvertText(mark);
    }

    private void buttonListSecondMacron_Click(object sender, RoutedEventArgs e) {
      mark = "\u0304";
      ConvertText(mark);
    }

    private void buttonListSecondOgonek_Click(object sender, RoutedEventArgs e) {
      mark = "\u0328";
      ConvertText(mark);
    }

    private void buttonListSecondRing_Click(object sender, RoutedEventArgs e) {
      mark = "\u030A";
      ConvertText(mark);
    }

    private void buttonListSecondCommaabove_Click(object sender, RoutedEventArgs e) {
      mark = "\u0312";
      ConvertText(mark);
    }

    private void buttonListSecondCommabelow_Click(object sender, RoutedEventArgs e) {
      mark = "\u0326";
      ConvertText(mark);
    }

    private void buttonListSecondSmoothbreathing_Click(object sender, RoutedEventArgs e) {
      mark = "\u0313";
      ConvertText(mark);
    }
    #endregion
  }
}
