using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfSnackBar.Helpers
{
    public class WpfNotification
    {
        private static List<NotificationWindow> _activeNotifications = new List<NotificationWindow>();
        private const double Margin = 10;

        public static async void ShowNotification(
             string message,
            int durationMs = 2500,
            string? icon = "",
            string? iconColor = "#0dcaf0",
            string? backGroundColor = "#212529",
            string? foreGroundColor = "#fff"




            )
        {
            // تعیین موقعیت گوشه پایین سمت راست
            var desktopWorkingArea = SystemParameters.WorkArea;
            double right = desktopWorkingArea.Right - 320; // کمی فاصله از راست
            double bottom = desktopWorkingArea.Bottom - 100;

            // شیفت بالا بر اساس تعداد نوتیفیکیشن‌های فعال
            double top = bottom - (_activeNotifications.Count * (90 + Margin));

            var notif = new NotificationWindow(
            message: message,
            icon: icon,
            iconColor: iconColor,
            backGroundColor: backGroundColor,
            foreGroundColor: foreGroundColor

                );
            _activeNotifications.Add(notif);

            notif.Show();

            await notif.ShowAsync(right, top, durationMs);

            _activeNotifications.Remove(notif);

            // جا‌به‌جایی نوتیفیکیشن‌های باقی مانده
            for (int i = 0; i < _activeNotifications.Count; i++)
            {
                _activeNotifications[i].Top = bottom - ((i) * (90 + Margin));
            }
        }
    }
}
