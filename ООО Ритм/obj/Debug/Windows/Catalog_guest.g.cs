﻿#pragma checksum "..\..\..\Windows\Catalog_guest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DA13F79B1184334998A7CB2861C62BE657855634CEFE19B529F7115F5FB92642"
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
using ООО_Ритм.Windows;


namespace ООО_Ритм.Windows {
    
    
    /// <summary>
    /// Catalog_guest
    /// </summary>
    public partial class Catalog_guest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Windows\Catalog_guest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxProducts;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\Catalog_guest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Windows\Catalog_guest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSort;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Windows\Catalog_guest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilterDiscount;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Windows\Catalog_guest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilterCategory;
        
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
            System.Uri resourceLocater = new System.Uri("/ООО Ритм;component/windows/catalog_guest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Catalog_guest.xaml"
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
            
            #line 8 "..\..\..\Windows\Catalog_guest.xaml"
            ((ООО_Ритм.Windows.Catalog_guest)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\Windows\Catalog_guest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listBoxProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\Windows\Catalog_guest.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "..\..\..\Windows\Catalog_guest.xaml"
            this.cbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Cost);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbFilterDiscount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 79 "..\..\..\Windows\Catalog_guest.xaml"
            this.cbFilterDiscount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Discount);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbFilterCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\Windows\Catalog_guest.xaml"
            this.cbFilterCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Category);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 101 "..\..\..\Windows\Catalog_guest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_DeleteFilters);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

