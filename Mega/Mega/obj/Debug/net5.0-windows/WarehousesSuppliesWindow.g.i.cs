﻿#pragma checksum "..\..\..\WarehousesSuppliesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E4B709B18629BC64A645593F865C861E8052803C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Mega;
using ScottPlot;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Mega {
    
    
    /// <summary>
    /// WarehousesSuppliesWindow
    /// </summary>
    public partial class WarehousesSuppliesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Adres;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CellsTb;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid WarehousesList;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AmmountTb;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateWareHousebtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\WarehousesSuppliesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Supplies;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Mega;component/warehousessupplieswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WarehousesSuppliesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Adres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.CellsTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.WarehousesList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\WarehousesSuppliesWindow.xaml"
            this.WarehousesList.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.WarehousesList_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AmmountTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CreateWareHousebtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\WarehousesSuppliesWindow.xaml"
            this.CreateWareHousebtn.Click += new System.Windows.RoutedEventHandler(this.CreateWareHousebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Supplies = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\..\WarehousesSuppliesWindow.xaml"
            this.Supplies.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Supplies_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

