﻿#pragma checksum "..\..\..\UserControlMainWindow\ChangePassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E092A329021A1D647CDDB7AC6877F7DC5DCE35F4"
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
    /// ChangePassword
    /// </summary>
    public partial class ChangePassword : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox oldPassword;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPassword;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPasswordRepeat;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonChange;
        
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
            System.Uri resourceLocater = new System.Uri("/GamingPlatform;component/usercontrolmainwindow/changepassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
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
            this.oldPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.newPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.newPasswordRepeat = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.buttonChange = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
            this.buttonChange.Click += new System.Windows.RoutedEventHandler(this.buttonChange_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\..\UserControlMainWindow\ChangePassword.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoToHome);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
