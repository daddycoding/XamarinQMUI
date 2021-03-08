using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/QMUIInterpolatorStaticHolder", DoNotGenerateAcw=true)]
	public partial class QMUIInterpolatorStaticHolder : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='ACCELERATE_DECELERATE_INTERPOLATOR']"
		[Register ("ACCELERATE_DECELERATE_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator AccelerateDecelerateInterpolator {
			get {
				const string __id = "ACCELERATE_DECELERATE_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='ACCELERATE_INTERPOLATOR']"
		[Register ("ACCELERATE_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator AccelerateInterpolator {
			get {
				const string __id = "ACCELERATE_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='DECELERATE_INTERPOLATOR']"
		[Register ("DECELERATE_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator DecelerateInterpolator {
			get {
				const string __id = "DECELERATE_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='FAST_OUT_LINEAR_IN_INTERPOLATOR']"
		[Register ("FAST_OUT_LINEAR_IN_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator FastOutLinearInInterpolator {
			get {
				const string __id = "FAST_OUT_LINEAR_IN_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='FAST_OUT_SLOW_IN_INTERPOLATOR']"
		[Register ("FAST_OUT_SLOW_IN_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator FastOutSlowInInterpolator {
			get {
				const string __id = "FAST_OUT_SLOW_IN_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='LINEAR_INTERPOLATOR']"
		[Register ("LINEAR_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator LinearInterpolator {
			get {
				const string __id = "LINEAR_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='LINEAR_OUT_SLOW_IN_INTERPOLATOR']"
		[Register ("LINEAR_OUT_SLOW_IN_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator LinearOutSlowInInterpolator {
			get {
				const string __id = "LINEAR_OUT_SLOW_IN_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/field[@name='QUNITIC_INTERPOLATOR']"
		[Register ("QUNITIC_INTERPOLATOR")]
		public static global::Android.Views.Animations.IInterpolator QuniticInterpolator {
			get {
				const string __id = "QUNITIC_INTERPOLATOR.Landroid/view/animation/Interpolator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/QMUIInterpolatorStaticHolder", typeof (QMUIInterpolatorStaticHolder));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected QMUIInterpolatorStaticHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUIInterpolatorStaticHolder']/constructor[@name='QMUIInterpolatorStaticHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIInterpolatorStaticHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
