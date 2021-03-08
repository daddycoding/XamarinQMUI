using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.RecyclerView {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction", DoNotGenerateAcw=true)]
	public partial class QMUIRVItemSwipeAction : global::AndroidX.RecyclerView.Widget.RecyclerView.ItemDecoration, global::AndroidX.RecyclerView.Widget.RecyclerView.IOnChildAttachStateChangeListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='ANIMATION_TYPE_SWIPE_ACTION']"
		[Register ("ANIMATION_TYPE_SWIPE_ACTION")]
		public const int AnimationTypeSwipeAction = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='ANIMATION_TYPE_SWIPE_CANCEL']"
		[Register ("ANIMATION_TYPE_SWIPE_CANCEL")]
		public const int AnimationTypeSwipeCancel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='ANIMATION_TYPE_SWIPE_SUCCESS']"
		[Register ("ANIMATION_TYPE_SWIPE_SUCCESS")]
		public const int AnimationTypeSwipeSuccess = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='SWIPE_DOWN']"
		[Register ("SWIPE_DOWN")]
		public const int SwipeDown = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='SWIPE_LEFT']"
		[Register ("SWIPE_LEFT")]
		public const int SwipeLeft = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='SWIPE_NONE']"
		[Register ("SWIPE_NONE")]
		public const int SwipeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='SWIPE_RIGHT']"
		[Register ("SWIPE_RIGHT")]
		public const int SwipeRight = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/field[@name='SWIPE_UP']"
		[Register ("SWIPE_UP")]
		public const int SwipeUp = (int) 3;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback", DoNotGenerateAcw=true)]
		public abstract partial class Callback : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/field[@name='DEFAULT_SWIPE_ANIMATION_DURATION']"
			[Register ("DEFAULT_SWIPE_ANIMATION_DURATION")]
			public const int DefaultSwipeAnimationDuration = (int) 250;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback", typeof (Callback));
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

			protected Callback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/constructor[@name='QMUIRVItemSwipeAction.Callback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Callback ()
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

			static Delegate cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
					cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_);
				return cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			static void n_ClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_viewHolder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				__this.ClearView (recyclerView, viewHolder);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='clearView' and count(parameter)=2 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder']]"
			[Register ("clearView", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public virtual unsafe void ClearView (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder)
			{
				const string __id = "clearView.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [1] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (recyclerView);
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF;
#pragma warning disable 0169
			static Delegate GetGetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFFHandler ()
			{
				if (cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF == null)
					cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIFF_J) n_GetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF);
				return cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF;
			}

			static long n_GetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int animationType, float animateDx, float animateDy)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				long __ret = __this.GetAnimationDuration (recyclerView, animationType, animateDx, animateDy);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getAnimationDuration' and count(parameter)=4 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("getAnimationDuration", "(Landroidx/recyclerview/widget/RecyclerView;IFF)J", "GetGetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFFHandler")]
			public virtual unsafe long GetAnimationDuration (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, int animationType, float animateDx, float animateDy)
			{
				const string __id = "getAnimationDuration.(Landroidx/recyclerview/widget/RecyclerView;IFF)J";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [1] = new JniArgumentValue (animationType);
					__args [2] = new JniArgumentValue (animateDx);
					__args [3] = new JniArgumentValue (animateDy);
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (recyclerView);
				}
			}

			static Delegate cb_getInterpolator_I;
