using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using HackerSharpAPI;

namespace HackerReader.iOS
{
	public partial class HackerReader_iOSViewController : DialogViewController
	{
		public HackerReader_iOSViewController () : base(UITableViewStyle.Plain, new RootElement("Hacker News"))
		{
		}

		public async override void LoadView ()
		{
			base.LoadView ();

			var news = await new HackerSharp().News();

			Root.Add (new Section ());

			foreach (var item in news) {
				Root [0].Add (new StyledStringElement (item.Title, delegate {
					NavigationController.PushViewController(new WebViewController(item.URL), true);
				}));
			}
		}
	}
}
