using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopDelegateLayout", DoNotGenerateAcw=true)]
	public partial class QMUIContinuousNestedTopDelegateLayout : global::Android.Widget.FrameLayout, global::AndroidX.Core.View.INestedScrollingChild2, global::AndroidX.Core.View.INestedScrollingParent2, global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/field[@name='KEY_SCROLL_INFO_OFFSET']"
		[Register ("KEY_SCROLL_INFO_OFFSET")]
		public const string KeyScrollInfoOffset = (string) "@qmui_scroll_info_top_dl_offset";

		public static class InterfaceConsts {

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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/QMUIContinuousNestedTopDelegateLayout", typeof (QMUIContinuousNestedTopDelegateLayout));
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

		protected QMUIContinuousNestedTopDelegateLayout (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/constructor[@name='QMUIContinuousNestedTopDelegateLayout' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIContinuousNestedTopDelegateLayout (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/constructor[@name='QMUIContinuousNestedTopDelegateLayout' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIContinuousNestedTopDelegateLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/constructor[@name='QMUIContinuousNestedTopDelegateLayout' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUIContinuousNestedTopDelegateLayout (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getContainerHeaderOffsetRange;
#pragma warning disable 0169
		static Delegate GetGetContainerHeaderOffsetRangeHandler ()
		{
			if (cb_getContainerHeaderOffsetRange == null)
				cb_getContainerHeaderOffsetRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContainerHeaderOffsetRange);
			return cb_getContainerHeaderOffsetRange;
		}

		static int n_GetContainerHeaderOffsetRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainerHeaderOffsetRange;
		}
#pragma warning restore 0169

		public virtual unsafe int ContainerHeaderOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getContainerHeaderOffsetRange' and count(parameter)=0]"
			[Register ("getContainerHeaderOffsetRange", "()I", "GetGetContainerHeaderOffsetRangeHandler")]
			get {
				const string __id = "getContainerHeaderOffsetRange.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getContainerOffsetCurrent;
#pragma warning disable 0169
		static Delegate GetGetContainerOffsetCurrentHandler ()
		{
			if (cb_getContainerOffsetCurrent == null)
				cb_getContainerOffsetCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContainerOffsetCurrent);
			return cb_getContainerOffsetCurrent;
		}

		static int n_GetContainerOffsetCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainerOffsetCurrent;
		}
#pragma warning restore 0169

		public virtual unsafe int ContainerOffsetCurrent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getContainerOffsetCurrent' and count(parameter)=0]"
			[Register ("getContainerOffsetCurrent", "()I", "GetGetContainerOffsetCurrentHandler")]
			get {
				const string __id = "getContainerOffsetCurrent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getContainerOffsetRange;
#pragma warning disable 0169
		static Delegate GetGetContainerOffsetRangeHandler ()
		{
			if (cb_getContainerOffsetRange == null)
				cb_getContainerOffsetRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetContainerOffsetRange);
			return cb_getContainerOffsetRange;
		}

		static int n_GetContainerOffsetRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContainerOffsetRange;
		}
#pragma warning restore 0169

		public virtual unsafe int ContainerOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getContainerOffsetRange' and count(parameter)=0]"
			[Register ("getContainerOffsetRange", "()I", "GetGetContainerOffsetRangeHandler")]
			get {
				const string __id = "getContainerOffsetRange.()I";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScroll;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getCurrentScroll' and count(parameter)=0]"
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

		static Delegate cb_getDelegateView;
#pragma warning disable 0169
		static Delegate GetGetDelegateViewHandler ()
		{
			if (cb_getDelegateView == null)
				cb_getDelegateView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDelegateView);
			return cb_getDelegateView;
		}

		static IntPtr n_GetDelegateView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DelegateView);
		}
#pragma warning restore 0169

		static Delegate cb_setDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_;
#pragma warning disable 0169
		static Delegate GetSetDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_Handler ()
		{
			if (cb_setDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_ == null)
				cb_setDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_);
			return cb_setDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_;
		}

		static void n_SetDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_delegateView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var delegateView = (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (native_delegateView, JniHandleOwnership.DoNotTransfer);
			__this.DelegateView = delegateView;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView DelegateView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getDelegateView' and count(parameter)=0]"
			[Register ("getDelegateView", "()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;", "GetGetDelegateViewHandler")]
			get {
				const string __id = "getDelegateView.()Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='setDelegateView' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedTopView']]"
			[Register ("setDelegateView", "(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;)V", "GetSetDelegateView_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedTopView_Handler")]
			set {
				const string __id = "setDelegateView.(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getFooterView;
#pragma warning disable 0169
		static Delegate GetGetFooterViewHandler ()
		{
			if (cb_getFooterView == null)
				cb_getFooterView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFooterView);
			return cb_getFooterView;
		}

		static IntPtr n_GetFooterView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FooterView);
		}
