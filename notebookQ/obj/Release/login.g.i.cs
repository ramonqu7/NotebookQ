﻿#pragma checksum "..\..\login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84B5F29DCC6EF8219C08F4485DF8C099"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
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
using notebookQ;


namespace notebookQ {
    
    
    /// <summary>
    /// login
    /// </summary>
    public partial class login : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsername;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btloginin;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PassUserId;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_username;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_password;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label VisiblePassword;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/notebookQ;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\login.xaml"
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
            
            #line 16 "..\..\login.xaml"
            ((notebookQ.login)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Page_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\login.xaml"
            this.tbUsername.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbUsername_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 37 "..\..\login.xaml"
            this.tbPassword.KeyDown += new System.Windows.Input.KeyEventHandler(this.tbPassword_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbLogin = ((System.Windows.Controls.CheckBox)(target));
            
            #line 38 "..\..\login.xaml"
            this.cbLogin.KeyDown += new System.Windows.Input.KeyEventHandler(this.cbLogin_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btloginin = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\login.xaml"
            this.btloginin.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 40 "..\..\login.xaml"
            this.btloginin.KeyDown += new System.Windows.Input.KeyEventHandler(this.btloginin_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 41 "..\..\login.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PassUserId = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.label_username = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.label_password = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.VisiblePassword = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\login.xaml"
            this.button.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.button_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 46 "..\..\login.xaml"
            this.button.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.button_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

