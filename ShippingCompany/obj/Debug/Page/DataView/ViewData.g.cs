﻿#pragma checksum "..\..\..\..\Page\DataView\ViewData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9209F1AB6F26657C4EF3220CCEB851404801C9B0E595C852BD09CA4A4F8E34BA"
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
    /// ViewData
    /// </summary>
    public partial class ViewData : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\Page\DataView\ViewData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridList;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Page\DataView\ViewData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Page\DataView\ViewData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCreate;
        
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
            System.Uri resourceLocater = new System.Uri("/ShippingCompany;component/page/dataview/viewdata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Page\DataView\ViewData.xaml"
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
            this.GridList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\Page\DataView\ViewData.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\Page\DataView\ViewData.xaml"
            this.BtnCreate.Click += new System.Windows.RoutedEventHandler(this.BtnCreate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

