﻿#pragma checksum "..\..\..\..\Page\MenuPage\MenuAdmin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C1F983C9784B9AA36F616888B5312EF747432B4CE05E0BF57DAB761375CBB3A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ShippingCompany.Page;
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


namespace ShippingCompany.Page {
    
    
    /// <summary>
    /// MenuAdmin
    /// </summary>
    public partial class MenuAdmin : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxbLoginUser;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUser;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCruise;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPort;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnShip;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btnback;
        
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
            System.Uri resourceLocater = new System.Uri("/ShippingCompany;component/page/menupage/menuadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
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
            this.TxbLoginUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BtnUser = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
            this.BtnUser.Click += new System.Windows.RoutedEventHandler(this.BtnUser_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCruise = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
            this.BtnCruise.Click += new System.Windows.RoutedEventHandler(this.BtnCruise_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnPort = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
            this.BtnPort.Click += new System.Windows.RoutedEventHandler(this.BtnPort_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnShip = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
            this.BtnShip.Click += new System.Windows.RoutedEventHandler(this.BtnShip_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btnback = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Page\MenuPage\MenuAdmin.xaml"
            this.Btnback.Click += new System.Windows.RoutedEventHandler(this.Btnback_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

