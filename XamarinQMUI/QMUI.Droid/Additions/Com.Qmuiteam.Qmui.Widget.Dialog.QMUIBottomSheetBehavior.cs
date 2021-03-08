using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Dialog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"V extends android.view.ViewGroup"})]
	public partial class QMUIBottomSheetBehavior : global::Google.Android.Material.BottomSheet.BottomSheetBehavior {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetBehavior.DownDragDecisionMaker']"
		[Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker", "", "Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior/IDownDragDecisionMakerInvoker")]
		public partial interface IDownDragDecisionMaker : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/interface[@name='QMUIBottomSheetBehavior.DownDragDecisionMaker']/method[@name='canDrag' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.MotionEvent']]"
			[Register ("canDrag", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetCanDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler:Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior/IDownDragDecisionMakerInvoker, QMUI.Droid")]
			bool CanDrag (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout p0, global::Android.Views.View p1, global::Android.Views.MotionEvent p2);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker", DoNotGenerateAcw=true)]
		internal partial class IDownDragDecisionMakerInvoker : global::Java.Lang.Object, IDownDragDecisionMaker {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker", typeof (IDownDragDecisionMakerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IDownDragDecisionMaker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IDownDragDecisionMaker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetBehavior.DownDragDecisionMaker"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IDownDragDecisionMakerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetCanDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_CanDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_CanDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CanDrag (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
			public unsafe bool CanDrag (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout p0, global::Android.Views.View p1, global::Android.Views.MotionEvent p2)
			{
				if (id_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "canDrag", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canDrag_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_, __args);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior", typeof (QMUIBottomSheetBehavior));
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

		protected QMUIBottomSheetBehavior (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/constructor[@name='QMUIBottomSheetBehavior' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIBottomSheetBehavior ()
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

		static Delegate cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ == null)
				cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_);
			return cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_;
		}

		static bool n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_child, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnInterceptTouchEvent (parent, child, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/method[@name='onInterceptTouchEvent' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='V'] and parameter[3][@type='android.view.MotionEvent']]"
		[Register ("onInterceptTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnInterceptTouchEvent (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, global::Java.Lang.Object child, global::Android.Views.MotionEvent e)
		{
			const string __id = "onInterceptTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/MotionEvent;)Z";
			IntPtr native_child = JNIEnv.ToLocalJniHandle (child);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_child);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_child);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_IIHandler ()
		{
			if (cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II == null)
				cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLII_Z) n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II);
			return cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II;
		}

		static bool n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var coordinatorLayout = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_child, JniHandleOwnership.DoNotTransfer);
			var directTargetChild = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_directTargetChild, JniHandleOwnership.DoNotTransfer);
			var target = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_target, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnStartNestedScroll (coordinatorLayout, child, directTargetChild, target, axes, type);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/method[@name='onStartNestedScroll' and count(parameter)=6 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='V'] and parameter[3][@type='android.view.View'] and parameter[4][@type='android.view.View'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("onStartNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_View_IIHandler")]
		public virtual unsafe bool OnStartNestedScroll (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout coordinatorLayout, global::Java.Lang.Object child, global::Android.Views.View directTargetChild, global::Android.Views.View target, int axes, int type)
		{
			const string __id = "onStartNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/View;Landroid/view/View;II)Z";
			IntPtr native_child = JNIEnv.ToLocalJniHandle (child);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((coordinatorLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coordinatorLayout).Handle);
				__args [1] = new JniArgumentValue (native_child);
				__args [2] = new JniArgumentValue ((directTargetChild == null) ? IntPtr.Zero : ((global::Java.Lang.Object) directTargetChild).Handle);
				__args [3] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				__args [4] = new JniArgumentValue (axes);
				__args [5] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_child);
				global::System.GC.KeepAlive (coordinatorLayout);
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (directTargetChild);
				global::System.GC.KeepAlive (target);
			}
		}

		static Delegate cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout> (native_parent, JniHandleOwnership.DoNotTransfer);
			var child = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_child, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (parent, child, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/method[@name='onTouchEvent' and count(parameter)=3 and parameter[1][@type='androidx.coordinatorlayout.widget.CoordinatorLayout'] and parameter[2][@type='V'] and parameter[3][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_ViewGroup_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::AndroidX.CoordinatorLayout.Widget.CoordinatorLayout parent, global::Java.Lang.Object child, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/ViewGroup;Landroid/view/MotionEvent;)Z";
			IntPtr native_child = JNIEnv.ToLocalJniHandle (child);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (native_child);
				__args [2] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_child);
				global::System.GC.KeepAlive (parent);
				global::System.GC.KeepAlive (child);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_setAllowDrag_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowDrag_ZHandler ()
		{
			if (cb_setAllowDrag_Z == null)
				cb_setAllowDrag_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAllowDrag_Z);
			return cb_setAllowDrag_Z;
		}

		static void n_SetAllowDrag_Z (IntPtr jnienv, IntPtr native__this, bool allowDrag)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowDrag (allowDrag);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/method[@name='setAllowDrag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowDrag", "(Z)V", "GetSetAllowDrag_ZHandler")]
		public virtual unsafe void SetAllowDrag (bool allowDrag)
		{
			const string __id = "setAllowDrag.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (allowDrag);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_;
#pragma warning disable 0169
		static Delegate GetSetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_Handler ()
		{
			if (cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ == null)
				cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_);
			return cb_setDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_;
		}

		static void n_SetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_downDragDecisionMaker)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var downDragDecisionMaker = (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker> (native_downDragDecisionMaker, JniHandleOwnership.DoNotTransfer);
			__this.SetDownDragDecisionMaker (downDragDecisionMaker);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.dialog']/class[@name='QMUIBottomSheetBehavior']/method[@name='setDownDragDecisionMaker' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.dialog.QMUIBottomSheetBehavior.DownDragDecisionMaker']]"
		[Register ("setDownDragDecisionMaker", "(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker;)V", "GetSetDownDragDecisionMaker_Lcom_qmuiteam_qmui_widget_dialog_QMUIBottomSheetBehavior_DownDragDecisionMaker_Handler")]
		public virtual unsafe void SetDownDragDecisionMaker (global::Com.Qmuiteam.Qmui.Widget.Dialog.QMUIBottomSheetBehavior.IDownDragDecisionMaker downDragDecisionMaker)
		{
			const string __id = "setDownDragDecisionMaker.(Lcom/qmuiteam/qmui/widget/dialog/QMUIBottomSheetBehavior$DownDragDecisionMaker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((downDragDecisionMaker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downDragDecisionMaker).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (downDragDecisionMaker);
			}
		}

	}
}
