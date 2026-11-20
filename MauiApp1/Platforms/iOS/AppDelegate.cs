using Firebase.RemoteConfig;
using Foundation;
using UIKit;

namespace MauiApp1;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    public override bool FinishedLaunching(UIApplication application, NSDictionary? launchOptions)
    {
        Firebase.Core.App.Configure();
        var inst = RemoteConfig.SharedInstance;
        return base.FinishedLaunching(application, launchOptions);
    }
}
