﻿

#pragma checksum "C:\Users\feliperc\OneDrive\Public\Estudo\Estudo\tinder4jobs\Tinder4Jobs.App\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63D21E3A343394D808EC287F351581BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tinder4Jobs
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 275 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationCompleted += this.OnManipulationCompleted;
                 #line default
                 #line hidden
                #line 276 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationDelta += this.OnManipulationDelta;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 529 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.LeftSideBar_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 545 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnHome;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 559 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnProfile;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 574 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnJobList;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 491 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnInfo;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 192 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnLeftMenu;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 218 "..\..\View\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnRightMenu;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

