using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUIViewPager", DoNotGenerateAcw=true)]
	public partial class QMUIViewPager : global::AndroidX.ViewPager.Widget.ViewPager, global::Com.Qmuiteam.Qmui.Widget.IWindowInsetLayout {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUIViewPager", typeof (QMUIViewPager));
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

		protected QMUIViewPager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/constructor[@name='QMUIViewPager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIViewPager (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/constructor[@name='QMUIViewPager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIViewPager (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_isEnableLoop;
#pragma warning disable 0169
		static Delegate GetIsEnableLoopHandler ()
		{
			if (cb_isEnableLoop == null)
				cb_isEnableLoop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnableLoop);
			return cb_isEnableLoop;
		}

		static bool n_IsEnableLoop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableLoop;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableLoop_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableLoop_ZHandler ()
		{
			if (cb_setEnableLoop_Z == null)
				cb_setEnableLoop_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnableLoop_Z);
			return cb_setEnableLoop_Z;
		}

		static void n_SetEnableLoop_Z (IntPtr jnienv, IntPtr native__this, bool enableLoop)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLoop = enableLoop;
		}
#pragma warning restore 0169

		public virtual unsafe bool EnableLoop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='isEnableLoop' and count(parameter)=0]"
			[Register ("isEnableLoop", "()Z", "GetIsEnableLoopHandler")]
			get {
				const string __id = "isEnableLoop.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='setEnableLoop' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableLoop", "(Z)V", "GetSetEnableLoop_ZHandler")]
			set {
				const string __id = "setEnableLoop.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInfiniteRatio;
#pragma warning disable 0169
		static Delegate GetGetInfiniteRatioHandler ()
		{
			if (cb_getInfiniteRatio == null)
				cb_getInfiniteRatio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetInfiniteRatio);
			return cb_getInfiniteRatio;
		}

		static int n_GetInfiniteRatio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InfiniteRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setInfiniteRatio_I;
#pragma warning disable 0169
		static Delegate GetSetInfiniteRatio_IHandler ()
		{
			if (cb_setInfiniteRatio_I == null)
				cb_setInfiniteRatio_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetInfiniteRatio_I);
			return cb_setInfiniteRatio_I;
		}

		static void n_SetInfiniteRatio_I (IntPtr jnienv, IntPtr native__this, int infiniteRatio)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InfiniteRatio = infiniteRatio;
		}
#pragma warning restore 0169

		public virtual unsafe int InfiniteRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='getInfiniteRatio' and count(parameter)=0]"
			[Register ("getInfiniteRatio", "()I", "GetGetInfiniteRatioHandler")]
			get {
				const string __id = "getInfiniteRatio.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='setInfiniteRatio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setInfiniteRatio", "(I)V", "GetSetInfiniteRatio_IHandler")]
			set {
				const string __id = "setInfiniteRatio.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isInMeasure;
#pragma warning disable 0169
		static Delegate GetIsInMeasureHandler ()
		{
			if (cb_isInMeasure == null)
				cb_isInMeasure = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInMeasure);
			return cb_isInMeasure;
		}

		static bool n_IsInMeasure (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInMeasure;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInMeasure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='isInMeasure' and count(parameter)=0]"
			[Register ("isInMeasure", "()Z", "GetIsInMeasureHandler")]
			get {
				const string __id = "isInMeasure.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler ()
		{
			if (cb_applySystemWindowInsets19_Landroid_graphics_Rect_ == null)
				cb_applySystemWindowInsets19_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ApplySystemWindowInsets19_Landroid_graphics_Rect_);
			return cb_applySystemWindowInsets19_Landroid_graphics_Rect_;
		}

		static bool n_ApplySystemWindowInsets19_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_insets, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplySystemWindowInsets19 (insets);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='applySystemWindowInsets19' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("applySystemWindowInsets19", "(Landroid/graphics/Rect;)Z", "GetApplySystemWindowInsets19_Landroid_graphics_Rect_Handler")]
		public virtual unsafe bool ApplySystemWindowInsets19 (global::Android.Graphics.Rect insets)
		{
			const string __id = "applySystemWindowInsets19.(Landroid/graphics/Rect;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
#pragma warning disable 0169
		static Delegate GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler ()
		{
			if (cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ == null)
				cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_);
			return cb_applySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_;
		}

		static IntPtr n_ApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_insets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var insets = global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (native_insets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ApplySystemWindowInsets21 (insets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='applySystemWindowInsets21' and count(parameter)=1 and parameter[1][@type='androidx.core.view.WindowInsetsCompat']]"
		[Register ("applySystemWindowInsets21", "(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetApplySystemWindowInsets21_Landroidx_core_view_WindowInsetsCompat_Handler")]
		public virtual unsafe global::AndroidX.Core.View.WindowInsetsCompat ApplySystemWindowInsets21 (global::AndroidX.Core.View.WindowInsetsCompat insets)
		{
			const string __id = "applySystemWindowInsets21.(Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((insets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) insets).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AndroidX.Core.View.WindowInsetsCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (insets);
			}
		}

		static Delegate cb_setSwipeable_Z;
#pragma warning disable 0169
		static Delegate GetSetSwipeable_ZHandler ()
		{
			if (cb_setSwipeable_Z == null)
				cb_setSwipeable_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSwipeable_Z);
			return cb_setSwipeable_Z;
		}

		static void n_SetSwipeable_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUIViewPager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSwipeable (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUIViewPager']/method[@name='setSwipeable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSwipeable", "(Z)V", "GetSetSwipeable_ZHandler")]
		public virtual unsafe void SetSwipeable (bool enable)
		{
			const string __id = "setSwipeable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
