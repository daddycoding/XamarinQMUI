using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Link {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchDecorHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/link/QMUILinkTouchDecorHelper", DoNotGenerateAcw=true)]
	public partial class QMUILinkTouchDecorHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/link/QMUILinkTouchDecorHelper", typeof (QMUILinkTouchDecorHelper));
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

		protected QMUILinkTouchDecorHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchDecorHelper']/constructor[@name='QMUILinkTouchDecorHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUILinkTouchDecorHelper ()
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

		static Delegate cb_getPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetGetPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_getPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
				cb_getPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_GetPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_);
			return cb_getPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		static IntPtr n_GetPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textView, IntPtr native_spannable, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkTouchDecorHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var textView = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_textView, JniHandleOwnership.DoNotTransfer);
			var spannable = (global::Android.Text.ISpannable)global::Java.Lang.Object.GetObject<global::Android.Text.ISpannable> (native_spannable, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPressedSpan (textView, spannable, e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchDecorHelper']/method[@name='getPressedSpan' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.text.Spannable'] and parameter[3][@type='android.view.MotionEvent']]"
		[Register ("getPressedSpan", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Lcom/qmuiteam/qmui/link/ITouchableSpan;", "GetGetPressedSpan_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Link.ITouchableSpan GetPressedSpan (global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.Views.MotionEvent e)
		{
			const string __id = "getPressedSpan.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Lcom/qmuiteam/qmui/link/ITouchableSpan;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((textView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textView).Handle);
				__args [1] = new JniArgumentValue ((spannable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spannable).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.ITouchableSpan> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (textView);
				global::System.GC.KeepAlive (spannable);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_textView, IntPtr native_spannable, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Link.QMUILinkTouchDecorHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var textView = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_textView, JniHandleOwnership.DoNotTransfer);
			var spannable = (global::Android.Text.ISpannable)global::Java.Lang.Object.GetObject<global::Android.Text.ISpannable> (native_spannable, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (textView, spannable, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.link']/class[@name='QMUILinkTouchDecorHelper']/method[@name='onTouchEvent' and count(parameter)=3 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.text.Spannable'] and parameter[3][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_widget_TextView_Landroid_text_Spannable_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Widget.TextView textView, global::Android.Text.ISpannable spannable, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouchEvent.(Landroid/widget/TextView;Landroid/text/Spannable;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((textView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textView).Handle);
				__args [1] = new JniArgumentValue ((spannable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spannable).Handle);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (textView);
				global::System.GC.KeepAlive (spannable);
				global::System.GC.KeepAlive (e);
			}
		}

	}
}
