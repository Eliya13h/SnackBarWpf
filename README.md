# 🍫 SnackBarWpf
A modern, lightweight, and reusable **Snackbar / Toast Notification** component for WPF — built for clean, elegant, and responsive UI alerts.

---

## ✨ Features
- ⚡ **Lightweight** — pure WPF, no external dependencies  
- 🎨 **Customizable** — change colors, icons, duration, and style  
- 🔊 **Sound support** — plays system alert sound when shown  
- 📚 **Stacked notifications** — automatically repositions multiple toasts  
- 💫 **Smooth fade animations** — appear and disappear gracefully  
- 🧩 **Reusable DLL** — plug it into any WPF project easily

---

## 🚀 Installation
### Option 1 — Reference the DLL manually
1. Build the project → get `SnackBarWpf.dll` from  
   `bin\Release\`
2. In your WPF project:  
   **Right-click → Add → Reference → Browse → SnackBarWpf.dll**

### Option 2 — (Optional) Add as a Project Reference
If both projects are in the same solution:

## Implemention
       public static async void ShowNotification(
             string message,
            int durationMs = 2500,
            string? icon = "",
            string? iconColor = "#0dcaf0",
            string? backGroundColor = "#212529",
            string? foreGroundColor = "#fff"
            )



---

## 💡 Usage Example

```csharp
using SnackBarWpf.Helpers;

private void Button_Click(object sender, RoutedEventArgs e)
{
    // Simple info notification
    WpfNotification.ShowNotification("Hello, World!");


    ShowNotification(
             string message,
            int durationMs = 2500,
            string? icon = "",
            string? iconColor = "#0dcaf0",
            string? backGroundColor = "#212529",
            string? foreGroundColor = "#fff"
                



            )
    // Custom colors and icon
    WpfNotification.ShowNotification(
        message: "Custom look!",
        durationMs: 3000,
        icon: "\uf005", // FontAwesome icon
        iconColor: "#ffc107",
        backGroundColor: "#212529",
        foreGroundColor: "#ffffff"
    );
}
