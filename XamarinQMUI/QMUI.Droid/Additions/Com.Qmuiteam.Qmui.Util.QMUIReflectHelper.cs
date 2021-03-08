using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIReflectHelper", DoNotGenerateAcw=true)]
	public partial class QMUIReflectHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIReflectHelper", typeof (QMUIReflectHelper));
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

		protected QMUIReflectHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='getField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getField", "(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetField (global::Java.Lang.Class cls, global::Java.Lang.Class type)
		{
			const string __id = "getField.(Ljava/lang/Class;Ljava/lang/Class;)Ljava/lang/reflect/Field;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cls);
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='getField' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getField", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;", "")]
		public static unsafe global::Java.Lang.Reflect.Field GetField (global::Java.Lang.Class cls, string name)
		{
			const string __id = "getField.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/reflect/Field;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (cls);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='getFieldValue' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getFieldValue", "(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetFieldValue (global::Java.Lang.Object obj, global::Java.Lang.Class type)
		{
			const string __id = "getFieldValue.(Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='getFieldValue' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFieldValue", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetFieldValue (global::Java.Lang.Object obj, string name)
		{
			const string __id = "getFieldValue.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='getStaticFieldValue' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStaticFieldValue", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object GetStaticFieldValue (global::Java.Lang.Class cls, string name)
		{
			const string __id = "getStaticFieldValue.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (cls);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='invokeMethod' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object obj, string name)
		{
			const string __id = "invokeMethod.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='invokeMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("invokeMethod", "(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeMethod (global::Java.Lang.Object obj, string name, global::Java.Lang.Class[] types, global::Java.Lang.Object[] args)
		{
			const string __id = "invokeMethod.(Ljava/lang/Object;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_types = JNIEnv.NewArray (types);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_types);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (types != null) {
					JNIEnv.CopyArray (native_types, types);
					JNIEnv.DeleteLocalRef (native_types);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (types);
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='invokeStaticMethod' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeStaticMethod (global::Java.Lang.Class klass, string name)
		{
			const string __id = "invokeStaticMethod.(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((klass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) klass).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (klass);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='invokeStaticMethod' and count(parameter)=4 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class[]'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("invokeStaticMethod", "(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object InvokeStaticMethod (global::Java.Lang.Class klass, string name, global::Java.Lang.Class[] types, global::Java.Lang.Object[] args)
		{
			const string __id = "invokeStaticMethod.(Ljava/lang/Class;Ljava/lang/String;[Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_types = JNIEnv.NewArray (types);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((klass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) klass).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue (native_types);
				__args [3] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				if (types != null) {
					JNIEnv.CopyArray (native_types, types);
					JNIEnv.DeleteLocalRef (native_types);
				}
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (klass);
				global::System.GC.KeepAlive (types);
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("newInstance", "(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object NewInstance (global::Java.Lang.Class clazz, params global::Java.Lang.Object[] args)
		{
			const string __id = "newInstance.(Ljava/lang/Class;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (clazz);
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("newInstance", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object NewInstance (string className, params global::Java.Lang.Object[] args)
		{
			const string __id = "newInstance.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_className = JNIEnv.NewString (className);
			IntPtr native_args = JNIEnv.NewArray (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_className);
				__args [1] = new JniArgumentValue (native_args);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_className);
				if (args != null) {
					JNIEnv.CopyArray (native_args, args);
					JNIEnv.DeleteLocalRef (native_args);
				}
				global::System.GC.KeepAlive (args);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='setFieldValue' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setFieldValue", "(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z", "")]
		public static unsafe bool SetFieldValue (global::Java.Lang.Object obj, string name, global::Java.Lang.Object value)
		{
			const string __id = "setFieldValue.(Ljava/lang/Object;Ljava/lang/String;Ljava/lang/Object;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (obj);
				global::System.GC.KeepAlive (value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIReflectHelper']/method[@name='setStaticFieldValue' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setStaticFieldValue", "(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Z", "")]
		public static unsafe bool SetStaticFieldValue (global::Java.Lang.Class cls, string name, global::Java.Lang.Object value)
		{
			const string __id = "setStaticFieldValue.(Ljava/lang/Class;Ljava/lang/String;Ljava/lang/Object;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				__args [1] = new JniArgumentValue (native_name);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (cls);
				global::System.GC.KeepAlive (value);
			}
		}

	}
}
