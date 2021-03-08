using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUILangHelper", DoNotGenerateAcw=true)]
	public partial class QMUILangHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUILangHelper", typeof (QMUILangHelper));
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

		protected QMUILangHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/constructor[@name='QMUILangHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUILangHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("close", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void Close (global::Java.IO.ICloseable c)
		{
			const string __id = "close.(Ljava/io/Closeable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='constrain' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("constrain", "(FFF)F", "")]
		public static unsafe float Constrain (float amount, float low, float high)
		{
			const string __id = "constrain.(FFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (amount);
				__args [1] = new JniArgumentValue (low);
				__args [2] = new JniArgumentValue (high);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='constrain' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("constrain", "(III)I", "")]
		public static unsafe int Constrain (int amount, int low, int high)
		{
			const string __id = "constrain.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (amount);
				__args [1] = new JniArgumentValue (low);
				__args [2] = new JniArgumentValue (high);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='formatNumberToLimitedDigits' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("formatNumberToLimitedDigits", "(II)Ljava/lang/String;", "")]
		public static unsafe string FormatNumberToLimitedDigits (int number, int maxDigits)
		{
			const string __id = "formatNumberToLimitedDigits.(II)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (maxDigits);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='getNumberDigits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getNumberDigits", "(I)I", "")]
		public static unsafe int GetNumberDigits (int number)
		{
			const string __id = "getNumberDigits.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='getNumberDigits' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getNumberDigits", "(J)I", "")]
		public static unsafe int GetNumberDigits (long number)
		{
			const string __id = "getNumberDigits.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='isNullOrEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isNullOrEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsNullOrEmpty (global::Java.Lang.ICharSequence @string)
		{
			const string __id = "isNullOrEmpty.(Ljava/lang/CharSequence;)Z";
			IntPtr native__string = CharSequence.ToLocalJniHandle (@string);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__string);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__string);
				global::System.GC.KeepAlive (@string);
			}
		}

		public static bool IsNullOrEmpty (string @string)
		{
			var jls_string = @string == null ? null : new global::Java.Lang.String (@string);
			bool __result = IsNullOrEmpty (jls_string);
			var __rsval = __result;
			jls_string?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='objectEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("objectEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool ObjectEquals (global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "objectEquals.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (a);
				global::System.GC.KeepAlive (b);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='regularizePrice' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("regularizePrice", "(D)Ljava/lang/String;", "")]
		public static unsafe string RegularizePrice (double price)
		{
			const string __id = "regularizePrice.(D)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (price);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUILangHelper']/method[@name='regularizePrice' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("regularizePrice", "(F)Ljava/lang/String;", "")]
		public static unsafe string RegularizePrice (float price)
		{
			const string __id = "regularizePrice.(F)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (price);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
