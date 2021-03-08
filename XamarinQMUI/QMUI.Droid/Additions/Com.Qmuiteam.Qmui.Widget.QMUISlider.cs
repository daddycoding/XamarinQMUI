using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISlider", DoNotGenerateAcw=true)]
	public partial class QMUISlider : global::Android.Widget.FrameLayout, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/field[@name='PROGRESS_NOT_SET']"
		[Register ("PROGRESS_NOT_SET")]
		public const int ProgressNotSet = (int) -1;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']"
		[Register ("com/qmuiteam/qmui/widget/QMUISlider$Callback", "", "Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker")]
		public partial interface ICallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']/method[@name='onProgressChange' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("onProgressChange", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V", "GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker, QMUI.Droid")]
			void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool fromUser);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']/method[@name='onStartMoving' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onStartMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker, QMUI.Droid")]
			void OnStartMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']/method[@name='onStopMoving' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onStopMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker, QMUI.Droid")]
			void OnStopMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']/method[@name='onTouchDown' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("onTouchDown", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V", "GetOnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker, QMUI.Droid")]
			void OnTouchDown (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool hitThumb);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.Callback']/method[@name='onTouchUp' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onTouchUp", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/ICallbackInvoker, QMUI.Droid")]
			void OnTouchUp (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISlider$Callback", DoNotGenerateAcw=true)]
		internal partial class ICallbackInvoker : global::Java.Lang.Object, ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISlider$Callback", typeof (ICallbackInvoker));

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

			public static ICallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUISlider.Callback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
#pragma warning disable 0169
			static Delegate GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler ()
			{
				if (cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == null)
					cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_V) n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ);
				return cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			}

			static void n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount, bool fromUser)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressChange (slider, progress, tickCount, fromUser);
			}
#pragma warning restore 0169

			IntPtr id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			public unsafe void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool fromUser)
			{
				if (id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == IntPtr.Zero)
					id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNIEnv.GetMethodID (class_ref, "onProgressChange", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
				__args [1] = new JValue (progress);
				__args [2] = new JValue (tickCount);
				__args [3] = new JValue (fromUser);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ, __args);
			}

			static Delegate cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnStartMoving (slider, progress, tickCount);
			}
#pragma warning restore 0169

			IntPtr id_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			public unsafe void OnStartMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				if (id_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == IntPtr.Zero)
					id_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNIEnv.GetMethodID (class_ref, "onStartMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
				__args [1] = new JValue (progress);
				__args [2] = new JValue (tickCount);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II, __args);
			}

			static Delegate cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnStopMoving (slider, progress, tickCount);
			}
#pragma warning restore 0169

			IntPtr id_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			public unsafe void OnStopMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				if (id_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == IntPtr.Zero)
					id_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNIEnv.GetMethodID (class_ref, "onStopMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
				__args [1] = new JValue (progress);
				__args [2] = new JValue (tickCount);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II, __args);
			}

			static Delegate cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
#pragma warning disable 0169
			static Delegate GetOnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler ()
			{
				if (cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == null)
					cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_V) n_OnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ);
				return cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			}

			static void n_OnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount, bool hitThumb)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchDown (slider, progress, tickCount, hitThumb);
			}
#pragma warning restore 0169

			IntPtr id_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			public unsafe void OnTouchDown (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool hitThumb)
			{
				if (id_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == IntPtr.Zero)
					id_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNIEnv.GetMethodID (class_ref, "onTouchDown", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
				__args [1] = new JValue (progress);
				__args [2] = new JValue (tickCount);
				__args [3] = new JValue (hitThumb);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ, __args);
			}

			static Delegate cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchUp (slider, progress, tickCount);
			}
