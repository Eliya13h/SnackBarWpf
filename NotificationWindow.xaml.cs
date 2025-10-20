using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WpfSnackBar
{
    /// <summary>
    /// Interaction logic for NotificationWindow.xaml
    /// </summary>
    public partial class NotificationWindow : Window
    {
                    public NotificationWindow(
                string message,
                string? icon = "",
                string? iconColor = "#0dcaf0",
                string? backGroundColor = "#212529",
                string? foreGroundColor = "#fff")
            {
                InitializeComponent();
                MainBorder.Background = HexToBrush(backGroundColor);
                MessageText.Foreground = HexToBrush(foreGroundColor);

                MessageText.Text = message;
                if (icon != null && icon != "")
                {
                    IconImage.Text = icon;
                }
                IconImage.Foreground = HexToBrush(iconColor);

            }

            private Brush HexToBrush(string? hex)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(hex)) return Brushes.Transparent;
                    return new SolidColorBrush((Color)ColorConverter.ConvertFromString(hex));
                }
                catch
                {
                    return Brushes.Transparent;
                }
            }

            public async Task ShowAsync(double left, double top, int durationMs = 2500)
            {
                SystemSounds.Asterisk.Play();
                Left = left;
                Top = top;

                // Fade In
                for (double i = 0; i <= 1; i += 0.05)
                {
                    Opacity = i;
                    await Task.Delay(10);
                }

                await Task.Delay(durationMs);

                // Fade Out
                for (double i = 1; i >= 0; i -= 0.05)
                {
                    Opacity = i;
                    await Task.Delay(10);
                }

                Close();
            }
        }
    }

