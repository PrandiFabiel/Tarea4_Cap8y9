﻿#pragma checksum "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EA1C50A71E0DE9EECBEB8E28BBC9060681D0A77C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Capitulo8y9.UI.Capitulo8;
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


namespace Capitulo8y9.UI.Capitulo8 {
    
    
    /// <summary>
    /// Ejercicio5Cap8
    /// </summary>
    public partial class Ejercicio5Cap8 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cadena1TextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cadena2TextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrdenarButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CadenaOrdenadaTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Capitulo8y9;component/ui/capitulo8/ejercicio5cap8.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
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
            this.Cadena1TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Cadena2TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.OrdenarButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\..\UI\Capitulo8\Ejercicio5Cap8.xaml"
            this.OrdenarButton.Click += new System.Windows.RoutedEventHandler(this.OrdenarButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CadenaOrdenadaTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

