﻿#pragma checksum "..\..\notebooks.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA118F7260E89E644C04DBF0F8135496"
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
    /// notebooks
    /// </summary>
    public partial class notebooks : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 65 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbtitle;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tbuser;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu tbuser_menu;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem user_right_login;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView tvNotebooks;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel spedit;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tcedit;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\notebooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notechangesButton;
        
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
            System.Uri resourceLocater = new System.Uri("/notebookQ;component/notebooks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\notebooks.xaml"
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
            this.tbtitle = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.tbuser = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\notebooks.xaml"
            this.tbuser.Click += new System.Windows.RoutedEventHandler(this.tbuser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbuser_menu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.user_right_login = ((System.Windows.Controls.MenuItem)(target));
            
            #line 72 "..\..\notebooks.xaml"
            this.user_right_login.Click += new System.Windows.RoutedEventHandler(this.user_right_login_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 92 "..\..\notebooks.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 101 "..\..\notebooks.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 111 "..\..\notebooks.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tvNotebooks = ((System.Windows.Controls.TreeView)(target));
            
            #line 121 "..\..\notebooks.xaml"
            this.tvNotebooks.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TreeViewItem_MouseRightButtonDown);
            
            #line default
            #line hidden
            
            #line 121 "..\..\notebooks.xaml"
            this.tvNotebooks.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.tvNotebooks_MouseDown);
            
            #line default
            #line hidden
            
            #line 121 "..\..\notebooks.xaml"
            this.tvNotebooks.MouseMove += new System.Windows.Input.MouseEventHandler(this.tvNotebooks_MouseMove);
            
            #line default
            #line hidden
            
            #line 121 "..\..\notebooks.xaml"
            this.tvNotebooks.DragOver += new System.Windows.DragEventHandler(this.tvNotebooks_DragOver);
            
            #line default
            #line hidden
            
            #line 121 "..\..\notebooks.xaml"
            this.tvNotebooks.Drop += new System.Windows.DragEventHandler(this.tvNotebooks_Drop);
            
            #line default
            #line hidden
            return;
            case 9:
            this.spedit = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 10:
            this.tcedit = ((System.Windows.Controls.TabControl)(target));
            return;
            case 11:
            
            #line 138 "..\..\notebooks.xaml"
            ((System.Windows.Controls.TabItem)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.notechangesButton = ((System.Windows.Controls.Button)(target));
            
            #line 152 "..\..\notebooks.xaml"
            this.notechangesButton.Click += new System.Windows.RoutedEventHandler(this.notechangesButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

