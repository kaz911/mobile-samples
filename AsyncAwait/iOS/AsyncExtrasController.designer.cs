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
	[Register ("AsyncExtrasController")]
	partial class AsyncExtrasController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CancelButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIProgressView ProgressBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView ProgressTextView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton StartButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView StatusTextView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
			if (ProgressBar != null) {
				ProgressBar.Dispose ();
				ProgressBar = null;
			}
			if (ProgressTextView != null) {
				ProgressTextView.Dispose ();
				ProgressTextView = null;
			}
			if (StartButton != null) {
				StartButton.Dispose ();
				StartButton = null;
			}
			if (StatusTextView != null) {
				StatusTextView.Dispose ();
				StatusTextView = null;
			}
		}
	}
}