#pragma warning restore 0169

			IntPtr id_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			public unsafe void OnTouchUp (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				if (id_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II == IntPtr.Zero)
					id_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNIEnv.GetMethodID (class_ref, "onTouchUp", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
				__args [1] = new JValue (progress);
				__args [2] = new JValue (tickCount);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISlider$DefaultCallback", DoNotGenerateAcw=true)]
		public partial class DefaultCallback : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISlider$DefaultCallback", typeof (DefaultCallback));
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

			protected DefaultCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/constructor[@name='QMUISlider.DefaultCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DefaultCallback ()
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

			static Delegate cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
#pragma warning disable 0169
			static Delegate GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler ()
			{
				if (cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == null)
					cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_V) n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ);
				return cb_onProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			}

			static void n_OnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount, bool fromUser)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnProgressChange (slider, progress, tickCount, fromUser);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/method[@name='onProgressChange' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("onProgressChange", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V", "GetOnProgressChange_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler")]
			public virtual unsafe void OnProgressChange (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool fromUser)
			{
				const string __id = "onProgressChange.(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
					__args [1] = new JniArgumentValue (progress);
					__args [2] = new JniArgumentValue (tickCount);
					__args [3] = new JniArgumentValue (fromUser);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (slider);
				}
			}

			static Delegate cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnStartMoving (slider, progress, tickCount);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/method[@name='onStartMoving' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onStartMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnStartMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler")]
			public virtual unsafe void OnStartMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				const string __id = "onStartMoving.(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
					__args [1] = new JniArgumentValue (progress);
					__args [2] = new JniArgumentValue (tickCount);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (slider);
				}
			}

			static Delegate cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnStopMoving (slider, progress, tickCount);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/method[@name='onStopMoving' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onStopMoving", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnStopMoving_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler")]
			public virtual unsafe void OnStopMoving (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				const string __id = "onStopMoving.(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
					__args [1] = new JniArgumentValue (progress);
					__args [2] = new JniArgumentValue (tickCount);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (slider);
				}
			}

			static Delegate cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
#pragma warning disable 0169
			static Delegate GetOnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler ()
			{
				if (cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ == null)
					cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZ_V) n_OnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ);
				return cb_onTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ;
			}

			static void n_OnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount, bool hitThumb)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchDown (slider, progress, tickCount, hitThumb);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/method[@name='onTouchDown' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("onTouchDown", "(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V", "GetOnTouchDown_Lcom_qmuiteam_qmui_widget_QMUISlider_IIZHandler")]
			public virtual unsafe void OnTouchDown (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount, bool hitThumb)
			{
				const string __id = "onTouchDown.(Lcom/qmuiteam/qmui/widget/QMUISlider;IIZ)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
					__args [1] = new JniArgumentValue (progress);
					__args [2] = new JniArgumentValue (tickCount);
					__args [3] = new JniArgumentValue (hitThumb);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (slider);
				}
			}

			static Delegate cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
#pragma warning disable 0169
			static Delegate GetOnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler ()
			{
				if (cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II == null)
					cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II);
				return cb_onTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II;
			}

			static void n_OnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_II (IntPtr jnienv, IntPtr native__this, IntPtr native_slider, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var slider = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (native_slider, JniHandleOwnership.DoNotTransfer);
				__this.OnTouchUp (slider, progress, tickCount);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultCallback']/method[@name='onTouchUp' and count(parameter)=3 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("onTouchUp", "(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V", "GetOnTouchUp_Lcom_qmuiteam_qmui_widget_QMUISlider_IIHandler")]
			public virtual unsafe void OnTouchUp (global::Com.Qmuiteam.Qmui.Widget.QMUISlider slider, int progress, int tickCount)
			{
				const string __id = "onTouchUp.(Lcom/qmuiteam/qmui/widget/QMUISlider;II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((slider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) slider).Handle);
					__args [1] = new JniArgumentValue (progress);
					__args [2] = new JniArgumentValue (tickCount);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (slider);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISlider$DefaultThumbView", DoNotGenerateAcw=true)]
		public partial class DefaultThumbView : global::Android.Views.View, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider, global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISlider$DefaultThumbView", typeof (DefaultThumbView));
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

			protected DefaultThumbView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/constructor[@name='QMUISlider.DefaultThumbView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Landroid/content/Context;II)V", "")]
			public unsafe DefaultThumbView (global::Android.Content.Context context, int size, int defAttr)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (size);
					__args [2] = new JniArgumentValue (defAttr);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (context);
				}
			}

			static Delegate cb_getDefaultSkinAttrs;
#pragma warning disable 0169
			static Delegate GetGetDefaultSkinAttrsHandler ()
			{
				if (cb_getDefaultSkinAttrs == null)
					cb_getDefaultSkinAttrs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultSkinAttrs);
				return cb_getDefaultSkinAttrs;
			}

			static IntPtr n_GetDefaultSkinAttrs (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
			}
