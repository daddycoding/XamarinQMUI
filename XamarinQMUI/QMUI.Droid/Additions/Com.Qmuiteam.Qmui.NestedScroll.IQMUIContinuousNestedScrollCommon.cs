using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon.OnScrollNotifier']"
	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier", "", "Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker")]
	public partial interface IQMUIContinuousNestedScrollCommonOnScrollNotifier : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon.OnScrollNotifier']/method[@name='notify' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("notify", "(II)V", "GetNotify_IIHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker, QMUI.Droid")]
		void Notify (int innerOffset, int innerRange);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon.OnScrollNotifier']/method[@name='onScrollStateChange' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("onScrollStateChange", "(Landroid/view/View;I)V", "GetOnScrollStateChange_Landroid_view_View_IHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker, QMUI.Droid")]
		void OnScrollStateChange (global::Android.Views.View p0, int p1);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier", DoNotGenerateAcw=true)]
	internal partial class IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker : global::Java.Lang.Object, IQMUIContinuousNestedScrollCommonOnScrollNotifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier", typeof (IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker));

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

		public static IQMUIContinuousNestedScrollCommonOnScrollNotifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIContinuousNestedScrollCommonOnScrollNotifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon.OnScrollNotifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIContinuousNestedScrollCommonOnScrollNotifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_notify_II;
#pragma warning disable 0169
		static Delegate GetNotify_IIHandler ()
		{
			if (cb_notify_II == null)
				cb_notify_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Notify_II);
			return cb_notify_II;
		}

		static void n_Notify_II (IntPtr jnienv, IntPtr native__this, int innerOffset, int innerRange)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Notify (innerOffset, innerRange);
		}
#pragma warning restore 0169

		IntPtr id_notify_II;
		public unsafe void Notify (int innerOffset, int innerRange)
		{
			if (id_notify_II == IntPtr.Zero)
				id_notify_II = JNIEnv.GetMethodID (class_ref, "notify", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (innerOffset);
			__args [1] = new JValue (innerRange);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notify_II, __args);
		}

		static Delegate cb_onScrollStateChange_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetOnScrollStateChange_Landroid_view_View_IHandler ()
		{
			if (cb_onScrollStateChange_Landroid_view_View_I == null)
				cb_onScrollStateChange_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnScrollStateChange_Landroid_view_View_I);
			return cb_onScrollStateChange_Landroid_view_View_I;
		}

		static void n_OnScrollStateChange_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnScrollStateChange (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onScrollStateChange_Landroid_view_View_I;
		public unsafe void OnScrollStateChange (global::Android.Views.View p0, int p1)
		{
			if (id_onScrollStateChange_Landroid_view_View_I == IntPtr.Zero)
				id_onScrollStateChange_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "onScrollStateChange", "(Landroid/view/View;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onScrollStateChange_Landroid_view_View_I, __args);
		}

	}


	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon", DoNotGenerateAcw=true)]
	public abstract class QMUIContinuousNestedScrollCommon : Java.Lang.Object {

		internal QMUIContinuousNestedScrollCommon ()
		{
		}

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

	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'QMUIContinuousNestedScrollCommon' type. This type will be removed in a future release.", error: true)]
	public abstract class QMUIContinuousNestedScrollCommonConsts : QMUIContinuousNestedScrollCommon {

		private QMUIContinuousNestedScrollCommonConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']"
	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon", "", "Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonInvoker")]
	public partial interface IQMUIContinuousNestedScrollCommon : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/method[@name='injectScrollNotifier' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon.OnScrollNotifier']]"
		[Register ("injectScrollNotifier", "(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier;)V", "GetInjectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_Handler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonInvoker, QMUI.Droid")]
		void InjectScrollNotifier (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier notifier);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/method[@name='restoreScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("restoreScrollInfo", "(Landroid/os/Bundle;)V", "GetRestoreScrollInfo_Landroid_os_Bundle_Handler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonInvoker, QMUI.Droid")]
		void RestoreScrollInfo (global::Android.OS.Bundle p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedScrollCommon']/method[@name='saveScrollInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("saveScrollInfo", "(Landroid/os/Bundle;)V", "GetSaveScrollInfo_Landroid_os_Bundle_Handler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonInvoker, QMUI.Droid")]
		void SaveScrollInfo (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon", DoNotGenerateAcw=true)]
	internal partial class IQMUIContinuousNestedScrollCommonInvoker : global::Java.Lang.Object, IQMUIContinuousNestedScrollCommon {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon", typeof (IQMUIContinuousNestedScrollCommonInvoker));

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

		public static IQMUIContinuousNestedScrollCommon GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIContinuousNestedScrollCommon> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedScrollCommon"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIContinuousNestedScrollCommonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var notifier = (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier> (native_notifier, JniHandleOwnership.DoNotTransfer);
			__this.InjectScrollNotifier (notifier);
		}
#pragma warning restore 0169

		IntPtr id_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_;
		public unsafe void InjectScrollNotifier (global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommonOnScrollNotifier notifier)
		{
			if (id_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_ == IntPtr.Zero)
				id_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_ = JNIEnv.GetMethodID (class_ref, "injectScrollNotifier", "(Lcom/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedScrollCommon$OnScrollNotifier;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((notifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) notifier).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_injectScrollNotifier_Lcom_qmuiteam_qmui_nestedScroll_IQMUIContinuousNestedScrollCommon_OnScrollNotifier_, __args);
		}

		static Delegate cb_restoreScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetRestoreScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_restoreScrollInfo_Landroid_os_Bundle_ == null)
				cb_restoreScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RestoreScrollInfo_Landroid_os_Bundle_);
			return cb_restoreScrollInfo_Landroid_os_Bundle_;
		}

		static void n_RestoreScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestoreScrollInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_restoreScrollInfo_Landroid_os_Bundle_;
		public unsafe void RestoreScrollInfo (global::Android.OS.Bundle p0)
		{
			if (id_restoreScrollInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_restoreScrollInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "restoreScrollInfo", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_restoreScrollInfo_Landroid_os_Bundle_, __args);
		}

		static Delegate cb_saveScrollInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSaveScrollInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_saveScrollInfo_Landroid_os_Bundle_ == null)
				cb_saveScrollInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveScrollInfo_Landroid_os_Bundle_);
			return cb_saveScrollInfo_Landroid_os_Bundle_;
		}

		static void n_SaveScrollInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveScrollInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_saveScrollInfo_Landroid_os_Bundle_;
		public unsafe void SaveScrollInfo (global::Android.OS.Bundle p0)
		{
			if (id_saveScrollInfo_Landroid_os_Bundle_ == IntPtr.Zero)
				id_saveScrollInfo_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "saveScrollInfo", "(Landroid/os/Bundle;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveScrollInfo_Landroid_os_Bundle_, __args);
		}

	}

}