#pragma warning disable 0169
			static Delegate GetGetInterpolator_IHandler ()
			{
				if (cb_getInterpolator_I == null)
					cb_getInterpolator_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetInterpolator_I);
				return cb_getInterpolator_I;
			}

			static IntPtr n_GetInterpolator_I (IntPtr jnienv, IntPtr native__this, int animationType)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetInterpolator (animationType));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getInterpolator' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getInterpolator", "(I)Landroid/animation/TimeInterpolator;", "GetGetInterpolator_IHandler")]
			public virtual unsafe global::Android.Animation.ITimeInterpolator GetInterpolator (int animationType)
			{
				const string __id = "getInterpolator.(I)Landroid/animation/TimeInterpolator;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (animationType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.Animation.ITimeInterpolator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetGetSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_getSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
					cb_getSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_GetSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_);
				return cb_getSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			static int n_GetSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_viewHolder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.GetSwipeDirection (recyclerView, viewHolder);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getSwipeDirection' and count(parameter)=2 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder']]"
			[Register ("getSwipeDirection", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)I", "GetGetSwipeDirection_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public virtual unsafe int GetSwipeDirection (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder)
			{
				const string __id = "getSwipeDirection.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [1] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (recyclerView);
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_getSwipeEscapeVelocity_F;
#pragma warning disable 0169
			static Delegate GetGetSwipeEscapeVelocity_FHandler ()
			{
				if (cb_getSwipeEscapeVelocity_F == null)
					cb_getSwipeEscapeVelocity_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_F) n_GetSwipeEscapeVelocity_F);
				return cb_getSwipeEscapeVelocity_F;
			}

			static float n_GetSwipeEscapeVelocity_F (IntPtr jnienv, IntPtr native__this, float defaultValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSwipeEscapeVelocity (defaultValue);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getSwipeEscapeVelocity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getSwipeEscapeVelocity", "(F)F", "GetGetSwipeEscapeVelocity_FHandler")]
			public virtual unsafe float GetSwipeEscapeVelocity (float defaultValue)
			{
				const string __id = "getSwipeEscapeVelocity.(F)F";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (defaultValue);
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetGetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
					cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_);
				return cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			static float n_GetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				float __ret = __this.GetSwipeThreshold (viewHolder);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getSwipeThreshold' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder']]"
			[Register ("getSwipeThreshold", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F", "GetGetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public virtual unsafe float GetSwipeThreshold (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder)
			{
				const string __id = "getSwipeThreshold.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_getSwipeVelocityThreshold_F;
#pragma warning disable 0169
			static Delegate GetGetSwipeVelocityThreshold_FHandler ()
			{
				if (cb_getSwipeVelocityThreshold_F == null)
					cb_getSwipeVelocityThreshold_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_F) n_GetSwipeVelocityThreshold_F);
				return cb_getSwipeVelocityThreshold_F;
			}

			static float n_GetSwipeVelocityThreshold_F (IntPtr jnienv, IntPtr native__this, float defaultValue)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSwipeVelocityThreshold (defaultValue);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='getSwipeVelocityThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("getSwipeVelocityThreshold", "(F)F", "GetGetSwipeVelocityThreshold_FHandler")]
			public virtual unsafe float GetSwipeVelocityThreshold (float defaultValue)
			{
				const string __id = "getSwipeVelocityThreshold.(F)F";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (defaultValue);
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_isOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI;
#pragma warning disable 0169
			static Delegate GetIsOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIHandler ()
			{
				if (cb_isOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI == null)
					cb_isOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFFI_Z) n_IsOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI);
				return cb_isOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI;
			}

			static bool n_IsOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFI (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_viewHolder, float dx, float dy, int swipeDirection)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.IsOverThreshold (recyclerView, viewHolder, dx, dy, swipeDirection);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='isOverThreshold' and count(parameter)=5 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int']]"
			[Register ("isOverThreshold", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFI)Z", "GetIsOverThreshold_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIHandler")]
			protected virtual unsafe bool IsOverThreshold (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder, float dx, float dy, int swipeDirection)
			{
				const string __id = "isOverThreshold.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFI)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [5];
					__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [1] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					__args [2] = new JniArgumentValue (dx);
					__args [3] = new JniArgumentValue (dy);
					__args [4] = new JniArgumentValue (swipeDirection);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (recyclerView);
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI;
#pragma warning disable 0169
			static Delegate GetOnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZIHandler ()
			{
				if (cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI == null)
					cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLFFZI_V) n_OnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI);
				return cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI;
			}

			static void n_OnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZI (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_recyclerView, IntPtr native_viewHolder, float dX, float dY, bool isCurrentlyActive, int swipeDirection)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				__this.OnChildDraw (c, recyclerView, viewHolder, dX, dY, isCurrentlyActive, swipeDirection);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onChildDraw' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[3][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='boolean'] and parameter[7][@type='int']]"
			[Register ("onChildDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFZI)V", "GetOnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZIHandler")]
			public virtual unsafe void OnChildDraw (global::Android.Graphics.Canvas c, global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder, float dX, float dY, bool isCurrentlyActive, int swipeDirection)
			{
				const string __id = "onChildDraw.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFZI)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [7];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [2] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					__args [3] = new JniArgumentValue (dX);
					__args [4] = new JniArgumentValue (dY);
					__args [5] = new JniArgumentValue (isCurrentlyActive);
					__args [6] = new JniArgumentValue (swipeDirection);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (c);
					global::System.GC.KeepAlive (recyclerView);
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ;
#pragma warning disable 0169
			static Delegate GetOnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZHandler ()
			{
				if (cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ == null)
					cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLFFZ_V) n_OnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ);
				return cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ;
			}

			static void n_OnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_recyclerView, IntPtr native_viewHolder, float dX, float dY, bool isCurrentlyActive)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
				var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				__this.OnChildDrawOver (c, recyclerView, viewHolder, dX, dY, isCurrentlyActive);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onChildDrawOver' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[3][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='boolean']]"
			[Register ("onChildDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFZ)V", "GetOnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFZHandler")]
			public virtual unsafe void OnChildDrawOver (global::Android.Graphics.Canvas c, global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder, float dX, float dY, bool isCurrentlyActive)
			{
				const string __id = "onChildDrawOver.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFZ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
					__args [1] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
					__args [2] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					__args [3] = new JniArgumentValue (dX);
					__args [4] = new JniArgumentValue (dY);
					__args [5] = new JniArgumentValue (isCurrentlyActive);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (c);
					global::System.GC.KeepAlive (recyclerView);
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_onClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_;
#pragma warning disable 0169
			static Delegate GetOnClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_Handler ()
			{
				if (cb_onClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ == null)
					cb_onClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_);
				return cb_onClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_;
			}

			static void n_OnClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_swipeAction, IntPtr native_selected, IntPtr native_action)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var swipeAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (native_swipeAction, JniHandleOwnership.DoNotTransfer);
				var selected = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_selected, JniHandleOwnership.DoNotTransfer);
				var action = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction> (native_action, JniHandleOwnership.DoNotTransfer);
				__this.OnClickAction (swipeAction, selected, action);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onClickAction' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.recyclerView.QMUIRVItemSwipeAction'] and parameter[2][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[3][@type='com.qmuiteam.qmui.recyclerView.QMUISwipeAction']]"
			[Register ("onClickAction", "(Lcom/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;)V", "GetOnClickAction_Lcom_qmuiteam_qmui_recyclerView_QMUIRVItemSwipeAction_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Lcom_qmuiteam_qmui_recyclerView_QMUISwipeAction_Handler")]
			public virtual unsafe void OnClickAction (global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction swipeAction, global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder selected, global::Com.Qmuiteam.Qmui.RecyclerView.QMUISwipeAction action)
			{
				const string __id = "onClickAction.(Lcom/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Lcom/qmuiteam/qmui/recyclerView/QMUISwipeAction;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((swipeAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) swipeAction).Handle);
					__args [1] = new JniArgumentValue ((selected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selected).Handle);
					__args [2] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (swipeAction);
					global::System.GC.KeepAlive (selected);
					global::System.GC.KeepAlive (action);
				}
			}

			static Delegate cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