#pragma warning restore 0169

			public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
				[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler")]
				get {
					const string __id = "getDefaultSkinAttrs.()Landroidx/collection/SimpleArrayMap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getLeftRightMargin;
#pragma warning disable 0169
			static Delegate GetGetLeftRightMarginHandler ()
			{
				if (cb_getLeftRightMargin == null)
					cb_getLeftRightMargin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLeftRightMargin);
				return cb_getLeftRightMargin;
			}

			static int n_GetLeftRightMargin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LeftRightMargin;
			}
#pragma warning restore 0169

			public virtual unsafe int LeftRightMargin {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/method[@name='getLeftRightMargin' and count(parameter)=0]"
				[Register ("getLeftRightMargin", "()I", "GetGetLeftRightMarginHandler")]
				get {
					const string __id = "getLeftRightMargin.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_render_II;
#pragma warning disable 0169
			static Delegate GetRender_IIHandler ()
			{
				if (cb_render_II == null)
					cb_render_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Render_II);
				return cb_render_II;
			}

			static void n_Render_II (IntPtr jnienv, IntPtr native__this, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Render (progress, tickCount);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/method[@name='render' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("render", "(II)V", "GetRender_IIHandler")]
			public virtual unsafe void Render (int progress, int tickCount)
			{
				const string __id = "render.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (progress);
					__args [1] = new JniArgumentValue (tickCount);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
			static Delegate GetSetBorderColor_IHandler ()
			{
				if (cb_setBorderColor_I == null)
					cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBorderColor_I);
				return cb_setBorderColor_I;
			}

			static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int color)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetBorderColor (color);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
			public virtual unsafe void SetBorderColor (int color)
			{
				const string __id = "setBorderColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (color);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setPress_Z;
#pragma warning disable 0169
			static Delegate GetSetPress_ZHandler ()
			{
				if (cb_setPress_Z == null)
					cb_setPress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPress_Z);
				return cb_setPress_Z;
			}

			static void n_SetPress_Z (IntPtr jnienv, IntPtr native__this, bool isPressed)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.DefaultThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetPress (isPressed);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider.DefaultThumbView']/method[@name='setPress' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPress", "(Z)V", "GetSetPress_ZHandler")]
			public virtual unsafe void SetPress (bool isPressed)
			{
				const string __id = "setPress.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (isPressed);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.IThumbView']"
		[Register ("com/qmuiteam/qmui/widget/QMUISlider$IThumbView", "", "Com.Qmuiteam.Qmui.Widget.QMUISlider/IThumbViewInvoker")]
		public partial interface IThumbView : IJavaObject, IJavaPeerable {

			int LeftRightMargin {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.IThumbView']/method[@name='getLeftRightMargin' and count(parameter)=0]"
				[Register ("getLeftRightMargin", "()I", "GetGetLeftRightMarginHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/IThumbViewInvoker, QMUI.Droid")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.IThumbView']/method[@name='render' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("render", "(II)V", "GetRender_IIHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/IThumbViewInvoker, QMUI.Droid")]
			void Render (int progress, int tickCount);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUISlider.IThumbView']/method[@name='setPress' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPress", "(Z)V", "GetSetPress_ZHandler:Com.Qmuiteam.Qmui.Widget.QMUISlider/IThumbViewInvoker, QMUI.Droid")]
			void SetPress (bool isPressed);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUISlider$IThumbView", DoNotGenerateAcw=true)]
		internal partial class IThumbViewInvoker : global::Java.Lang.Object, IThumbView {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISlider$IThumbView", typeof (IThumbViewInvoker));

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

			public static IThumbView GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IThumbView> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUISlider.IThumbView"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IThumbViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getLeftRightMargin;
#pragma warning disable 0169
			static Delegate GetGetLeftRightMarginHandler ()
			{
				if (cb_getLeftRightMargin == null)
					cb_getLeftRightMargin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLeftRightMargin);
				return cb_getLeftRightMargin;
			}

			static int n_GetLeftRightMargin (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.LeftRightMargin;
			}
#pragma warning restore 0169

			IntPtr id_getLeftRightMargin;
			public unsafe int LeftRightMargin {
				get {
					if (id_getLeftRightMargin == IntPtr.Zero)
						id_getLeftRightMargin = JNIEnv.GetMethodID (class_ref, "getLeftRightMargin", "()I");
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLeftRightMargin);
				}
			}

			static Delegate cb_render_II;
#pragma warning disable 0169
			static Delegate GetRender_IIHandler ()
			{
				if (cb_render_II == null)
					cb_render_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_Render_II);
				return cb_render_II;
			}

			static void n_Render_II (IntPtr jnienv, IntPtr native__this, int progress, int tickCount)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Render (progress, tickCount);
			}
#pragma warning restore 0169

			IntPtr id_render_II;
			public unsafe void Render (int progress, int tickCount)
			{
				if (id_render_II == IntPtr.Zero)
					id_render_II = JNIEnv.GetMethodID (class_ref, "render", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (progress);
				__args [1] = new JValue (tickCount);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_render_II, __args);
			}

			static Delegate cb_setPress_Z;
#pragma warning disable 0169
			static Delegate GetSetPress_ZHandler ()
			{
				if (cb_setPress_Z == null)
					cb_setPress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPress_Z);
				return cb_setPress_Z;
			}

			static void n_SetPress_Z (IntPtr jnienv, IntPtr native__this, bool isPressed)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetPress (isPressed);
			}