#pragma warning restore 0169

		static Delegate cb_setFooterView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetFooterView_Landroid_view_View_Handler ()
		{
			if (cb_setFooterView_Landroid_view_View_ == null)
				cb_setFooterView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFooterView_Landroid_view_View_);
			return cb_setFooterView_Landroid_view_View_;
		}

		static void n_SetFooterView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_footerView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var footerView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_footerView, JniHandleOwnership.DoNotTransfer);
			__this.FooterView = footerView;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View FooterView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getFooterView' and count(parameter)=0]"
			[Register ("getFooterView", "()Landroid/view/View;", "GetGetFooterViewHandler")]
			get {
				const string __id = "getFooterView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='setFooterView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setFooterView", "(Landroid/view/View;)V", "GetSetFooterView_Landroid_view_View_Handler")]
			set {
				const string __id = "setFooterView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getHeaderView;
#pragma warning disable 0169
		static Delegate GetGetHeaderViewHandler ()
		{
			if (cb_getHeaderView == null)
				cb_getHeaderView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHeaderView);
			return cb_getHeaderView;
		}

		static IntPtr n_GetHeaderView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderView);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetHeaderView_Landroid_view_View_Handler ()
		{
			if (cb_setHeaderView_Landroid_view_View_ == null)
				cb_setHeaderView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHeaderView_Landroid_view_View_);
			return cb_setHeaderView_Landroid_view_View_;
		}

		static void n_SetHeaderView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_headerView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var headerView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_headerView, JniHandleOwnership.DoNotTransfer);
			__this.HeaderView = headerView;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View HeaderView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getHeaderView' and count(parameter)=0]"
			[Register ("getHeaderView", "()Landroid/view/View;", "GetGetHeaderViewHandler")]
			get {
				const string __id = "getHeaderView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='setHeaderView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setHeaderView", "(Landroid/view/View;)V", "GetSetHeaderView_Landroid_view_View_Handler")]
			set {
				const string __id = "setHeaderView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollOffsetRange;
		}
#pragma warning restore 0169

		public virtual unsafe int ScrollOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='getScrollOffsetRange' and count(parameter)=0]"
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

		static Delegate cb_checkLayout;
