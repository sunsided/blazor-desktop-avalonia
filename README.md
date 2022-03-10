# Blazor Desktop + Avalonia

TL;DR: [Blazor Desktop] using [Avalonia UI] currently doesn't work on Linux.

---

From the current looks of it, there is no easy way to embed a browser view into Avalonia.
[WebViewControl-Avalonia] comes to mind; it does however rely on [CefGlue] for embedding
Chromium but has — as of writing this — no intention of supporting Linux
(see [OutSystems/CefGlue#18 (comment)](https://github.com/OutSystems/CefGlue/issues/18#issuecomment-917942591)).

The repository currently consists of three projects: 

- `src/BlazorDesktop`: A .NET 6 Blazor Server project.
- `src/RazorClassLibrary`: The main Razor components in a reusable class library.
- `src/AvaloniaUI`: The Avalonia MVVM application; it does not do anything useful at the moment. 

A possibly useful takeaway here is how to refactor a Blazor Server project into an application and a class library;
see the [Blazor Desktop - hybrid Web and Desktop apps in .NET 6!]
YouTube video for the inspiration. It relies on a Windows Forms application to include the web view however, 
so its proposed solution currently only runs on Windows.

[Avalonia UI]: https://github.com/AvaloniaUI/Avalonia
[WebViewControl-Avalonia]: https://github.com/OutSystems/WebView
[CefGlue]: https://github.com/OutSystems/CefGlue

[Blazor Desktop]: https://devblogs.microsoft.com/dotnet/announcing-net-6-preview-1/#blazor-desktop-apps
[Blazor Desktop - hybrid Web and Desktop apps in .NET 6!]: https://www.youtube.com/watch?v=jCR26PkaHmk