#pragma warning restore 0169

			IntPtr id_setPress_Z;
			public unsafe void SetPress (bool isPressed)
			{
				if (id_setPress_Z == IntPtr.Zero)
					id_setPress_Z = JNIEnv.GetMethodID (class_ref, "setPress", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (isPressed);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPress_Z, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUISlider", typeof (QMUISlider));
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

		protected QMUISlider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/constructor[@name='QMUISlider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUISlider (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/constructor[@name='QMUISlider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUISlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/constructor[@name='QMUISlider' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUISlider (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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

		static Delegate cb_getBarHeight;
#pragma warning disable 0169
		static Delegate GetGetBarHeightHandler ()
		{
			if (cb_getBarHeight == null)
				cb_getBarHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBarHeight);
			return cb_getBarHeight;
		}

		static int n_GetBarHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setBarHeight_I;
#pragma warning disable 0169
		static Delegate GetSetBarHeight_IHandler ()
		{
			if (cb_setBarHeight_I == null)
				cb_setBarHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBarHeight_I);
			return cb_setBarHeight_I;
		}

		static void n_SetBarHeight_I (IntPtr jnienv, IntPtr native__this, int barHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarHeight = barHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int BarHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getBarHeight' and count(parameter)=0]"
			[Register ("getBarHeight", "()I", "GetGetBarHeightHandler")]
			get {
				const string __id = "getBarHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setBarHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarHeight", "(I)V", "GetSetBarHeight_IHandler")]
			set {
				const string __id = "setBarHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarNormalColor;
#pragma warning disable 0169
		static Delegate GetGetBarNormalColorHandler ()
		{
			if (cb_getBarNormalColor == null)
				cb_getBarNormalColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBarNormalColor);
			return cb_getBarNormalColor;
		}

		static int n_GetBarNormalColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarNormalColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBarNormalColor_I;
#pragma warning disable 0169
		static Delegate GetSetBarNormalColor_IHandler ()
		{
			if (cb_setBarNormalColor_I == null)
				cb_setBarNormalColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBarNormalColor_I);
			return cb_setBarNormalColor_I;
		}

		static void n_SetBarNormalColor_I (IntPtr jnienv, IntPtr native__this, int barNormalColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarNormalColor = barNormalColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BarNormalColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getBarNormalColor' and count(parameter)=0]"
			[Register ("getBarNormalColor", "()I", "GetGetBarNormalColorHandler")]
			get {
				const string __id = "getBarNormalColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setBarNormalColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarNormalColor", "(I)V", "GetSetBarNormalColor_IHandler")]
			set {
				const string __id = "setBarNormalColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarProgressColor;
#pragma warning disable 0169
		static Delegate GetGetBarProgressColorHandler ()
		{
			if (cb_getBarProgressColor == null)
				cb_getBarProgressColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBarProgressColor);
			return cb_getBarProgressColor;
		}

		static int n_GetBarProgressColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarProgressColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBarProgressColor_I;
#pragma warning disable 0169
		static Delegate GetSetBarProgressColor_IHandler ()
		{
			if (cb_setBarProgressColor_I == null)
				cb_setBarProgressColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBarProgressColor_I);
			return cb_setBarProgressColor_I;
		}

		static void n_SetBarProgressColor_I (IntPtr jnienv, IntPtr native__this, int barProgressColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarProgressColor = barProgressColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BarProgressColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getBarProgressColor' and count(parameter)=0]"
			[Register ("getBarProgressColor", "()I", "GetGetBarProgressColorHandler")]
			get {
				const string __id = "getBarProgressColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setBarProgressColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarProgressColor", "(I)V", "GetSetBarProgressColor_IHandler")]
			set {
				const string __id = "setBarProgressColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentProgress;
#pragma warning disable 0169
		static Delegate GetGetCurrentProgressHandler ()
		{
			if (cb_getCurrentProgress == null)
				cb_getCurrentProgress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCurrentProgress);
			return cb_getCurrentProgress;
		}

		static int n_GetCurrentProgress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentProgress;
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentProgress_I;
#pragma warning disable 0169
		static Delegate GetSetCurrentProgress_IHandler ()
		{
			if (cb_setCurrentProgress_I == null)
				cb_setCurrentProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCurrentProgress_I);
			return cb_setCurrentProgress_I;
		}

		static void n_SetCurrentProgress_I (IntPtr jnienv, IntPtr native__this, int currentProgress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CurrentProgress = currentProgress;
		}