#pragma warning disable 0169
		static Delegate GetCheckLayoutHandler ()
		{
			if (cb_checkLayout == null)
				cb_checkLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CheckLayout);
			return cb_checkLayout;
		}

		static void n_CheckLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='checkLayout' and count(parameter)=0]"
		[Register ("checkLayout", "()V", "GetCheckLayoutHandler")]
		public virtual unsafe void CheckLayout ()
		{
			const string __id = "checkLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_consumeScroll_I;
#pragma warning disable 0169
		static Delegate GetConsumeScroll_IHandler ()
		{
			if (cb_consumeScroll_I == null)
				cb_consumeScroll_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_ConsumeScroll_I);
			return cb_consumeScroll_I;
		}

		static int n_ConsumeScroll_I (IntPtr jnienv, IntPtr native__this, int dyUnconsumed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsumeScroll (dyUnconsumed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='consumeScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consumeScroll", "(I)I", "GetConsumeScroll_IHandler")]
		public virtual unsafe int ConsumeScroll (int dyUnconsumed)
		{
			const string __id = "consumeScroll.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dyUnconsumed);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dispatchNestedPreScroll_IIarrayIarrayII;
#pragma warning disable 0169
		static Delegate GetDispatchNestedPreScroll_IIarrayIarrayIIHandler ()
		{
			if (cb_dispatchNestedPreScroll_IIarrayIarrayII == null)
				cb_dispatchNestedPreScroll_IIarrayIarrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILLI_Z) n_DispatchNestedPreScroll_IIarrayIarrayII);
			return cb_dispatchNestedPreScroll_IIarrayIarrayII;
		}

		static bool n_DispatchNestedPreScroll_IIarrayIarrayII (IntPtr jnienv, IntPtr native__this, int dx, int dy, IntPtr native_consumed, IntPtr native_offsetInWindow, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var consumed = (int[]) JNIEnv.GetArray (native_consumed, JniHandleOwnership.DoNotTransfer, typeof (int));
			var offsetInWindow = (int[]) JNIEnv.GetArray (native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof (int));
			bool __ret = __this.DispatchNestedPreScroll (dx, dy, consumed, offsetInWindow, type);
			if (consumed != null)
				JNIEnv.CopyArray (consumed, native_consumed);
			if (offsetInWindow != null)
				JNIEnv.CopyArray (offsetInWindow, native_offsetInWindow);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='dispatchNestedPreScroll' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]'] and parameter[5][@type='int']]"
		[Register ("dispatchNestedPreScroll", "(II[I[II)Z", "GetDispatchNestedPreScroll_IIarrayIarrayIIHandler")]
		public virtual unsafe bool DispatchNestedPreScroll (int dx, int dy, int[] consumed, int[] offsetInWindow, int type)
		{
			const string __id = "dispatchNestedPreScroll.(II[I[II)Z";
			IntPtr native_consumed = JNIEnv.NewArray (consumed);
			IntPtr native_offsetInWindow = JNIEnv.NewArray (offsetInWindow);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (dx);
				__args [1] = new JniArgumentValue (dy);
				__args [2] = new JniArgumentValue (native_consumed);
				__args [3] = new JniArgumentValue (native_offsetInWindow);
				__args [4] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (consumed != null) {
					JNIEnv.CopyArray (native_consumed, consumed);
					JNIEnv.DeleteLocalRef (native_consumed);
				}
				if (offsetInWindow != null) {
					JNIEnv.CopyArray (native_offsetInWindow, offsetInWindow);
					JNIEnv.DeleteLocalRef (native_offsetInWindow);
				}
				global::System.GC.KeepAlive (consumed);
				global::System.GC.KeepAlive (offsetInWindow);
			}
		}

		static Delegate cb_dispatchNestedScroll_IIIIarrayII;
