﻿#pragma checksum "..\..\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8690079F303B913F8A16743F3259579A"
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
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoryAdd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoryRemove;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductAdd;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductRemove;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox categoryList;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox productList;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategoryEdit;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProductEdit;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCategoryFound;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProductFound;
        
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
            System.Uri resourceLocater = new System.Uri("/sporting goods App;component/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainPage.xaml"
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
            this.btnCategoryAdd = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MainPage.xaml"
            this.btnCategoryAdd.Click += new System.Windows.RoutedEventHandler(this.btnCategoryAdd_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCategoryRemove = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainPage.xaml"
            this.btnCategoryRemove.Click += new System.Windows.RoutedEventHandler(this.btnCategoryRemove_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnProductAdd = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainPage.xaml"
            this.btnProductAdd.Click += new System.Windows.RoutedEventHandler(this.btnProductAdd_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnProductRemove = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\MainPage.xaml"
            this.btnProductRemove.Click += new System.Windows.RoutedEventHandler(this.btnProductRemove_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.categoryList = ((System.Windows.Controls.ListBox)(target));
            
            #line 42 "..\..\MainPage.xaml"
            this.categoryList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.categoryList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.productList = ((System.Windows.Controls.ListBox)(target));
            
            #line 43 "..\..\MainPage.xaml"
            this.productList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.productList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCategoryEdit = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainPage.xaml"
            this.btnCategoryEdit.Click += new System.Windows.RoutedEventHandler(this.btnCategoryEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnProductEdit = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\MainPage.xaml"
            this.btnProductEdit.Click += new System.Windows.RoutedEventHandler(this.btnProductEdit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtCategoryFound = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\MainPage.xaml"
            this.txtCategoryFound.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCategoryFound_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtProductFound = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\MainPage.xaml"
            this.txtProductFound.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtProductFound_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