#pragma warning restore 0169

		public virtual unsafe int CurrentProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getCurrentProgress' and count(parameter)=0]"
			[Register ("getCurrentProgress", "()I", "GetGetCurrentProgressHandler")]
			get {
				const string __id = "getCurrentProgress.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setCurrentProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCurrentProgress", "(I)V", "GetSetCurrentProgress_IHandler")]
			set {
				const string __id = "setCurrentProgress.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultSkinAttrs;
#pragma warning disable 0169
		static Delegate GetGetDefaultSkinAttrsHandler ()
		{
			if (cb_getDefaultSkinAttrs == null)
				cb_getDefaultSkinAttrs = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultSkinAttrs);
			return cb_getDefaultSkinAttrs;
		}

		static IntPtr n_GetDefaultSkinAttrs (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
			[Register ("getDefaultSkinAttrs", "()Landroidx/collection/SimpleArrayMap;", "GetGetDefaultSkinAttrsHandler")]
			get {
				const string __id = "getDefaultSkinAttrs.()Landroidx/collection/SimpleArrayMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordProgress;
#pragma warning disable 0169
		static Delegate GetGetRecordProgressHandler ()
		{
			if (cb_getRecordProgress == null)
				cb_getRecordProgress = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordProgress);
			return cb_getRecordProgress;
		}

		static int n_GetRecordProgress (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordProgress;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordProgress_I;
#pragma warning disable 0169
		static Delegate GetSetRecordProgress_IHandler ()
		{
			if (cb_setRecordProgress_I == null)
				cb_setRecordProgress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordProgress_I);
			return cb_setRecordProgress_I;
		}

		static void n_SetRecordProgress_I (IntPtr jnienv, IntPtr native__this, int recordProgress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordProgress = recordProgress;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getRecordProgress' and count(parameter)=0]"
			[Register ("getRecordProgress", "()I", "GetGetRecordProgressHandler")]
			get {
				const string __id = "getRecordProgress.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setRecordProgress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordProgress", "(I)V", "GetSetRecordProgress_IHandler")]
			set {
				const string __id = "setRecordProgress.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordProgressColor;
#pragma warning disable 0169
		static Delegate GetGetRecordProgressColorHandler ()
		{
			if (cb_getRecordProgressColor == null)
				cb_getRecordProgressColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordProgressColor);
			return cb_getRecordProgressColor;
		}

		static int n_GetRecordProgressColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordProgressColor;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordProgressColor_I;
#pragma warning disable 0169
		static Delegate GetSetRecordProgressColor_IHandler ()
		{
			if (cb_setRecordProgressColor_I == null)
				cb_setRecordProgressColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordProgressColor_I);
			return cb_setRecordProgressColor_I;
		}

		static void n_SetRecordProgressColor_I (IntPtr jnienv, IntPtr native__this, int recordProgressColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordProgressColor = recordProgressColor;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordProgressColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getRecordProgressColor' and count(parameter)=0]"
			[Register ("getRecordProgressColor", "()I", "GetGetRecordProgressColorHandler")]
			get {
				const string __id = "getRecordProgressColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setRecordProgressColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordProgressColor", "(I)V", "GetSetRecordProgressColor_IHandler")]
			set {
				const string __id = "setRecordProgressColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTickCount;
#pragma warning disable 0169
		static Delegate GetGetTickCountHandler ()
		{
			if (cb_getTickCount == null)
				cb_getTickCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTickCount);
			return cb_getTickCount;
		}

		static int n_GetTickCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TickCount;
		}
#pragma warning restore 0169

		static Delegate cb_setTickCount_I;
