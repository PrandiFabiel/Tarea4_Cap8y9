﻿#pragma checksum "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3FC248CD5D89FE3D4B67252562F19BABF94A3019"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capitulo8y9.UI.Capitulo9;
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


namespace Capitulo8y9.UI.Capitulo9 {
    
    
    /// <summary>
    /// Ejercicio1Cap9
    /// </summary>
    public partial class Ejercicio1Cap9 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IdProductoTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NombreProductoTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CantidadProductoTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PrecioProductoTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GuardarYMostrarButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ViewTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Capitulo8y9;component/ui/capitulo9/ejercicio1cap9.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.IdProductoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NombreProductoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CantidadProductoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PrecioProductoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GuardarYMostrarButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\..\UI\Capitulo9\Ejercicio1Cap9.xaml"
            this.GuardarYMostrarButton.Click += new System.Windows.RoutedEventHandler(this.GuardarYMostrarButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ViewTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