#pragma warning disable 0169
			static Delegate GetOnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler ()
			{
				if (cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
					cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_);
				return cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			static void n_OnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selected)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var selected = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_selected, JniHandleOwnership.DoNotTransfer);
				__this.OnSelectedChanged (selected);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onSelectedChanged' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder']]"
			[Register ("onSelectedChanged", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetOnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public virtual unsafe void OnSelectedChanged (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder selected)
			{
				const string __id = "onSelectedChanged.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((selected == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selected).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (selected);
				}
			}

			static Delegate cb_onStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
			static Delegate GetOnStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler ()
			{
				if (cb_onStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
					cb_onStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I);
				return cb_onStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			static void n_OnStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, int direction)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				__this.OnStartSwipeAnimation (viewHolder, direction);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onStartSwipeAnimation' and count(parameter)=2 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
			[Register ("onStartSwipeAnimation", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnStartSwipeAnimation_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public virtual unsafe void OnStartSwipeAnimation (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder, int direction)
			{
				const string __id = "onStartSwipeAnimation.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					__args [1] = new JniArgumentValue (direction);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (viewHolder);
				}
			}

			static Delegate cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
			static Delegate GetOnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler ()
			{
				if (cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
					cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I);
				return cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			static void n_OnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, int direction)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var viewHolder = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder> (native_viewHolder, JniHandleOwnership.DoNotTransfer);
				__this.OnSwiped (viewHolder, direction);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction.Callback']/method[@name='onSwiped' and count(parameter)=2 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
			[Register ("onSwiped", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public virtual unsafe void OnSwiped (global::AndroidX.RecyclerView.Widget.RecyclerView.ViewHolder viewHolder, int direction)
			{
				const string __id = "onSwiped.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((viewHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewHolder).Handle);
					__args [1] = new JniArgumentValue (direction);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (viewHolder);
				}
			}

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback", DoNotGenerateAcw=true)]
		internal partial class CallbackInvoker : Callback {

			public CallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback", typeof (CallbackInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction", typeof (QMUIRVItemSwipeAction));
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

		protected QMUIRVItemSwipeAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/constructor[@name='QMUIRVItemSwipeAction' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.qmuiteam.qmui.recyclerView.QMUIRVItemSwipeAction.Callback']]"
		[Register (".ctor", "(ZLcom/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback;)V", "")]
		public unsafe QMUIRVItemSwipeAction (bool swipeDeleteWhenOnlyOneAction, global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction.Callback @callback)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLcom/qmuiteam/qmui/recyclerView/QMUIRVItemSwipeAction$Callback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (swipeDeleteWhenOnlyOneAction);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
#pragma warning disable 0169
		static Delegate GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler ()
		{
			if (cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ == null)
				cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_);
			return cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
		}

		static void n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var recyclerView = global::Java.Lang.Object.GetObject<global::AndroidX.RecyclerView.Widget.RecyclerView> (native_recyclerView, JniHandleOwnership.DoNotTransfer);
			__this.AttachToRecyclerView (recyclerView);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/method[@name='attachToRecyclerView' and count(parameter)=1 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView']]"
		[Register ("attachToRecyclerView", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler")]
		public virtual unsafe void AttachToRecyclerView (global::AndroidX.RecyclerView.Widget.RecyclerView recyclerView)
		{
			const string __id = "attachToRecyclerView.(Landroidx/recyclerview/widget/RecyclerView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((recyclerView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recyclerView).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (recyclerView);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onChildViewAttachedToWindow_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnChildViewAttachedToWindow_Landroid_view_View_Handler ()
		{
			if (cb_onChildViewAttachedToWindow_Landroid_view_View_ == null)
				cb_onChildViewAttachedToWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnChildViewAttachedToWindow_Landroid_view_View_);
			return cb_onChildViewAttachedToWindow_Landroid_view_View_;
		}

		static void n_OnChildViewAttachedToWindow_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnChildViewAttachedToWindow (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/method[@name='onChildViewAttachedToWindow' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onChildViewAttachedToWindow", "(Landroid/view/View;)V", "GetOnChildViewAttachedToWindow_Landroid_view_View_Handler")]
		public virtual unsafe void OnChildViewAttachedToWindow (global::Android.Views.View view)
		{
			const string __id = "onChildViewAttachedToWindow.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onChildViewDetachedFromWindow_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler ()
		{
			if (cb_onChildViewDetachedFromWindow_Landroid_view_View_ == null)
				cb_onChildViewDetachedFromWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnChildViewDetachedFromWindow_Landroid_view_View_);
			return cb_onChildViewDetachedFromWindow_Landroid_view_View_;
		}

		static void n_OnChildViewDetachedFromWindow_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnChildViewDetachedFromWindow (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/method[@name='onChildViewDetachedFromWindow' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("onChildViewDetachedFromWindow", "(Landroid/view/View;)V", "GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler")]
		public virtual unsafe void OnChildViewDetachedFromWindow (global::Android.Views.View view)
		{
			const string __id = "onChildViewDetachedFromWindow.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_setPressTimeToSwipe_J;
#pragma warning disable 0169
		static Delegate GetSetPressTimeToSwipe_JHandler ()
		{
			if (cb_setPressTimeToSwipe_J == null)
				cb_setPressTimeToSwipe_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetPressTimeToSwipe_J);
			return cb_setPressTimeToSwipe_J;
		}

		static void n_SetPressTimeToSwipe_J (IntPtr jnienv, IntPtr native__this, long pressTimeToSwipe)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.RecyclerView.QMUIRVItemSwipeAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPressTimeToSwipe (pressTimeToSwipe);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.recyclerView']/class[@name='QMUIRVItemSwipeAction']/method[@name='setPressTimeToSwipe' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setPressTimeToSwipe", "(J)V", "GetSetPressTimeToSwipe_JHandler")]
		public virtual unsafe void SetPressTimeToSwipe (long pressTimeToSwipe)
		{
			const string __id = "setPressTimeToSwipe.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pressTimeToSwipe);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