#pragma warning disable 0169
		static Delegate GetSetTickCount_IHandler ()
		{
			if (cb_setTickCount_I == null)
				cb_setTickCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTickCount_I);
			return cb_setTickCount_I;
		}

		static void n_SetTickCount_I (IntPtr jnienv, IntPtr native__this, int tickCount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TickCount = tickCount;
		}
#pragma warning restore 0169

		public virtual unsafe int TickCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='getTickCount' and count(parameter)=0]"
			[Register ("getTickCount", "()I", "GetGetTickCountHandler")]
			get {
				const string __id = "getTickCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setTickCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTickCount", "(I)V", "GetSetTickCount_IHandler")]
			set {
				const string __id = "setTickCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_drawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetDrawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_Handler ()
		{
			if (cb_drawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_ == null)
				cb_drawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DrawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_);
			return cb_drawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_;
		}

		static void n_DrawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_rect, IntPtr native_paint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_rect, JniHandleOwnership.DoNotTransfer);
			var paint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_paint, JniHandleOwnership.DoNotTransfer);
			__this.DrawRecordProgress (canvas, rect, paint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='drawRecordProgress' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.RectF'] and parameter[3][@type='android.graphics.Paint']]"
		[Register ("drawRecordProgress", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;Landroid/graphics/Paint;)V", "GetDrawRecordProgress_Landroid_graphics_Canvas_Landroid_graphics_RectF_Landroid_graphics_Paint_Handler")]
		protected virtual unsafe void DrawRecordProgress (global::Android.Graphics.Canvas canvas, global::Android.Graphics.RectF rect, global::Android.Graphics.Paint paint)
		{
			const string __id = "drawRecordProgress.(Landroid/graphics/Canvas;Landroid/graphics/RectF;Landroid/graphics/Paint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((rect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rect).Handle);
				__args [2] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
				global::System.GC.KeepAlive (rect);
				global::System.GC.KeepAlive (paint);
			}
		}

		static Delegate cb_drawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z;
#pragma warning disable 0169
		static Delegate GetDrawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_ZHandler ()
		{
			if (cb_drawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z == null)
				cb_drawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLILZ_V) n_DrawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z);
			return cb_drawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z;
		}

		static void n_DrawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_rect, int barHeight, IntPtr native_paint, bool forProgress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			var rect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_rect, JniHandleOwnership.DoNotTransfer);
			var paint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_paint, JniHandleOwnership.DoNotTransfer);
			__this.DrawRect (canvas, rect, barHeight, paint, forProgress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='drawRect' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.RectF'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Paint'] and parameter[5][@type='boolean']]"
		[Register ("drawRect", "(Landroid/graphics/Canvas;Landroid/graphics/RectF;ILandroid/graphics/Paint;Z)V", "GetDrawRect_Landroid_graphics_Canvas_Landroid_graphics_RectF_ILandroid_graphics_Paint_ZHandler")]
		protected virtual unsafe void DrawRect (global::Android.Graphics.Canvas canvas, global::Android.Graphics.RectF rect, int barHeight, global::Android.Graphics.Paint paint, bool forProgress)
		{
			const string __id = "drawRect.(Landroid/graphics/Canvas;Landroid/graphics/RectF;ILandroid/graphics/Paint;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((rect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rect).Handle);
				__args [2] = new JniArgumentValue (barHeight);
				__args [3] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [4] = new JniArgumentValue (forProgress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
				global::System.GC.KeepAlive (rect);
				global::System.GC.KeepAlive (paint);
			}
		}

		static Delegate cb_drawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II;
