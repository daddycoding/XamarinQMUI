using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUINotchHelper", DoNotGenerateAcw=true)]
	public partial class QMUINotchHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUINotchHelper", typeof (QMUINotchHelper));
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

		protected QMUINotchHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/constructor[@name='QMUINotchHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUINotchHelper ()
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

		public static unsafe bool IsNotchOfficialSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='isNotchOfficialSupport' and count(parameter)=0]"
			[Register ("isNotchOfficialSupport", "()Z", "")]
			get {
				const string __id = "isNotchOfficialSupport.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getNotchHeightInVivo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNotchHeightInVivo", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNotchHeightInVivo (global::Android.Content.Context context)
		{
			const string __id = "getNotchHeightInVivo.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getNotchHeightInXiaomi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNotchHeightInXiaomi", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNotchHeightInXiaomi (global::Android.Content.Context context)
		{
			const string __id = "getNotchHeightInXiaomi.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getNotchSizeInHuawei' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNotchSizeInHuawei", "(Landroid/content/Context;)[I", "")]
		public static unsafe int[] GetNotchSizeInHuawei (global::Android.Content.Context context)
		{
			const string __id = "getNotchSizeInHuawei.(Landroid/content/Context;)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getNotchWidthInVivo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNotchWidthInVivo", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNotchWidthInVivo (global::Android.Content.Context context)
		{
			const string __id = "getNotchWidthInVivo.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getNotchWidthInXiaomi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNotchWidthInXiaomi", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNotchWidthInXiaomi (global::Android.Content.Context context)
		{
			const string __id = "getNotchWidthInXiaomi.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetBottom' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getSafeInsetBottom", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetSafeInsetBottom (global::Android.App.Activity activity)
		{
			const string __id = "getSafeInsetBottom.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetBottom' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSafeInsetBottom", "(Landroid/view/View;)I", "")]
		public static unsafe int GetSafeInsetBottom (global::Android.Views.View view)
		{
			const string __id = "getSafeInsetBottom.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetLeft' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getSafeInsetLeft", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetSafeInsetLeft (global::Android.App.Activity activity)
		{
			const string __id = "getSafeInsetLeft.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetLeft' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSafeInsetLeft", "(Landroid/view/View;)I", "")]
		public static unsafe int GetSafeInsetLeft (global::Android.Views.View view)
		{
			const string __id = "getSafeInsetLeft.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetRight' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getSafeInsetRight", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetSafeInsetRight (global::Android.App.Activity activity)
		{
			const string __id = "getSafeInsetRight.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetRight' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSafeInsetRight", "(Landroid/view/View;)I", "")]
		public static unsafe int GetSafeInsetRight (global::Android.Views.View view)
		{
			const string __id = "getSafeInsetRight.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetTop' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getSafeInsetTop", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetSafeInsetTop (global::Android.App.Activity activity)
		{
			const string __id = "getSafeInsetTop.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='getSafeInsetTop' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSafeInsetTop", "(Landroid/view/View;)I", "")]
		public static unsafe int GetSafeInsetTop (global::Android.Views.View view)
		{
			const string __id = "getSafeInsetTop.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='has3rdNotch' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("has3rdNotch", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool Has3rdNotch (global::Android.Content.Context context)
		{
			const string __id = "has3rdNotch.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotch' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("hasNotch", "(Landroid/app/Activity;)Z", "")]
		public static unsafe bool HasNotch (global::Android.App.Activity activity)
		{
			const string __id = "hasNotch.(Landroid/app/Activity;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotch' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("hasNotch", "(Landroid/view/View;)Z", "")]
		public static unsafe bool HasNotch (global::Android.Views.View view)
		{
			const string __id = "hasNotch.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotchInHuawei' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasNotchInHuawei", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasNotchInHuawei (global::Android.Content.Context context)
		{
			const string __id = "hasNotchInHuawei.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotchInOppo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasNotchInOppo", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasNotchInOppo (global::Android.Content.Context context)
		{
			const string __id = "hasNotchInOppo.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotchInVivo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasNotchInVivo", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasNotchInVivo (global::Android.Content.Context context)
		{
			const string __id = "hasNotchInVivo.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='hasNotchInXiaomi' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasNotchInXiaomi", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasNotchInXiaomi (global::Android.Content.Context context)
		{
			const string __id = "hasNotchInXiaomi.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUINotchHelper']/method[@name='needFixLandscapeNotchAreaFitSystemWindow' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("needFixLandscapeNotchAreaFitSystemWindow", "(Landroid/view/View;)Z", "")]
		public static unsafe bool NeedFixLandscapeNotchAreaFitSystemWindow (global::Android.Views.View view)
		{
			const string __id = "needFixLandscapeNotchAreaFitSystemWindow.(Landroid/view/View;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
