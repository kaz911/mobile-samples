// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace iOS
{
	[Register ("iOSViewController")]
	partial class iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton BetterAsyncButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIImageView DownloadedImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UIButton GetButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UILabel ResultLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MonoTouch.UIKit.UITextView ResultTextView { get; set; }

		[Action ("GetButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void GetButton_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		[Action ("Naysync_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Naysync_TouchUpInside (MonoTouch.UIKit.UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (BetterAsyncButton != null) {
				BetterAsyncButton.Dispose ();
				BetterAsyncButton = null;
			}
			if (DownloadedImageView != null) {
				DownloadedImageView.Dispose ();
				DownloadedImageView = null;
			}
			if (GetButton != null) {
				GetButton.Dispose ();
				GetButton = null;
			}
			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
			if (ResultTextView != null) {
				ResultTextView.Dispose ();
				ResultTextView = null;
			}
		}
	}
}
