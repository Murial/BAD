#pragma checksum "..\..\Color.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2340F202D65217962571BAB1B896F0F0F7C05E80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using pertemuan6;


namespace pertemuan6
{


    /// <summary>
    /// Color
    /// </summary>
    public partial class RadioColor : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas bg;

#line default
#line hidden


#line 22 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton merah;

#line default
#line hidden


#line 23 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton kuning;

#line default
#line hidden


#line 24 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton biru;

#line default
#line hidden


#line 25 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton abu;

#line default
#line hidden


#line 26 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton hijau;

#line default
#line hidden


#line 27 "..\..\Color.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton putih;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/pertemuan6;component/color.xaml", System.UriKind.Relative);

#line 1 "..\..\Color.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.bg = ((System.Windows.Controls.Canvas)(target));
                    return;
                case 2:
                    this.merah = ((System.Windows.Controls.RadioButton)(target));

#line 22 "..\..\Color.xaml"
                    this.merah.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
                case 3:
                    this.kuning = ((System.Windows.Controls.RadioButton)(target));

#line 23 "..\..\Color.xaml"
                    this.kuning.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
                case 4:
                    this.biru = ((System.Windows.Controls.RadioButton)(target));

#line 24 "..\..\Color.xaml"
                    this.biru.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
                case 5:
                    this.abu = ((System.Windows.Controls.RadioButton)(target));

#line 25 "..\..\Color.xaml"
                    this.abu.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
                case 6:
                    this.hijau = ((System.Windows.Controls.RadioButton)(target));

#line 26 "..\..\Color.xaml"
                    this.hijau.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
                case 7:
                    this.putih = ((System.Windows.Controls.RadioButton)(target));

#line 27 "..\..\Color.xaml"
                    this.putih.Checked += new System.Windows.RoutedEventHandler(this.Color_Change);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
