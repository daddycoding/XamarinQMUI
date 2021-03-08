using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedTopView']"
	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView", "", "Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopViewInvoker")]
	public partial interface IQMUIContinuousNestedTopView : global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommon {

		int CurrentScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedTopView']/method[@name='getCurrentScroll' and count(parameter)=0]"
			[Register ("getCurrentScroll", "()I", "GetGetCurrentScrollHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopViewInvoker, QMUI.Droid")] get;
		}

		int ScrollOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedTopView']/method[@name='getScrollOffsetRange' and count(parameter)=0]"
			[Register ("getScrollOffsetRange", "()I", "GetGetScrollOffsetRangeHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopViewInvoker, QMUI.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedTopView']/method[@name='consumeScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consumeScroll", "(I)I", "GetConsumeScroll_IHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopViewInvoker, QMUI.Droid")]
		int ConsumeScroll (int dyUnconsumed);

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView", DoNotGenerateAcw=true)]
	internal partial class IQMUIContinuousNestedTopViewInvoker : global::Java.Lang.Object, IQMUIContinuousNestedTopView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedTopView", typeof (IQMUIContinuousNestedTopViewInvoker));

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

		public static IQMUIContinuousNestedTopView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIContinuousNestedTopView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedTopView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIContinuousNestedTopViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentScroll;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentScroll;
		public unsafe int CurrentScroll {
			get {
				if (id_getCurrentScroll == IntPtr.Zero)
					id_getCurrentScroll = JNIEnv.GetMethodID (class_ref, "getCurrentScroll", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentScroll);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrollOffsetRange;
		}
#pragma warning restore 0169

		IntPtr id_getScrollOffsetRange;
		public unsafe int ScrollOffsetRange {
			get {
				if (id_getScrollOffsetRange == IntPtr.Zero)
					id_getScrollOffsetRange = JNIEnv.GetMethodID (class_ref, "getScrollOffsetRange", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getScrollOffsetRange);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConsumeScroll (dyUnconsumed);
		}
#pragma warning restore 0169

		IntPtr id_consumeScroll_I;
		public unsafe int ConsumeScroll (int dyUnconsumed)
		{
			if (id_consumeScroll_I == IntPtr.Zero)
				id_consumeScroll_I = JNIEnv.GetMethodID (class_ref, "consumeScroll", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dyUnconsumed);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_consumeScroll_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedTopView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
