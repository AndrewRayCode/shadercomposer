﻿#pragma checksum "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED64242525D75E939E47DF98771D0637"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace Microsoft.Windows.Controls {
    
    
    /// <summary>
    /// RichTextBoxFormatBar
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class RichTextBoxFormatBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Microsoft.Windows.Controls.RichTextBoxFormatBar _window;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb _dragWidget;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cmbFontFamilies;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _cmbFontSizes;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton _btnBold;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton _btnItalic;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton _btnUnderline;
        
        #line default
        #line hidden
        
        
        #line 185 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _btnAlignLeft;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _btnAlignCenter;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton _btnAlignRight;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFToolkit.Extended;component/richtextboxformatbar/richtextboxformatbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._window = ((Microsoft.Windows.Controls.RichTextBoxFormatBar)(target));
            return;
            case 2:
            this._dragWidget = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 159 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
            this._dragWidget.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.DragWidget_DragDelta);
            
            #line default
            #line hidden
            return;
            case 3:
            this._cmbFontFamilies = ((System.Windows.Controls.ComboBox)(target));
            
            #line 164 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
            this._cmbFontFamilies.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this._cmbFontSizes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 166 "..\..\..\RichTextBoxFormatBar\RichTextBoxFormatBar.xaml"
            this._cmbFontSizes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this._btnBold = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 6:
            this._btnItalic = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 7:
            this._btnUnderline = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 8:
            this._btnAlignLeft = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this._btnAlignCenter = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 10:
            this._btnAlignRight = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