#pragma warning disable 0169
		static Delegate GetDispatchNestedScroll_IIIIarrayIIHandler ()
		{
			if (cb_dispatchNestedScroll_IIIIarrayII == null)
				cb_dispatchNestedScroll_IIIIarrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIIILI_Z) n_DispatchNestedScroll_IIIIarrayII);
			return cb_dispatchNestedScroll_IIIIarrayII;
		}

		static bool n_DispatchNestedScroll_IIIIarrayII (IntPtr jnienv, IntPtr native__this, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, IntPtr native_offsetInWindow, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var offsetInWindow = (int[]) JNIEnv.GetArray (native_offsetInWindow, JniHandleOwnership.DoNotTransfer, typeof (int));
			bool __ret = __this.DispatchNestedScroll (dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, offsetInWindow, type);
			if (offsetInWindow != null)
				JNIEnv.CopyArray (offsetInWindow, native_offsetInWindow);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='dispatchNestedScroll' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int[]'] and parameter[6][@type='int']]"
		[Register ("dispatchNestedScroll", "(IIII[II)Z", "GetDispatchNestedScroll_IIIIarrayIIHandler")]
		public virtual unsafe bool DispatchNestedScroll (int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int[] offsetInWindow, int type)
		{
			const string __id = "dispatchNestedScroll.(IIII[II)Z";
			IntPtr native_offsetInWindow = JNIEnv.NewArray (offsetInWindow);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (dxConsumed);
				__args [1] = new JniArgumentValue (dyConsumed);
				__args [2] = new JniArgumentValue (dxUnconsumed);
				__args [3] = new JniArgumentValue (dyUnconsumed);
				__args [4] = new JniArgumentValue (native_offsetInWindow);
				__args [5] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (offsetInWindow != null) {
					JNIEnv.CopyArray (native_offsetInWindow, offsetInWindow);
					JNIEnv.DeleteLocalRef (native_offsetInWindow);
				}
				global::System.GC.KeepAlive (offsetInWindow);
			}
		}

		static Delegate cb_hasNestedScrollingParent_I;
