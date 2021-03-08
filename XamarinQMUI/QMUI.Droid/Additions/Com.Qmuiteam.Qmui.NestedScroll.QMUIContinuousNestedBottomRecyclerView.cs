using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomRecyclerView", DoNotGenerateAcw=true)]
	public partial class QMUIContinuousNestedBottomRecyclerView : global::AndroidX.RecyclerView.Widget.RecyclerView, global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/field[@name='KEY_SCROLL_INFO_OFFSET']"
		[Register ("KEY_SCROLL_INFO_OFFSET")]
		public const string KeyScrollInfoOffset = (string) "@qmui_scroll_info_bottom_rv_offset";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/field[@name='KEY_SCROLL_INFO_POSITION']"
		[Register ("KEY_SCROLL_INFO_POSITION")]
		public const string KeyScrollInfoPosition = (string) "@qmui_scroll_info_bottom_rv_pos";

		public static class InterfaceConsts {

			// The following are fields from: com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedBottomView

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/field[@name='HEIGHT_IS_ENOUGH_TO_SCROLL']"
			[Register ("HEIGHT_IS_ENOUGH_TO_SCROLL")]
			public const int HeightIsEnoughToScroll = (int) -1;

			// The following are fields from: com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/field[@name='SCROLL_STATE_DRAGGING']"
			[Register ("SCROLL_STATE_DRAGGING")]
			public const int ScrollStateDragging = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/field[@name='SCROLL_STATE_IDLE']"
			[Register ("SCROLL_STATE_IDLE")]
			public const int ScrollStateIdle = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/field[@name='SCROLL_STATE_SETTLING']"
			[Register ("SCROLL_STATE_SETTLING")]
			public const int ScrollStateSettling = (int) 2;
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedBottomRecyclerView", typeof (QMUIContinuousNestedBottomRecyclerView));
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

		protected QMUIContinuousNestedBottomRecyclerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/constructor[@name='QMUIContinuousNestedBottomRecyclerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIContinuousNestedBottomRecyclerView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/constructor[@name='QMUIContinuousNestedBottomRecyclerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIContinuousNestedBottomRecyclerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/constructor[@name='QMUIContinuousNestedBottomRecyclerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIContinuousNestedBottomRecyclerView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getContentHeight;
#pragma warning disable 0169
		static Delegate GetGetContentHeightHandler ()
		{
			if (cb_getContentHeight == null)
				cb_getContentHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContentHeight);
			return cb_getContentHeight;
		}

		static int n_GetContentHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int ContentHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='getContentHeight' and count(parameter)=0]"
			[Register ("getContentHeight", "()I", "GetGetContentHeightHandler")]
			get {
				const string __id = "getContentHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentScroll;
#pragma warning disable 0169
		static Delegate GetGetCurrentScrollHandler ()
		{
			if (cb_getCurrentScroll == null)
				cb_getCurrentScroll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentScroll);
			return cb_getCurrentScroll;
		}

		static int n_GetCurrentScroll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScroll;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='getCurrentScroll' and count(parameter)=0]"
			[Register ("getCurrentScroll", "()I", "GetGetCurrentScrollHandler")]
			get {
				const string __id = "getCurrentScroll.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScrollOffsetRange;
#pragma warning disable 0169
		static Delegate GetGetScrollOffsetRangeHandler ()
		{
			if (cb_getScrollOffsetRange == null)
				cb_getScrollOffsetRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetScrollOffsetRange);
			return cb_getScrollOffsetRange;
		}

		static int n_GetScrollOffsetRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollOffsetRange;
		}
#pragma warning restore 0169

		public virtual unsafe int ScrollOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='getScrollOffsetRange' and count(parameter)=0]"
			[Register ("getScrollOffsetRange", "()I", "GetGetScrollOffsetRangeHandler")]
			get {
				const string __id = "getScrollOffsetRange.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_consumeScroll_I;
#pragma warning disable 0169
		static Delegate GetConsumeScroll_IHandler ()
		{
			if (cb_consumeScroll_I == null)
				cb_consumeScroll_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ConsumeScroll_I);
			return cb_consumeScroll_I;
		}

		static void n_ConsumeScroll_I (IntPtr jnienv, IntPtr native__this, int yUnconsumed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeScroll (yUnconsumed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='consumeScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consumeScroll", "(I)V", "GetConsumeScroll_IHandler")]
		public virtual unsafe void ConsumeScroll (int yUnconsumed)
		{
			const string __id = "consumeScroll.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (yUnconsumed);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_;
#pragma warning disable 0169
		static Delegate GetInjectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_Handler ()
		{
			if (cb_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_ == null)
				cb_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_InjectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_);
			return cb_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_;
		}

		static void n_InjectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_notifier)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var notifier = (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier> (native_notifier, JniHandleOwnership.DoNotTransfer);
			__this.InjectScrollNotifier (notifier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='injectScrollNotifier' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon.OnScrollNotifier']]"
		[Register ("injectScrollNotifier", "(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier;)V", "GetInjectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_Handler")]
		public virtual unsafe void InjectScrollNotifier (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier notifier)
		{
			const string __id = "injectScrollNotifier.(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((notifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notifier).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (notifier);
			}
		}

		static Delegate cb_restoreScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRestoreScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_restoreScrollInfo_Landroid_os_Bundle_ == null)
				cb_restoreScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RestoreScrollInfo_Landroid_os_Bundle_);
			return cb_restoreScrollInfo_Landroid_os_Bundle_;
		}

		static void n_RestoreScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.RestoreScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='restoreScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreScrollInfo", "(Landroid/os/Bundle;)V", "GetRestoreScrollInfo_Landroid_os_Bundle_Handler")]
		public virtual unsafe void RestoreScrollInfo (global::Android.OS.Bundle bundle)
		{
			const string __id = "restoreScrollInfo.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_saveScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveScrollInfo_Landroid_os_Bundle_ == null)
				cb_saveScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveScrollInfo_Landroid_os_Bundle_);
			return cb_saveScrollInfo_Landroid_os_Bundle_;
		}

		static void n_SaveScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bundle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.SaveScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='saveScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveScrollInfo", "(Landroid/os/Bundle;)V", "GetSaveScrollInfo_Landroid_os_Bundle_Handler")]
		public virtual unsafe void SaveScrollInfo (global::Android.OS.Bundle bundle)
		{
			const string __id = "saveScrollInfo.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bundle);
			}
		}

		static Delegate cb_smoothScrollYBy_II;
#pragma warning disable 0169
		static Delegate GetSmoothScrollYBy_IIHandler ()
		{
			if (cb_smoothScrollYBy_II == null)
				cb_smoothScrollYBy_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SmoothScrollYBy_II);
			return cb_smoothScrollYBy_II;
		}

		static void n_SmoothScrollYBy_II (IntPtr jnienv, IntPtr native__this, int dy, int duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedBottomRecyclerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollYBy (dy, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedBottomRecyclerView']/method[@name='smoothScrollYBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollYBy", "(II)V", "GetSmoothScrollYBy_IIHandler")]
		public virtual unsafe void SmoothScrollYBy (int dy, int duration)
		{
			const string __id = "smoothScrollYBy.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dy);
				__args [1] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
