﻿#pragma checksum "..\..\..\GuestPages\GuestPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E13ECA834A2C856CCB7AA012C6789793"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using sporting_goods_App;


namespace sporting_goods_App {
    
    
    /// <summary>
    /// GuestPage
    /// </summary>
    public partial class GuestPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\GuestPages\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\GuestPages\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReturnLoginPage;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\GuestPages\GuestPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame guestContent;
        
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
            System.Uri resourceLocater = new System.Uri("/sporting goods App;component/guestpages/guestpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\GuestPages\GuestPage.xaml"
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
            this.btnReturn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\GuestPages\GuestPage.xaml"
            this.btnReturn.Click += new System.Windows.RoutedEventHandler(this.btnReturn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnReturnLoginPage = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\GuestPages\GuestPage.xaml"
            this.btnReturnLoginPage.Click += new System.Windows.RoutedEventHandler(this.btnReturnLoginPage_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.guestContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