#pragma warning disable 0169
		static Delegate GetDrawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_IIHandler ()
		{
			if (cb_drawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II == null)
				cb_drawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIIIFLII_V) n_DrawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II);
			return cb_drawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II;
		}

		static void n_DrawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_II (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, int currentTickCount, int totalTickCount, int left, int right, float y, IntPtr native_paint, int barNormalColor, int barProgressColor)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			var paint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_paint, JniHandleOwnership.DoNotTransfer);
			__this.DrawTick (canvas, currentTickCount, totalTickCount, left, right, y, paint, barNormalColor, barProgressColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='drawTick' and count(parameter)=9 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='float'] and parameter[7][@type='android.graphics.Paint'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("drawTick", "(Landroid/graphics/Canvas;IIIIFLandroid/graphics/Paint;II)V", "GetDrawTick_Landroid_graphics_Canvas_IIIIFLandroid_graphics_Paint_IIHandler")]
		protected virtual unsafe void DrawTick (global::Android.Graphics.Canvas canvas, int currentTickCount, int totalTickCount, int left, int right, float y, global::Android.Graphics.Paint paint, int barNormalColor, int barProgressColor)
		{
			const string __id = "drawTick.(Landroid/graphics/Canvas;IIIIFLandroid/graphics/Paint;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue (currentTickCount);
				__args [2] = new JniArgumentValue (totalTickCount);
				__args [3] = new JniArgumentValue (left);
				__args [4] = new JniArgumentValue (right);
				__args [5] = new JniArgumentValue (y);
				__args [6] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [7] = new JniArgumentValue (barNormalColor);
				__args [8] = new JniArgumentValue (barProgressColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (canvas);
				global::System.GC.KeepAlive (paint);
			}
		}

		static Delegate cb_isRecordProgressClicked_I;
#pragma warning disable 0169
		static Delegate GetIsRecordProgressClicked_IHandler ()
		{
			if (cb_isRecordProgressClicked_I == null)
				cb_isRecordProgressClicked_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsRecordProgressClicked_I);
			return cb_isRecordProgressClicked_I;
		}

		static bool n_IsRecordProgressClicked_I (IntPtr jnienv, IntPtr native__this, int x)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecordProgressClicked (x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='isRecordProgressClicked' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isRecordProgressClicked", "(I)Z", "GetIsRecordProgressClicked_IHandler")]
		protected virtual unsafe bool IsRecordProgressClicked (int x)
		{
			const string __id = "isRecordProgressClicked.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isThumbViewTouched_Landroid_view_View_FF;
#pragma warning disable 0169
		static Delegate GetIsThumbViewTouched_Landroid_view_View_FFHandler ()
		{
			if (cb_isThumbViewTouched_Landroid_view_View_FF == null)
				cb_isThumbViewTouched_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFF_Z) n_IsThumbViewTouched_Landroid_view_View_FF);
			return cb_isThumbViewTouched_Landroid_view_View_FF;
		}

		static bool n_IsThumbViewTouched_Landroid_view_View_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_thumbView, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var thumbView = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_thumbView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsThumbViewTouched (thumbView, x, y);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='isThumbViewTouched' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("isThumbViewTouched", "(Landroid/view/View;FF)Z", "GetIsThumbViewTouched_Landroid_view_View_FFHandler")]
		protected virtual unsafe bool IsThumbViewTouched (global::Android.Views.View thumbView, float x, float y)
		{
			const string __id = "isThumbViewTouched.(Landroid/view/View;FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((thumbView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) thumbView).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (thumbView);
			}
		}

		static Delegate cb_onCreateThumbLayoutParams;
