#pragma checksum "..\..\RentProperty.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C4426FC17A4A8BA71E090CECA7F6C8275B7D94849A4DDDBF9B529DA670AB2D84"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Sihle_POE_18012731;
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


namespace Sihle_POE_18012731 {
    
    
    /// <summary>
    /// RentProperty
    /// </summary>
    public partial class RentProperty : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRent;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSubmit;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Notify;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbyes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbno;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quitApplication;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\RentProperty.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rctVehicleReport;
        
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
            System.Uri resourceLocater = new System.Uri("/Sihle_POE_18012731;component/rentproperty.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RentProperty.xaml"
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
            this.txtRent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnSubmit = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\RentProperty.xaml"
            this.btnSubmit.Click += new System.Windows.RoutedEventHandler(this.btnSubmit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Notify = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.rdbyes = ((System.Windows.Controls.RadioButton)(target));
            
            #line 45 "..\..\RentProperty.xaml"
            this.rdbyes.Click += new System.Windows.RoutedEventHandler(this.rdbyes_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rdbno = ((System.Windows.Controls.RadioButton)(target));
            
            #line 46 "..\..\RentProperty.xaml"
            this.rdbno.Click += new System.Windows.RoutedEventHandler(this.rdbno_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.quitApplication = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\RentProperty.xaml"
            this.quitApplication.Click += new System.Windows.RoutedEventHandler(this.quitApplication_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\RentProperty.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.rctVehicleReport = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

