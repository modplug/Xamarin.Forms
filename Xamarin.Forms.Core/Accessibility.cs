﻿﻿
namespace Xamarin.Forms
{
	public class Accessibility
	{
		public static readonly BindableProperty HintProperty = BindableProperty.Create("Hint", typeof(string), typeof(Element), default(string));

		public static readonly BindableProperty IsInAccessibleTreeProperty = BindableProperty.Create("IsInAccessibleTree", typeof(bool?), typeof(Element), null);

		public static readonly BindableProperty LabeledByProperty = BindableProperty.Create("LabeledBy", typeof(VisualElement), typeof(Element), default(VisualElement));

		public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(Element), default(string));


		public static string GetHint(BindableObject bindable)
		{
			return (string)bindable.GetValue(HintProperty);
		}

		public static bool? GetIsInAccessibleTree(BindableObject bindable)
		{
			return (bool?)bindable.GetValue(IsInAccessibleTreeProperty);
		}

		public static VisualElement GetLabeledBy(BindableObject bindable)
		{
			return (VisualElement)bindable.GetValue(LabeledByProperty);
		}

		public static string GetName(BindableObject bindable)
		{
			return (string)bindable.GetValue(NameProperty);
		}

		public static void SetHint(BindableObject bindable, string value)
		{
			bindable.SetValue(HintProperty, value);
		}

		public static void SetIsInAccessibleTree(BindableObject bindable, bool? value)
		{
			bindable.SetValue(IsInAccessibleTreeProperty, value);
		}

		public static void SetLabeledBy(BindableObject bindable, VisualElement value)
		{
			bindable.SetValue(LabeledByProperty, value);
		}

		public static void SetName(BindableObject bindable, string value)
		{
			bindable.SetValue(NameProperty, value);
		}
	}
}
