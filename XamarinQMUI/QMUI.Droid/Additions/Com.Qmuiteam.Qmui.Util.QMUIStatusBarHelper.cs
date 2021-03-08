using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIStatusBarHelper", DoNotGenerateAcw=true)]
	public partial class QMUIStatusBarHelper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/field[@name='sVirtualDensity']"
		[Register ("sVirtualDensity")]
		public static float SVirtualDensity {
			get {
				const string __id = "sVirtualDensity.F";

				var __v = _members.StaticFields.GetSingleValue (__id);
				return __v;
			}
			set {
				const string __id = "sVirtualDensity.F";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/field[@name='sVirtualDensityDpi']"
		[Register ("sVirtualDensityDpi")]
		public static float SVirtualDensityDpi {
			get {
				const string __id = "sVirtualDensityDpi.F";

				var __v = _members.StaticFields.GetSingleValue (__id);
				return __v;
			}
			set {
				const string __id = "sVirtualDensityDpi.F";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIStatusBarHelper", typeof (QMUIStatusBarHelper));
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

		protected QMUIStatusBarHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/constructor[@name='QMUIStatusBarHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIStatusBarHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='FlymeSetStatusBarLightMode' and count(parameter)=2 and parameter[1][@type='android.view.Window'] and parameter[2][@type='boolean']]"
		[Register ("FlymeSetStatusBarLightMode", "(Landroid/view/Window;Z)Z", "")]
		public static unsafe bool FlymeSetStatusBarLightMode (global::Android.Views.Window window, bool light)
		{
			const string __id = "FlymeSetStatusBarLightMode.(Landroid/view/Window;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue (light);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='MIUISetStatusBarLightMode' and count(parameter)=2 and parameter[1][@type='android.view.Window'] and parameter[2][@type='boolean']]"
		[Register ("MIUISetStatusBarLightMode", "(Landroid/view/Window;Z)Z", "")]
		public static unsafe bool MIUISetStatusBarLightMode (global::Android.Views.Window window, bool light)
		{
			const string __id = "MIUISetStatusBarLightMode.(Landroid/view/Window;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue (light);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='getStatusBarAPITransparentValue' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getStatusBarAPITransparentValue", "(Landroid/content/Context;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer GetStatusBarAPITransparentValue (global::Android.Content.Context context)
		{
			const string __id = "getStatusBarAPITransparentValue.(Landroid/content/Context;)Ljava/lang/Integer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='getStatusbarHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getStatusbarHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetStatusbarHeight (global::Android.Content.Context context)
		{
			const string __id = "getStatusbarHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='isFullScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("isFullScreen", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool IsFullScreen (global::Android.App.Activity activity)
		{
			const string __id = "isFullScreen.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='retainSystemUiFlag' and count(parameter)=3 and parameter[1][@type='android.view.Window'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("retainSystemUiFlag", "(Landroid/view/Window;II)I", "")]
		public static unsafe int RetainSystemUiFlag (global::Android.Views.Window window, int @out, int type)
		{
			const string __id = "retainSystemUiFlag.(Landroid/view/Window;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue (@out);
				__args [2] = new JniArgumentValue (type);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='setStatusBarDarkMode' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setStatusBarDarkMode", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool SetStatusBarDarkMode (global::Android.App.Activity activity)
		{
			const string __id = "setStatusBarDarkMode.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='setStatusBarLightMode' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setStatusBarLightMode", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool SetStatusBarLightMode (global::Android.App.Activity activity)
		{
			const string __id = "setStatusBarLightMode.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='setVirtualDensity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVirtualDensity", "(F)V", "")]
		public static unsafe void SetVirtualDensity (float density)
		{
			const string __id = "setVirtualDensity.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (density);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='setVirtualDensityDpi' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVirtualDensityDpi", "(F)V", "")]
		public static unsafe void SetVirtualDensityDpi (float densityDpi)
		{
			const string __id = "setVirtualDensityDpi.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (densityDpi);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='supportTransclentStatusBar6' and count(parameter)=0]"
		[Register ("supportTransclentStatusBar6", "()Z", "")]
		public static unsafe bool SupportTransclentStatusBar6 ()
		{
			const string __id = "supportTransclentStatusBar6.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='translucent' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("translucent", "(Landroid/app/Activity;)V", "")]
		public static unsafe void Translucent (global::Android.App.Activity activity)
		{
			const string __id = "translucent.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='translucent' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("translucent", "(Landroid/app/Activity;I)V", "")]
		public static unsafe void Translucent (global::Android.App.Activity activity, int colorOn5x)
		{
			const string __id = "translucent.(Landroid/app/Activity;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (colorOn5x);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='translucent' and count(parameter)=1 and parameter[1][@type='android.view.Window']]"
		[Register ("translucent", "(Landroid/view/Window;)V", "")]
		public static unsafe void Translucent (global::Android.Views.Window window)
		{
			const string __id = "translucent.(Landroid/view/Window;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIStatusBarHelper']/method[@name='translucent' and count(parameter)=2 and parameter[1][@type='android.view.Window'] and parameter[2][@type='int']]"
		[Register ("translucent", "(Landroid/view/Window;I)V", "")]
		public static unsafe void Translucent (global::Android.Views.Window window, int colorOn5x)
		{
			const string __id = "translucent.(Landroid/view/Window;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((window == null) ? IntPtr.Zero : ((global::Java.Lang.Object) window).Handle);
				__args [1] = new JniArgumentValue (colorOn5x);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (window);
			}
		}

	}
}
