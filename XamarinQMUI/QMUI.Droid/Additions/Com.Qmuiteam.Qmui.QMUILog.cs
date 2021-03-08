using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/QMUILog", DoNotGenerateAcw=true)]
	public partial class QMUILog : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']"
		[Register ("com/qmuiteam/qmui/QMUILog$QMUILogDelegate", "", "Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker")]
		public partial interface IQMUILogDelegate : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetD_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker, QMUI.Droid")]
			void D (string tag, string msg, params global::Java.Lang.Object[] obj);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetE_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker, QMUI.Droid")]
			void E (string tag, string msg, params global::Java.Lang.Object[] obj);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetI_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker, QMUI.Droid")]
			void I (string tag, string msg, params global::Java.Lang.Object[] obj);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']/method[@name='printErrStackTrace' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
			[Register ("printErrStackTrace", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "GetPrintErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker, QMUI.Droid")]
			void PrintErrStackTrace (string tag, global::Java.Lang.Throwable tr, string format, params global::Java.Lang.Object[] obj);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/interface[@name='QMUILog.QMUILogDelegate']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
			[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetW_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Com.Qmuiteam.Qmui.QMUILog/IQMUILogDelegateInvoker, QMUI.Droid")]
			void W (string tag, string msg, params global::Java.Lang.Object[] obj);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/QMUILog$QMUILogDelegate", DoNotGenerateAcw=true)]
		internal partial class IQMUILogDelegateInvoker : global::Java.Lang.Object, IQMUILogDelegate {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/QMUILog$QMUILogDelegate", typeof (IQMUILogDelegateInvoker));

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

			public static IQMUILogDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQMUILogDelegate> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.QMUILog.QMUILogDelegate"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQMUILogDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetD_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_D_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_D_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.D (tag, msg, obj);
				if (obj != null)
					JNIEnv.CopyArray (obj, native_obj);
			}
#pragma warning restore 0169

			IntPtr id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void D (string tag, string msg, params global::Java.Lang.Object[] obj)
			{
				if (id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_tag = JNIEnv.NewString (tag);
				IntPtr native_msg = JNIEnv.NewString (msg);
				IntPtr native_obj = JNIEnv.NewArray (obj);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (native_obj);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}

			static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetE_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_E_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_E_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.E (tag, msg, obj);
				if (obj != null)
					JNIEnv.CopyArray (obj, native_obj);
			}
#pragma warning restore 0169

			IntPtr id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void E (string tag, string msg, params global::Java.Lang.Object[] obj)
			{
				if (id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_tag = JNIEnv.NewString (tag);
				IntPtr native_msg = JNIEnv.NewString (msg);
				IntPtr native_obj = JNIEnv.NewArray (obj);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (native_obj);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}

			static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetI_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_I_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_I_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.I (tag, msg, obj);
				if (obj != null)
					JNIEnv.CopyArray (obj, native_obj);
			}
#pragma warning restore 0169

			IntPtr id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void I (string tag, string msg, params global::Java.Lang.Object[] obj)
			{
				if (id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_tag = JNIEnv.NewString (tag);
				IntPtr native_msg = JNIEnv.NewString (msg);
				IntPtr native_obj = JNIEnv.NewArray (obj);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (native_obj);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}

			static Delegate cb_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetPrintErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_PrintErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_PrintErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_tr, IntPtr native_format, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var tr = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_tr, JniHandleOwnership.DoNotTransfer);
				var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
				var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.PrintErrStackTrace (tag, tr, format, obj);
				if (obj != null)
					JNIEnv.CopyArray (obj, native_obj);
			}
#pragma warning restore 0169

			IntPtr id_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void PrintErrStackTrace (string tag, global::Java.Lang.Throwable tr, string format, params global::Java.Lang.Object[] obj)
			{
				if (id_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "printErrStackTrace", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_tag = JNIEnv.NewString (tag);
				IntPtr native_format = JNIEnv.NewString (format);
				IntPtr native_obj = JNIEnv.NewArray (obj);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				__args [2] = new JValue (native_format);
				__args [3] = new JValue (native_obj);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printErrStackTrace_Ljava_lang_String_Ljava_lang_Throwable_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}

			static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetW_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
			{
				if (cb_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
					cb_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_W_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
				return cb_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			}

			static void n_W_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
				var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
				var obj = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_obj, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				__this.W (tag, msg, obj);
				if (obj != null)
					JNIEnv.CopyArray (obj, native_obj);
			}
#pragma warning restore 0169

			IntPtr id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
			public unsafe void W (string tag, string msg, params global::Java.Lang.Object[] obj)
			{
				if (id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
				IntPtr native_tag = JNIEnv.NewString (tag);
				IntPtr native_msg = JNIEnv.NewString (msg);
				IntPtr native_obj = JNIEnv.NewArray (obj);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_tag);
				__args [1] = new JValue (native_msg);
				__args [2] = new JValue (native_obj);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/QMUILog", typeof (QMUILog));
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

		protected QMUILog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/constructor[@name='QMUILog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUILog ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void D (string tag, string msg, params global::Java.Lang.Object[] obj)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void E (string tag, string msg, params global::Java.Lang.Object[] obj)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void I (string tag, string msg, params global::Java.Lang.Object[] obj)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='printErrStackTrace' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object...']]"
		[Register ("printErrStackTrace", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void PrintErrStackTrace (string tag, global::Java.Lang.Throwable tr, string format, params global::Java.Lang.Object[] obj)
		{
			const string __id = "printErrStackTrace.(Ljava/lang/String;Ljava/lang/Throwable;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue ((tr == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) tr).Handle);
				__args [2] = new JniArgumentValue (native_format);
				__args [3] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_format);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (tr);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='setDelegete' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.QMUILog.QMUILogDelegate']]"
		[Register ("setDelegete", "(Lcom/qmuiteam/qmui/QMUILog$QMUILogDelegate;)V", "")]
		public static unsafe void SetDelegete (global::Com.Qmuiteam.Qmui.QMUILog.IQMUILogDelegate delegete)
		{
			const string __id = "setDelegete.(Lcom/qmuiteam/qmui/QMUILog$QMUILogDelegate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((delegete == null) ? IntPtr.Zero : ((global::Java.Lang.Object) delegete).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (delegete);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui']/class[@name='QMUILog']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "")]
		public static unsafe void W (string tag, string msg, params global::Java.Lang.Object[] obj)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			IntPtr native_obj = JNIEnv.NewArray (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
				if (obj != null) {
					JNIEnv.CopyArray (native_obj, obj);
					JNIEnv.DeleteLocalRef (native_obj);
				}
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
