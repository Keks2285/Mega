﻿#pragma checksum "..\..\..\IngridientsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0EAD50504F34A2689A4D0FF35BD5BF164DB14DD8"
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
    /// IngridientsWindow
    /// </summary>
    public partial class IngridientsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid IngridientsGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddIngridient;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DishesDg;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameIngridientTb;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameDishTb;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CostTb;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\IngridientsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WeghtTb;
        
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
            System.Uri resourceLocater = new System.Uri("/Mega;component/ingridientswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\IngridientsWindow.xaml"
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
            this.IngridientsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.AddIngridient = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\IngridientsWindow.xaml"
            this.AddIngridient.Click += new System.Windows.RoutedEventHandler(this.AddIngridient_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DishesDg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\IngridientsWindow.xaml"
            this.DishesDg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.IngridientsGrid_Copy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameIngridientTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NameDishTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CostTb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.WeghtTb = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

