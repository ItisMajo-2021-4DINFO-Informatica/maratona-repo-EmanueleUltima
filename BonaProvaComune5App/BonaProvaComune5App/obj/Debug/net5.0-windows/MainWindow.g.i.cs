// Updated by XamlIntelliSenseFileGenerator 17/02/2022 13:06:21
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1F39A9B5D17D7117B0CA0252C5868BFD75526E63"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using BonaProvaComune5App;
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


namespace BonaProvaComune5App
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLeggiDaFile;

#line default
#line hidden


#line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblAtleta;

#line default
#line hidden


#line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtAlbum;

#line default
#line hidden


#line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblNumBrani;

#line default
#line hidden


#line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnContaPiloti;

#line default
#line hidden


#line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblDurata;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BonaProvaComune5App;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BtnLeggiDaFile = ((System.Windows.Controls.Button)(target));

#line 10 "..\..\..\MainWindow.xaml"
                    this.BtnLeggiDaFile.Click += new System.Windows.RoutedEventHandler(this.BtnLeggiDaFile_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.DgElencoPiloti = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 3:
                    this.TxtTitolo = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.LblAtleta = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.BtnCercaAtleta = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\..\MainWindow.xaml"
                    this.BtnCercaAtleta.Click += new System.Windows.RoutedEventHandler(this.BtnCercaAtleta_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.TxtAlbum = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.LblNumBrani = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.BtnContaPiloti = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\..\MainWindow.xaml"
                    this.BtnContaPiloti.Click += new System.Windows.RoutedEventHandler(this.BtnContaPiloti_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.LblDurata = ((System.Windows.Controls.Label)(target));
                    return;
                case 10:
                    this.BtnDurata = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\MainWindow.xaml"
                    this.BtnDurata.Click += new System.Windows.RoutedEventHandler(this.BtnDurata_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid DgElencoAtleti;
        internal System.Windows.Controls.TextBox TxtCittà;
        internal System.Windows.Controls.TextBox TxtCittà;
        internal System.Windows.Controls.Button BtnCalcolaMinuti;
        internal System.Windows.Controls.TextBox TxtNome;
    }
}

