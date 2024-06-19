using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Accents {
  /// <summary>
  /// SettingsDialog.xaml の相互作用ロジック
  /// </summary>
  public partial class SettingsDialog {
    public SettingsDialog() {
      InitializeComponent();
    }

    #region doConvertSpace
    private void ToggleSwitchDoConvertSpace_Checked(object sender, RoutedEventArgs e) {
      Properties.Settings.Default.doConvertSpace = true;
      Properties.Settings.Default.Save();
    }

    private void ToggleSwitchDoConvertSpace_Unchecked(object sender, RoutedEventArgs e) {
      Properties.Settings.Default.doConvertSpace = false;
      Properties.Settings.Default.Save();
    }
    #endregion

    private void SettingsDialogFluentWindow_Loaded(object sender, RoutedEventArgs e) {
      SettingsDialogFluentWindow.MaxHeight = SettingsDialogFluentWindow.Height;
      SettingsDialogFluentWindow.MaxWidth = SettingsDialogFluentWindow.Width;
      SettingsDialogFluentWindow.MinHeight = SettingsDialogFluentWindow.Height;
      SettingsDialogFluentWindow.MinWidth = SettingsDialogFluentWindow.Width;

      if (Properties.Settings.Default.doConvertSpace) {
        ToggleSwitchDoConvertSpace.IsChecked = true;
      } else {
        ToggleSwitchDoConvertSpace.IsChecked = false;
      }
    }
  }
}
