﻿

#pragma checksum "C:\Users\feliperc\OneDrive\Public\Estudo\Estudo\POCMigrationTinder4Jobs\PrototypeTinder4Jobs\Logging.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED01FA1555E21BE283BF1AF367F6273E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrototypeTinder4Jobs
{
    partial class Logging : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\Logging.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationStarting += this.webBrowser_NavigationStarting;
                 #line default
                 #line hidden
                #line 21 "..\..\Logging.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).NavigationCompleted += this.webBrowser_NavigationCompleted;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

