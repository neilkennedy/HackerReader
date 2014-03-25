using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ReadSharp;

namespace HackerReader.iOS
{
	public partial class WebViewController : UIViewController
	{
		string _url;

		public WebViewController (string url) : base ()
		{
			_url = url;
		}

		public async override void LoadView ()
		{
			base.LoadView ();

			Reader reader = new Reader();
			Article article;

			try
			{
				article = await reader.Read(new Uri(_url));
				var webView = new UIWebView (View.Frame);
				webView.LoadHtmlString(article.Content, new NSUrl(_url));

				Add(webView);
			}
			catch (ReadException exc)
			{
				// handle exception
			}

		}
	}
}