#pragma warning disable 0169
		static Delegate GetInvokeHasNestedScrollingParent_IHandler ()
		{
			if (cb_hasNestedScrollingParent_I == null)
				cb_hasNestedScrollingParent_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_InvokeHasNestedScrollingParent_I);
			return cb_hasNestedScrollingParent_I;
		}

		static bool n_InvokeHasNestedScrollingParent_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeHasNestedScrollingParent (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='hasNestedScrollingParent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasNestedScrollingParent", "(I)Z", "GetInvokeHasNestedScrollingParent_IHandler")]
		public virtual unsafe bool InvokeHasNestedScrollingParent (int type)
		{
			const string __id = "hasNestedScrollingParent.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var notifier = (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier> (native_notifier, JniHandleOwnership.DoNotTransfer);
			__this.InjectScrollNotifier (notifier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='injectScrollNotifier' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon.OnScrollNotifier']]"
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

		static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
#pragma warning disable 0169
		static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler ()
		{
			if (cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
				cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIILI_V) n_OnNestedPreScroll_Landroid_view_View_IIarrayII);
			return cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			var consumed = (int[]) JNIEnv.GetArray (native_consumed, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.OnNestedPreScroll (target, dx, dy, consumed, type);
			if (consumed != null)
				JNIEnv.CopyArray (consumed, native_consumed);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='onNestedPreScroll' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int']]"
		[Register ("onNestedPreScroll", "(Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler")]
		public virtual unsafe void OnNestedPreScroll (global::Android.Views.View target, int dx, int dy, int[] consumed, int type)
		{
			const string __id = "onNestedPreScroll.(Landroid/view/View;II[II)V";
			IntPtr native_consumed = JNIEnv.NewArray (consumed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (dx);
				__args [2] = new JniArgumentValue (dy);
				__args [3] = new JniArgumentValue (native_consumed);
				__args [4] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (consumed != null) {
					JNIEnv.CopyArray (native_consumed, consumed);
					JNIEnv.DeleteLocalRef (native_consumed);
				}
				global::System.GC.KeepAlive (target);
				global::System.GC.KeepAlive (consumed);
			}
		}

		static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;
#pragma warning disable 0169
		static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler ()
		{
			if (cb_onNestedScroll_Landroid_view_View_IIIII == null)
				cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIII_V) n_OnNestedScroll_Landroid_view_View_IIIII);
			return cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		static void n_OnNestedScroll_Landroid_view_View_IIIII (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnNestedScroll (target, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='onNestedScroll' and count(parameter)=6 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("onNestedScroll", "(Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIIHandler")]
		public virtual unsafe void OnNestedScroll (global::Android.Views.View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			const string __id = "onNestedScroll.(Landroid/view/View;IIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (dxConsumed);
				__args [2] = new JniArgumentValue (dyConsumed);
				__args [3] = new JniArgumentValue (dxUnconsumed);
				__args [4] = new JniArgumentValue (dyUnconsumed);
				__args [5] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler ()
		{
			if (cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
				cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II);
			return cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnNestedScrollAccepted (child, target, axes, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='onNestedScrollAccepted' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler")]
		public virtual unsafe void OnNestedScrollAccepted (global::Android.Views.View child, global::Android.Views.View target, int axes, int type)
		{
			const string __id = "onNestedScrollAccepted.(Landroid/view/View;Landroid/view/View;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (axes);
				__args [3] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler ()
		{
			if (cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
				cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_Z) n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II);
			return cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_child, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStartNestedScroll (child, target, axes, type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='onStartNestedScroll' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler")]
		public virtual unsafe bool OnStartNestedScroll (global::Android.Views.View child, global::Android.Views.View target, int axes, int type)
		{
			const string __id = "onStartNestedScroll.(Landroid/view/View;Landroid/view/View;II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((child == null) ? IntPtr.Zero : ((global::Java.Lang.Object) child).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [2] = new JniArgumentValue (axes);
				__args [3] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onStopNestedScroll_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler ()
		{
			if (cb_onStopNestedScroll_Landroid_view_View_I == null)
				cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnStopNestedScroll_Landroid_view_View_I);
			return cb_onStopNestedScroll_Landroid_view_View_I;
		}

		static void n_OnStopNestedScroll_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.OnStopNestedScroll (target, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='onStopNestedScroll' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onStopNestedScroll", "(Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroid_view_View_IHandler")]
		public virtual unsafe void OnStopNestedScroll (global::Android.Views.View target, int type)
		{
			const string __id = "onStopNestedScroll.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [1] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_postCheckLayout;
#pragma warning disable 0169
		static Delegate GetPostCheckLayoutHandler ()
		{
			if (cb_postCheckLayout == null)
				cb_postCheckLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PostCheckLayout);
			return cb_postCheckLayout;
		}

		static void n_PostCheckLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostCheckLayout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='postCheckLayout' and count(parameter)=0]"
		[Register ("postCheckLayout", "()V", "GetPostCheckLayoutHandler")]
		public virtual unsafe void PostCheckLayout ()
		{
			const string __id = "postCheckLayout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.RestoreScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='restoreScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.SaveScrollInfo (bundle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='saveScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
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

		static Delegate cb_startNestedScroll_II;
#pragma warning disable 0169
		static Delegate GetStartNestedScroll_IIHandler ()
		{
			if (cb_startNestedScroll_II == null)
				cb_startNestedScroll_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_StartNestedScroll_II);
			return cb_startNestedScroll_II;
		}

		static bool n_StartNestedScroll_II (IntPtr jnienv, IntPtr native__this, int native_axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var axes = (global::Android.Views.ScrollAxis) native_axes;
			return __this.StartNestedScroll (axes, type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='startNestedScroll' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("startNestedScroll", "(II)Z", "GetStartNestedScroll_IIHandler")]
		public virtual unsafe bool StartNestedScroll ([global::Android.Runtime.GeneratedEnum] global::Android.Views.ScrollAxis axes, int type)
		{
			const string __id = "startNestedScroll.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((int) axes);
				__args [1] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopNestedScroll_I;
#pragma warning disable 0169
		static Delegate GetStopNestedScroll_IHandler ()
		{
			if (cb_stopNestedScroll_I == null)
				cb_stopNestedScroll_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StopNestedScroll_I);
			return cb_stopNestedScroll_I;
		}

		static void n_StopNestedScroll_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.QMUIContinuousNestedTopDelegateLayout> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopNestedScroll (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/class[@name='QMUIContinuousNestedTopDelegateLayout']/method[@name='stopNestedScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stopNestedScroll", "(I)V", "GetStopNestedScroll_IHandler")]
		public virtual unsafe void StopNestedScroll (int type)
		{
			const string __id = "stopNestedScroll.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
