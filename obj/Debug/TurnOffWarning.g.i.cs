﻿#pragma checksum "..\..\TurnOffWarning.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E08D588C70E23DA15B64B4A65EB76EE7"
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
using System.Windows.Forms.Integration;
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


namespace WPFTimer {
    
    
    /// <summary>
    /// TurnOffWarning
    /// </summary>
    public partial class TurnOffWarning : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\TurnOffWarning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtWarningTimer;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\TurnOffWarning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TurnOffWarning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn15min;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\TurnOffWarning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn30min;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\TurnOffWarning.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn1hour;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication1;component/turnoffwarning.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TurnOffWarning.xaml"
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
            
            #line 4 "..\..\TurnOffWarning.xaml"
            ((WPFTimer.TurnOffWarning)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtWarningTimer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\TurnOffWarning.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn15min = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\TurnOffWarning.xaml"
            this.btn15min.Click += new System.Windows.RoutedEventHandler(this.btn15min_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn30min = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\TurnOffWarning.xaml"
            this.btn30min.Click += new System.Windows.RoutedEventHandler(this.btn30min_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn1hour = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\TurnOffWarning.xaml"
            this.btn1hour.Click += new System.Windows.RoutedEventHandler(this.btn1hour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

