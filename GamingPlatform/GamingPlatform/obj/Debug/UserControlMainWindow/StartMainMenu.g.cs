﻿#pragma checksum "..\..\..\UserControlMainWindow\StartMainMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F202FBFEBA84659D9967889561AC697E4F030CCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GamingPlatform.UserControlMainWindow;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GamingPlatform.UserControlMainWindow {
    
    
    /// <summary>
    /// StartMainMenu
    /// </summary>
    public partial class StartMainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Profile;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ProfileButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Statistics;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatsButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Games;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GameButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Chat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GamingPlatform;component/usercontrolmainwindow/startmainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Profile = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ProfileButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.ProfileButton.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.Profile_MouseEnter));
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.ProfileButton.AddHandler(System.Windows.Input.Mouse.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.Profile_MouseLeave));
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.ProfileButton.Click += new System.Windows.RoutedEventHandler(this.ProfileButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Statistics = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.StatsButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.StatsButton.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.Statistics_MouseEnter));
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.StatsButton.AddHandler(System.Windows.Input.Mouse.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.Statistics_MouseLeave));
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.StatsButton.Click += new System.Windows.RoutedEventHandler(this.StatsButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Games = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.GameButton = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.GameButton.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.Games_MouseEnter));
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.GameButton.AddHandler(System.Windows.Input.Mouse.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.Games_MouseLeave));
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.GameButton.Click += new System.Windows.RoutedEventHandler(this.GameButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Chat = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\UserControlMainWindow\StartMainMenu.xaml"
            this.Chat.Click += new System.Windows.RoutedEventHandler(this.Chat_client);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

