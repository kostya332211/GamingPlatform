﻿#pragma checksum "..\..\..\UserControlMainWindow\MenuStats.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F7CF74F16F202FD98FB331E0FCA276141A7B15C"
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
    /// MenuStats
    /// </summary>
    public partial class MenuStats : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/GamingPlatform;component/usercontrolmainwindow/menustats.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlMainWindow\MenuStats.xaml"
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
            
            #line 30 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToHome);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 39 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameSnake);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 47 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameMemory);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 52 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameMine);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 57 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameTetris);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 62 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameBall);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 67 "..\..\..\UserControlMainWindow\MenuStats.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StatsGameSwitch);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

