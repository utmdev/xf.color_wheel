//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("Utmdev.Xf.Components.Content.ColorWheel.xaml", "Content/ColorWheel.xaml", typeof(global::Utmdev.Xf.Components.ColorWheel))]

namespace Utmdev.Xf.Components {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Content/ColorWheel.xaml")]
    public partial class ColorWheel : global::Xamarin.Forms.ContentView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SkiaSharp.Views.Forms.SKCanvasView colorsCanvas;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SkiaSharp.Views.Forms.SKCanvasView pickerCanvas;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ColorWheel));
            colorsCanvas = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SkiaSharp.Views.Forms.SKCanvasView>(this, "colorsCanvas");
            pickerCanvas = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SkiaSharp.Views.Forms.SKCanvasView>(this, "pickerCanvas");
        }
    }
}
