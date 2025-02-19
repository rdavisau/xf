using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.StyleSheets;

[assembly: InternalsVisibleTo("iOSUnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Controls")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Design")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.iOS.Classic")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Maps.Android")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.FlexLayout.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Material")]

[assembly: InternalsVisibleTo("Xamarin.Forms.Core.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.Windows.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Core.macOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.iOS.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Android.UITests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Loader")] // Xamarin.Forms.Loader.dll, Xamarin.Forms.Internals.ResourceLoader.ResourceProvider, kzu@microsoft.com
[assembly: InternalsVisibleTo("Xamarin.HotReload.Forms")]
[assembly: InternalsVisibleTo("Xamarin.Forms.UITest.Validator")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Build.Tasks")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Platform.iOS.modern forwarders")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages")]
[assembly: InternalsVisibleTo("Xamarin.Forms.Pages.UnitTests")]
[assembly: InternalsVisibleTo("Xamarin.Forms.CarouselView")]
[assembly: InternalsVisibleTo("Xamarin.Forms.DualScreen")]
[assembly: InternalsVisibleTo("Xamarin.Forms.DualScreen.UnitTests")]
[assembly: Preserve]

[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "Xamarin.Forms.Shapes")]
[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms", "Xamarin.Forms")]
[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms/design", "Xamarin.Forms.Shapes")]
[assembly: XmlnsDefinition("http://xamarin.com/schemas/2014/forms/design", "Xamarin.Forms")]
[assembly: XmlnsPrefix("http://xamarin.com/schemas/2014/forms", "xf")]
[assembly: XmlnsPrefix("http://xamarin.com/schemas/2014/forms/design", "d")]

[assembly: StyleProperty("background-color", typeof(VisualElement), nameof(VisualElement.BackgroundColorProperty))]
[assembly: StyleProperty("background", typeof(VisualElement), nameof(VisualElement.BackgroundProperty))]
[assembly: StyleProperty("background-image", typeof(Page), nameof(Page.BackgroundImageSourceProperty))]
[assembly: StyleProperty("border-color", typeof(IBorderElement), nameof(BorderElement.BorderColorProperty))]
[assembly: StyleProperty("border-radius", typeof(ICornerElement), nameof(CornerElement.CornerRadiusProperty))]
[assembly: StyleProperty("border-radius", typeof(Button), nameof(Button.CornerRadiusProperty))]
[assembly: StyleProperty("border-radius", typeof(Frame), nameof(Frame.CornerRadiusProperty))]
[assembly: StyleProperty("border-radius", typeof(ImageButton), nameof(BorderElement.CornerRadiusProperty))]
[assembly: StyleProperty("border-width", typeof(IBorderElement), nameof(BorderElement.BorderWidthProperty))]
[assembly: StyleProperty("color", typeof(IColorElement), nameof(ColorElement.ColorProperty), Inherited = true)]
[assembly: StyleProperty("color", typeof(ITextElement), nameof(TextElement.TextColorProperty), Inherited = true)]
[assembly: StyleProperty("text-transform", typeof(ITextElement), nameof(TextElement.TextTransformProperty), Inherited = true)]
[assembly: StyleProperty("color", typeof(ProgressBar), nameof(ProgressBar.ProgressColorProperty))]
[assembly: StyleProperty("color", typeof(Switch), nameof(Switch.OnColorProperty))]
[assembly: StyleProperty("column-gap", typeof(Grid), nameof(Grid.ColumnSpacingProperty))]
[assembly: StyleProperty("direction", typeof(VisualElement), nameof(VisualElement.FlowDirectionProperty), Inherited = true)]
[assembly: StyleProperty("font-family", typeof(IFontElement), nameof(FontElement.FontFamilyProperty), Inherited = true)]
[assembly: StyleProperty("font-size", typeof(IFontElement), nameof(FontElement.FontSizeProperty), Inherited = true)]
[assembly: StyleProperty("font-style", typeof(IFontElement), nameof(FontElement.FontAttributesProperty), Inherited = true)]
[assembly: StyleProperty("height", typeof(VisualElement), nameof(VisualElement.HeightRequestProperty))]
[assembly: StyleProperty("margin", typeof(View), nameof(View.MarginProperty))]
[assembly: StyleProperty("margin-left", typeof(View), nameof(View.MarginLeftProperty))]
[assembly: StyleProperty("margin-top", typeof(View), nameof(View.MarginTopProperty))]
[assembly: StyleProperty("margin-right", typeof(View), nameof(View.MarginRightProperty))]
[assembly: StyleProperty("margin-bottom", typeof(View), nameof(View.MarginBottomProperty))]
[assembly: StyleProperty("max-lines", typeof(Label), nameof(Label.MaxLinesProperty))]
[assembly: StyleProperty("min-height", typeof(VisualElement), nameof(VisualElement.MinimumHeightRequestProperty))]
[assembly: StyleProperty("min-width", typeof(VisualElement), nameof(VisualElement.MinimumWidthRequestProperty))]
[assembly: StyleProperty("opacity", typeof(VisualElement), nameof(VisualElement.OpacityProperty))]
[assembly: StyleProperty("padding", typeof(IPaddingElement), nameof(PaddingElement.PaddingProperty))]
[assembly: StyleProperty("padding-left", typeof(IPaddingElement), nameof(PaddingElement.PaddingLeftProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("padding-top", typeof(IPaddingElement), nameof(PaddingElement.PaddingTopProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("padding-right", typeof(IPaddingElement), nameof(PaddingElement.PaddingRightProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("padding-bottom", typeof(IPaddingElement), nameof(PaddingElement.PaddingBottomProperty), PropertyOwnerType = typeof(PaddingElement))]
[assembly: StyleProperty("row-gap", typeof(Grid), nameof(Grid.RowSpacingProperty))]
[assembly: StyleProperty("text-align", typeof(ITextAlignmentElement), nameof(TextAlignmentElement.HorizontalTextAlignmentProperty), Inherited = true)]
[assembly: StyleProperty("text-decoration", typeof(IDecorableTextElement), nameof(DecorableTextElement.TextDecorationsProperty))]
[assembly: StyleProperty("transform", typeof(VisualElement), nameof(VisualElement.TransformProperty))]
[assembly: StyleProperty("transform-origin", typeof(VisualElement), nameof(VisualElement.TransformOriginProperty))]
[assembly: StyleProperty("vertical-align", typeof(ITextAlignmentElement), nameof(TextAlignmentElement.VerticalTextAlignmentProperty))]
[assembly: StyleProperty("visibility", typeof(VisualElement), nameof(VisualElement.IsVisibleProperty), Inherited = true)]
[assembly: StyleProperty("width", typeof(VisualElement), nameof(VisualElement.WidthRequestProperty))]
[assembly: StyleProperty("letter-spacing", typeof(ITextElement), nameof(TextElement.CharacterSpacingProperty), Inherited = true)]
[assembly: StyleProperty("line-height", typeof(ILineHeightElement), nameof(LineHeightElement.LineHeightProperty), Inherited = true)]

//flex
[assembly: StyleProperty("align-content", typeof(FlexLayout), nameof(FlexLayout.AlignContentProperty))]
[assembly: StyleProperty("align-items", typeof(FlexLayout), nameof(FlexLayout.AlignItemsProperty))]
[assembly: StyleProperty("align-self", typeof(VisualElement), nameof(FlexLayout.AlignSelfProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-direction", typeof(FlexLayout), nameof(FlexLayout.DirectionProperty))]
[assembly: StyleProperty("flex-basis", typeof(VisualElement), nameof(FlexLayout.BasisProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-grow", typeof(VisualElement), nameof(FlexLayout.GrowProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-shrink", typeof(VisualElement), nameof(FlexLayout.ShrinkProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("flex-wrap", typeof(VisualElement), nameof(FlexLayout.WrapProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("justify-content", typeof(FlexLayout), nameof(FlexLayout.JustifyContentProperty))]
[assembly: StyleProperty("order", typeof(VisualElement), nameof(FlexLayout.OrderProperty), PropertyOwnerType = typeof(FlexLayout))]
[assembly: StyleProperty("position", typeof(FlexLayout), nameof(FlexLayout.PositionProperty))]

//xf specific
[assembly: StyleProperty("-xf-placeholder", typeof(IPlaceholderElement), nameof(PlaceholderElement.PlaceholderProperty))]
[assembly: StyleProperty("-xf-placeholder-color", typeof(IPlaceholderElement), nameof(PlaceholderElement.PlaceholderColorProperty))]
[assembly: StyleProperty("-xf-max-length", typeof(InputView), nameof(InputView.MaxLengthProperty))]
[assembly: StyleProperty("-xf-bar-background-color", typeof(IBarElement), nameof(BarElement.BarBackgroundColorProperty))]
[assembly: StyleProperty("-xf-bar-text-color", typeof(IBarElement), nameof(BarElement.BarTextColorProperty))]
[assembly: StyleProperty("-xf-orientation", typeof(ScrollView), nameof(ScrollView.OrientationProperty))]
[assembly: StyleProperty("-xf-horizontal-scroll-bar-visibility", typeof(ScrollView), nameof(ScrollView.HorizontalScrollBarVisibilityProperty))]
[assembly: StyleProperty("-xf-vertical-scroll-bar-visibility", typeof(ScrollView), nameof(ScrollView.VerticalScrollBarVisibilityProperty))]
[assembly: StyleProperty("-xf-min-track-color", typeof(Slider), nameof(Slider.MinimumTrackColorProperty))]
[assembly: StyleProperty("-xf-max-track-color", typeof(Slider), nameof(Slider.MaximumTrackColorProperty))]
[assembly: StyleProperty("-xf-thumb-color", typeof(Slider), nameof(Slider.ThumbColorProperty))]
[assembly: StyleProperty("-xf-spacing", typeof(StackLayout), nameof(StackLayout.SpacingProperty))]
[assembly: StyleProperty("-xf-orientation", typeof(StackLayout), nameof(StackLayout.OrientationProperty))]
[assembly: StyleProperty("-xf-visual", typeof(VisualElement), nameof(VisualElement.VisualProperty))]
[assembly: StyleProperty("-xf-vertical-text-alignment", typeof(Label), nameof(TextAlignmentElement.VerticalTextAlignmentProperty))]
[assembly: StyleProperty("-xf-thumb-color", typeof(Switch), nameof(Switch.ThumbColorProperty))]

//shell
[assembly: StyleProperty("-xf-flyout-background", typeof(Shell), nameof(Shell.FlyoutBackgroundColorProperty))]
[assembly: StyleProperty("-xf-shell-background", typeof(Element), nameof(Shell.BackgroundColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-disabled", typeof(Element), nameof(Shell.DisabledColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-foreground", typeof(Element), nameof(Shell.ForegroundColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-tabbar-background", typeof(Element), nameof(Shell.TabBarBackgroundColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-tabbar-disabled", typeof(Element), nameof(Shell.TabBarDisabledColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-tabbar-foreground", typeof(Element), nameof(Shell.TabBarForegroundColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-tabbar-title", typeof(Element), nameof(Shell.TabBarTitleColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-tabbar-unselected", typeof(Element), nameof(Shell.TabBarUnselectedColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-title", typeof(Element), nameof(Shell.TitleColorProperty), PropertyOwnerType = typeof(Shell))]
[assembly: StyleProperty("-xf-shell-unselected", typeof(Element), nameof(Shell.UnselectedColorProperty), PropertyOwnerType = typeof(Shell))]