#pragma warning disable 0169
		static Delegate GetOnCreateThumbLayoutParamsHandler ()
		{
			if (cb_onCreateThumbLayoutParams == null)
				cb_onCreateThumbLayoutParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnCreateThumbLayoutParams);
			return cb_onCreateThumbLayoutParams;
		}

		static IntPtr n_OnCreateThumbLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnCreateThumbLayoutParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='onCreateThumbLayoutParams' and count(parameter)=0]"
		[Register ("onCreateThumbLayoutParams", "()Landroid/widget/FrameLayout$LayoutParams;", "GetOnCreateThumbLayoutParamsHandler")]
		protected virtual unsafe global::Android.Widget.FrameLayout.LayoutParams OnCreateThumbLayoutParams ()
		{
			const string __id = "onCreateThumbLayoutParams.()Landroid/widget/FrameLayout$LayoutParams;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.FrameLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreateThumbView_Landroid_content_Context_II;
#pragma warning disable 0169
		static Delegate GetOnCreateThumbView_Landroid_content_Context_IIHandler ()
		{
			if (cb_onCreateThumbView_Landroid_content_Context_II == null)
				cb_onCreateThumbView_Landroid_content_Context_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_OnCreateThumbView_Landroid_content_Context_II);
			return cb_onCreateThumbView_Landroid_content_Context_II;
		}

		static IntPtr n_OnCreateThumbView_Landroid_content_Context_II (IntPtr jnienv, IntPtr native__this, IntPtr native_context, int thumbSize, int thumbStyleAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateThumbView (context, thumbSize, thumbStyleAttr));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='onCreateThumbView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onCreateThumbView", "(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/QMUISlider$IThumbView;", "GetOnCreateThumbView_Landroid_content_Context_IIHandler")]
		protected virtual unsafe global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView OnCreateThumbView (global::Android.Content.Context context, int thumbSize, int thumbStyleAttr)
		{
			const string __id = "onCreateThumbView.(Landroid/content/Context;II)Lcom/qmuiteam/qmui/widget/QMUISlider$IThumbView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (thumbSize);
				__args [2] = new JniArgumentValue (thumbStyleAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.IThumbView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed unsafe void OnLayout (bool changed, int left, int top, int right, int bottom)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLayoutCustomChildren_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayoutCustomChildren_ZIIIIHandler ()
		{
			if (cb_onLayoutCustomChildren_ZIIII == null)
				cb_onLayoutCustomChildren_ZIIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIIII_V) n_OnLayoutCustomChildren_ZIIII);
			return cb_onLayoutCustomChildren_ZIIII;
		}

		static void n_OnLayoutCustomChildren_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayoutCustomChildren (changed, left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='onLayoutCustomChildren' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayoutCustomChildren", "(ZIIII)V", "GetOnLayoutCustomChildren_ZIIIIHandler")]
		protected virtual unsafe void OnLayoutCustomChildren (bool changed, int left, int top, int right, int bottom)
		{
			const string __id = "onLayoutCustomChildren.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_Handler ()
		{
			if (cb_setCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_ == null)
				cb_setCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_);
			return cb_setCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_;
		}

		static void n_SetCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUISlider.Callback']]"
		[Register ("setCallback", "(Lcom/qmuiteam/qmui/widget/QMUISlider$Callback;)V", "GetSetCallback_Lcom_qmuiteam_qmui_widget_QMUISlider_Callback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Qmuiteam.Qmui.Widget.QMUISlider.ICallback @callback)
		{
			const string __id = "setCallback.(Lcom/qmuiteam/qmui/widget/QMUISlider$Callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setClickToChangeProgress_Z;
#pragma warning disable 0169
		static Delegate GetSetClickToChangeProgress_ZHandler ()
		{
			if (cb_setClickToChangeProgress_Z == null)
				cb_setClickToChangeProgress_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetClickToChangeProgress_Z);
			return cb_setClickToChangeProgress_Z;
		}

		static void n_SetClickToChangeProgress_Z (IntPtr jnienv, IntPtr native__this, bool clickToChangeProgress)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClickToChangeProgress (clickToChangeProgress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setClickToChangeProgress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setClickToChangeProgress", "(Z)V", "GetSetClickToChangeProgress_ZHandler")]
		public virtual unsafe void SetClickToChangeProgress (bool clickToChangeProgress)
		{
			const string __id = "setClickToChangeProgress.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clickToChangeProgress);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConstraintThumbInMoving_Z;
#pragma warning disable 0169
		static Delegate GetSetConstraintThumbInMoving_ZHandler ()
		{
			if (cb_setConstraintThumbInMoving_Z == null)
				cb_setConstraintThumbInMoving_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetConstraintThumbInMoving_Z);
			return cb_setConstraintThumbInMoving_Z;
		}

		static void n_SetConstraintThumbInMoving_Z (IntPtr jnienv, IntPtr native__this, bool constraintThumbInMoving)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetConstraintThumbInMoving (constraintThumbInMoving);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setConstraintThumbInMoving' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setConstraintThumbInMoving", "(Z)V", "GetSetConstraintThumbInMoving_ZHandler")]
		public virtual unsafe void SetConstraintThumbInMoving (bool constraintThumbInMoving)
		{
			const string __id = "setConstraintThumbInMoving.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (constraintThumbInMoving);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
#pragma warning disable 0169
		static Delegate GetSetThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler ()
		{
			if (cb_setThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ == null)
				cb_setThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_);
			return cb_setThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_;
		}

		static void n_SetThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_valueBuilder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUISlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var valueBuilder = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (native_valueBuilder, JniHandleOwnership.DoNotTransfer);
			__this.SetThumbSkin (valueBuilder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUISlider']/method[@name='setThumbSkin' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setThumbSkin", "(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "GetSetThumbSkin_Lcom_qmuiteam_qmui_skin_QMUISkinValueBuilder_Handler")]
		public virtual unsafe void SetThumbSkin (global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder valueBuilder)
		{
			const string __id = "setThumbSkin.(Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((valueBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueBuilder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (valueBuilder);
			}
		}

	}
}
