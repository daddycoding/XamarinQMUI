using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.NestedScroll {

	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView", DoNotGenerateAcw=true)]
	public abstract class QMUIContinuousNestedBottomView : Java.Lang.Object {

		internal QMUIContinuousNestedBottomView ()
		{
		}

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

	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'QMUIContinuousNestedBottomView' type. This type will be removed in a future release.", error: true)]
	public abstract class QMUIContinuousNestedBottomViewConsts : QMUIContinuousNestedBottomView {

		private QMUIContinuousNestedBottomViewConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']"
	[Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView", "", "Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker")]
	public partial interface IQMUIContinuousNestedBottomView : global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedScrollCommon {

		int ContentHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='getContentHeight' and count(parameter)=0]"
			[Register ("getContentHeight", "()I", "GetGetContentHeightHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")] get;
		}

		int CurrentScroll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='getCurrentScroll' and count(parameter)=0]"
			[Register ("getCurrentScroll", "()I", "GetGetCurrentScrollHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")] get;
		}

		int ScrollOffsetRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='getScrollOffsetRange' and count(parameter)=0]"
			[Register ("getScrollOffsetRange", "()I", "GetGetScrollOffsetRangeHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='consumeScroll' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consumeScroll", "(I)V", "GetConsumeScroll_IHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")]
		void ConsumeScroll (int dyUnconsumed);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='smoothScrollYBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("smoothScrollYBy", "(II)V", "GetSmoothScrollYBy_IIHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")]
		void SmoothScrollYBy (int dy, int duration);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.nestedScroll']/interface[@name='IQMUIContinuousNestedBottomView']/method[@name='stopScroll' and count(parameter)=0]"
		[Register ("stopScroll", "()V", "GetStopScrollHandler:Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomViewInvoker, QMUI.Droid")]
		void StopScroll ();

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView", DoNotGenerateAcw=true)]
	internal partial class IQMUIContinuousNestedBottomViewInvoker : global::Java.Lang.Object, IQMUIContinuousNestedBottomView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/nestedScroll/IQMUIContinuousNestedBottomView", typeof (IQMUIContinuousNestedBottomViewInvoker));

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

		public static IQMUIContinuousNestedBottomView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQMUIContinuousNestedBottomView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.nestedScroll.IQMUIContinuousNestedBottomView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQMUIContinuousNestedBottomViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight;
		}
#pragma warning restore 0169

		IntPtr id_getContentHeight;
		public unsafe int ContentHeight {
			get {
				if (id_getContentHeight == IntPtr.Zero)
					id_getContentHeight = JNIEnv.GetMethodID (class_ref, "getContentHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getContentHeight);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_consumeScroll_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ConsumeScroll_I);
			return cb_consumeScroll_I;
		}

		static void n_ConsumeScroll_I (IntPtr jnienv, IntPtr native__this, int dyUnconsumed)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConsumeScroll (dyUnconsumed);
		}
#pragma warning restore 0169

		IntPtr id_consumeScroll_I;
		public unsafe void ConsumeScroll (int dyUnconsumed)
		{
			if (id_consumeScroll_I == IntPtr.Zero)
				id_consumeScroll_I = JNIEnv.GetMethodID (class_ref, "consumeScroll", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (dyUnconsumed);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_consumeScroll_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmoothScrollYBy (dy, duration);
		}
#pragma warning restore 0169

		IntPtr id_smoothScrollYBy_II;
		public unsafe void SmoothScrollYBy (int dy, int duration)
		{
			if (id_smoothScrollYBy_II == IntPtr.Zero)
				id_smoothScrollYBy_II = JNIEnv.GetMethodID (class_ref, "smoothScrollYBy", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (dy);
			__args [1] = new JValue (duration);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_smoothScrollYBy_II, __args);
		}

		static Delegate cb_stopScroll;
#pragma warning disable 0169
		static Delegate GetStopScrollHandler ()
		{
			if (cb_stopScroll == null)
				cb_stopScroll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopScroll);
			return cb_stopScroll;
		}

		static void n_StopScroll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopScroll ();
		}
#pragma warning restore 0169

		IntPtr id_stopScroll;
		public unsafe void StopScroll ()
		{
			if (id_stopScroll == IntPtr.Zero)
				id_stopScroll = JNIEnv.GetMethodID (class_ref, "stopScroll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopScroll);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.NestedScroll.IQMUIContinuousNestedBottomView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
