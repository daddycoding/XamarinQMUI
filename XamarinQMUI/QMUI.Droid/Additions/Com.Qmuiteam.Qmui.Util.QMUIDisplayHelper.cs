using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIDisplayHelper", DoNotGenerateAcw=true)]
	public partial class QMUIDisplayHelper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/field[@name='DENSITY']"
		[Register ("DENSITY")]
		public static float Density {
			get {
				const string __id = "DENSITY.F";

				var __v = _members.StaticFields.GetSingleValue (__id);
				return __v;
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIDisplayHelper", typeof (QMUIDisplayHelper));
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

		protected QMUIDisplayHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/constructor[@name='QMUIDisplayHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIDisplayHelper ()
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

		public static unsafe bool IsElevationSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isElevationSupported' and count(parameter)=0]"
			[Register ("isElevationSupported", "()Z", "")]
			get {
				const string __id = "isElevationSupported.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsSdcardReady {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isSdcardReady' and count(parameter)=0]"
			[Register ("isSdcardReady", "()Z", "")]
			get {
				const string __id = "isSdcardReady.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='cancelFullScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("cancelFullScreen", "(Landroid/app/Activity;)V", "")]
		public static unsafe void CancelFullScreen (global::Android.App.Activity activity)
		{
			const string __id = "cancelFullScreen.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='dp2px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dp2px", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Dp2px (global::Android.Content.Context context, int dp)
		{
			const string __id = "dp2px.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (dp);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='dpToPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dpToPx", "(I)I", "")]
		public static unsafe int DpToPx (int dpValue)
		{
			const string __id = "dpToPx.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dpValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getActionBarHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getActionBarHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetActionBarHeight (global::Android.Content.Context context)
		{
			const string __id = "getActionBarHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getCurCountryLan' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurCountryLan", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCurCountryLan (global::Android.Content.Context context)
		{
			const string __id = "getCurCountryLan.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getDensity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDensity", "(Landroid/content/Context;)F", "")]
		public static unsafe float GetDensity (global::Android.Content.Context context)
		{
			const string __id = "getDensity.(Landroid/content/Context;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getDisplayMetrics' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDisplayMetrics", "(Landroid/content/Context;)Landroid/util/DisplayMetrics;", "")]
		public static unsafe global::Android.Util.DisplayMetrics GetDisplayMetrics (global::Android.Content.Context context)
		{
			const string __id = "getDisplayMetrics.(Landroid/content/Context;)Landroid/util/DisplayMetrics;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Util.DisplayMetrics> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getFontDensity' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getFontDensity", "(Landroid/content/Context;)F", "")]
		public static unsafe float GetFontDensity (global::Android.Content.Context context)
		{
			const string __id = "getFontDensity.(Landroid/content/Context;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getNavMenuHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNavMenuHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNavMenuHeight (global::Android.Content.Context context)
		{
			const string __id = "getNavMenuHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getRealScreenSize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRealScreenSize", "(Landroid/content/Context;)[I", "")]
		public static unsafe int[] GetRealScreenSize (global::Android.Content.Context context)
		{
			const string __id = "getRealScreenSize.(Landroid/content/Context;)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getScreenHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenHeight (global::Android.Content.Context context)
		{
			const string __id = "getScreenHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getScreenWidth' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getScreenWidth", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetScreenWidth (global::Android.Content.Context context)
		{
			const string __id = "getScreenWidth.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getStatusBarHeight' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getStatusBarHeight", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetStatusBarHeight (global::Android.Content.Context context)
		{
			const string __id = "getStatusBarHeight.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getUsefulScreenHeight' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getUsefulScreenHeight", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetUsefulScreenHeight (global::Android.App.Activity activity)
		{
			const string __id = "getUsefulScreenHeight.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getUsefulScreenHeight' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getUsefulScreenHeight", "(Landroid/view/View;)I", "")]
		public static unsafe int GetUsefulScreenHeight (global::Android.Views.View view)
		{
			const string __id = "getUsefulScreenHeight.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getUsefulScreenWidth' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getUsefulScreenWidth", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetUsefulScreenWidth (global::Android.App.Activity activity)
		{
			const string __id = "getUsefulScreenWidth.(Landroid/app/Activity;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getUsefulScreenWidth' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("getUsefulScreenWidth", "(Landroid/content/Context;Z)I", "")]
		public static unsafe int GetUsefulScreenWidth (global::Android.Content.Context context, bool hasNotch)
		{
			const string __id = "getUsefulScreenWidth.(Landroid/content/Context;Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (hasNotch);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='getUsefulScreenWidth' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getUsefulScreenWidth", "(Landroid/view/View;)I", "")]
		public static unsafe int GetUsefulScreenWidth (global::Android.Views.View view)
		{
			const string __id = "getUsefulScreenWidth.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='hasCamera' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasCamera", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasCamera (global::Android.Content.Context context)
		{
			const string __id = "hasCamera.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='hasHardwareMenuKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasHardwareMenuKey", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasHardwareMenuKey (global::Android.Content.Context context)
		{
			const string __id = "hasHardwareMenuKey.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='hasInternet' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasInternet", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasInternet (global::Android.Content.Context context)
		{
			const string __id = "hasInternet.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='hasNavigationBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasNavigationBar", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasNavigationBar (global::Android.Content.Context context)
		{
			const string __id = "hasNavigationBar.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='hasStatusBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasStatusBar", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HasStatusBar (global::Android.Content.Context context)
		{
			const string __id = "hasStatusBar.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='huaweiIsNotchSetToShowInSetting' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("huaweiIsNotchSetToShowInSetting", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool HuaweiIsNotchSetToShowInSetting (global::Android.Content.Context context)
		{
			const string __id = "huaweiIsNotchSetToShowInSetting.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isFullScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isNavMenuExist' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNavMenuExist", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNavMenuExist (global::Android.Content.Context context)
		{
			const string __id = "isNavMenuExist.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isPackageExist' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("isPackageExist", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsPackageExist (global::Android.Content.Context context, string pckName)
		{
			const string __id = "isPackageExist.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_pckName = JNIEnv.NewString (pckName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_pckName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_pckName);
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='isZhCN' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isZhCN", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsZhCN (global::Android.Content.Context context)
		{
			const string __id = "isZhCN.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='px2dp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("px2dp", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Px2dp (global::Android.Content.Context context, int px)
		{
			const string __id = "px2dp.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='px2sp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("px2sp", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Px2sp (global::Android.Content.Context context, int px)
		{
			const string __id = "px2sp.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='pxToDp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("pxToDp", "(F)I", "")]
		public static unsafe int PxToDp (float pxValue)
		{
			const string __id = "pxToDp.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pxValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='setFullScreen' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setFullScreen", "(Landroid/app/Activity;)V", "")]
		public static unsafe void SetFullScreen (global::Android.App.Activity activity)
		{
			const string __id = "setFullScreen.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (activity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='sp2px' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("sp2px", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Sp2px (global::Android.Content.Context context, int sp)
		{
			const string __id = "sp2px.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (sp);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='vivoNavigationGestureEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("vivoNavigationGestureEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool VivoNavigationGestureEnabled (global::Android.Content.Context context)
		{
			const string __id = "vivoNavigationGestureEnabled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='xiaomiIsNotchSetToShowInSetting' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("xiaomiIsNotchSetToShowInSetting", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool XiaomiIsNotchSetToShowInSetting (global::Android.Content.Context context)
		{
			const string __id = "xiaomiIsNotchSetToShowInSetting.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIDisplayHelper']/method[@name='xiaomiNavigationGestureEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("xiaomiNavigationGestureEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool XiaomiNavigationGestureEnabled (global::Android.Content.Context context)
		{
			const string __id = "xiaomiNavigationGestureEnabled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
