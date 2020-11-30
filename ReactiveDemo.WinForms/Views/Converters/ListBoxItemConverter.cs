using ReactiveUI;
using ReactiveUI.Winforms;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;

namespace ReactiveDemo.Views.Converters
{
	public class ListBoxItemConverter : IBindingTypeConverter
	{
		public int GetAffinityForObjects(Type fromType, Type toType)
		{
			if (toType != typeof(Control.ControlCollection))
			{
				return 0;
			}

			return fromType.GetInterface(@"IEnumerable") is null ? 0 : 10;
		}

		public bool TryConvert(object? from, Type toType, object? conversionHint, out object? result)
		{
			if (from is not IEnumerable enumerable)
			{
				result = null;
				return false;
			}

			result = enumerable.Cast<object?>().Select(viewModel => new ViewModelControlHost { ViewModel = viewModel, Dock = DockStyle.Top });
			return true;
		}
	}
}
