﻿#pragma checksum "..\..\..\Windows\Catalog_admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBA417A60DFC2B214BBDB513D804AEEF60B0113A0753A7A31BA576F737BF0559"
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
    /// Catalog_admin
    /// </summary>
    public partial class Catalog_admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Windows\Catalog_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxProducts;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\Catalog_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\Catalog_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSort;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Windows\Catalog_admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilterDiscount;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Windows\Catalog_admin.xaml"
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
            System.Uri resourceLocater = new System.Uri("/ООО Ритм;component/windows/catalog_admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\Catalog_admin.xaml"
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
            
            #line 8 "..\..\..\Windows\Catalog_admin.xaml"
            ((ООО_Ритм.Windows.Catalog_admin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 27 "..\..\..\Windows\Catalog_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Back);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 28 "..\..\..\Windows\Catalog_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_AddProduct);
            
            #line default
            #line hidden
            return;
            case 4:
            this.listBoxProducts = ((System.Windows.Controls.ListBox)(target));
            
            #line 38 "..\..\..\Windows\Catalog_admin.xaml"
            this.listBoxProducts.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listBoxProducts_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\Windows\Catalog_admin.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\..\Windows\Catalog_admin.xaml"
            this.cbSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Cost);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbFilterDiscount = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\..\Windows\Catalog_admin.xaml"
            this.cbFilterDiscount.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Discount);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbFilterCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 87 "..\..\..\Windows\Catalog_admin.xaml"
            this.cbFilterCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbSort_Category);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 102 "..\..\..\Windows\Catalog_admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_DeleteFilters);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

