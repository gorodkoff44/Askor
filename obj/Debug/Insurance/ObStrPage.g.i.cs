﻿#pragma checksum "..\..\..\Insurance\ObStrPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62015D0E88A62565B94678E846DD99F8488C07CE6C59FCE0436A9AC7E58D7034"
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
using Страховая;


namespace Страховая {
    
    
    /// <summary>
    /// ObStrPage
    /// </summary>
    public partial class ObStrPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Insurance\ObStrPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Table;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Insurance\ObStrPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel Panel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Insurance\ObStrPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Auto;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Insurance\ObStrPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SLife;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Insurance\ObStrPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Zhil;
        
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
            System.Uri resourceLocater = new System.Uri("/Страховая;component/insurance/obstrpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Insurance\ObStrPage.xaml"
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
            this.Table = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Panel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 3:
            this.Auto = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Insurance\ObStrPage.xaml"
            this.Auto.Click += new System.Windows.RoutedEventHandler(this.Auto_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SLife = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Insurance\ObStrPage.xaml"
            this.SLife.Click += new System.Windows.RoutedEventHandler(this.SLife_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Zhil = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Insurance\ObStrPage.xaml"
            this.Zhil.Click += new System.Windows.RoutedEventHandler(this.Zhil_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
