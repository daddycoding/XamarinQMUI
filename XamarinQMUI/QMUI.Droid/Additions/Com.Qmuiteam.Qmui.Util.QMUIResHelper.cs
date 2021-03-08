using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUIResHelper", DoNotGenerateAcw=true)]
	public partial class QMUIResHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUIResHelper", typeof (QMUIResHelper));
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

		protected QMUIResHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/constructor[@name='QMUIResHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUIResHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='assignTextViewWithAttr' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int']]"
		[Register ("assignTextViewWithAttr", "(Landroid/widget/TextView;I)V", "")]
		public static unsafe void AssignTextViewWithAttr (global::Android.Widget.TextView textView, int attrRes)
		{
			const string __id = "assignTextViewWithAttr.(Landroid/widget/TextView;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((textView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textView).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (textView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrColor' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrColor", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetAttrColor (global::Android.Content.Context context, int attrRes)
		{
			const string __id = "getAttrColor.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrColor' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources.Theme'] and parameter[2][@type='int']]"
		[Register ("getAttrColor", "(Landroid/content/res/Resources$Theme;I)I", "")]
		public static unsafe int GetAttrColor (global::Android.Content.Res.Resources.Theme theme, int attr)
		{
			const string __id = "getAttrColor.(Landroid/content/res/Resources$Theme;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [1] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (theme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrColorStateList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.Resources.Theme'] and parameter[3][@type='int']]"
		[Register ("getAttrColorStateList", "(Landroid/content/Context;Landroid/content/res/Resources$Theme;I)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetAttrColorStateList (global::Android.Content.Context context, global::Android.Content.Res.Resources.Theme theme, int attr)
		{
			const string __id = "getAttrColorStateList.(Landroid/content/Context;Landroid/content/res/Resources$Theme;I)Landroid/content/res/ColorStateList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [2] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (theme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrColorStateList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrColorStateList", "(Landroid/content/Context;I)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetAttrColorStateList (global::Android.Content.Context context, int attrRes)
		{
			const string __id = "getAttrColorStateList.(Landroid/content/Context;I)Landroid/content/res/ColorStateList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrDimen' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrDimen", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetAttrDimen (global::Android.Content.Context context, int attrRes)
		{
			const string __id = "getAttrDimen.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrDrawable' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.Resources.Theme'] and parameter[3][@type='int']]"
		[Register ("getAttrDrawable", "(Landroid/content/Context;Landroid/content/res/Resources$Theme;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetAttrDrawable (global::Android.Content.Context context, global::Android.Content.Res.Resources.Theme theme, int attr)
		{
			const string __id = "getAttrDrawable.(Landroid/content/Context;Landroid/content/res/Resources$Theme;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [2] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (theme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrDrawable' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.res.TypedArray'] and parameter[3][@type='int']]"
		[Register ("getAttrDrawable", "(Landroid/content/Context;Landroid/content/res/TypedArray;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetAttrDrawable (global::Android.Content.Context context, global::Android.Content.Res.TypedArray typedArray, int index)
		{
			const string __id = "getAttrDrawable.(Landroid/content/Context;Landroid/content/res/TypedArray;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((typedArray == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typedArray).Handle);
				__args [2] = new JniArgumentValue (index);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (typedArray);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrDrawable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrDrawable", "(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetAttrDrawable (global::Android.Content.Context context, int attr)
		{
			const string __id = "getAttrDrawable.(Landroid/content/Context;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrFloatValue' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrFloatValue", "(Landroid/content/Context;I)F", "")]
		public static unsafe float GetAttrFloatValue (global::Android.Content.Context context, int attr)
		{
			const string __id = "getAttrFloatValue.(Landroid/content/Context;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrFloatValue' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources.Theme'] and parameter[2][@type='int']]"
		[Register ("getAttrFloatValue", "(Landroid/content/res/Resources$Theme;I)F", "")]
		public static unsafe float GetAttrFloatValue (global::Android.Content.Res.Resources.Theme theme, int attr)
		{
			const string __id = "getAttrFloatValue.(Landroid/content/res/Resources$Theme;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [1] = new JniArgumentValue (attr);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (theme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrInt' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrInt", "(Landroid/content/Context;I)I", "")]
		public static unsafe int GetAttrInt (global::Android.Content.Context context, int attrRes)
		{
			const string __id = "getAttrInt.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUIResHelper']/method[@name='getAttrString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("getAttrString", "(Landroid/content/Context;I)Ljava/lang/String;", "")]
		public static unsafe string GetAttrString (global::Android.Content.Context context, int attrRes)
		{
			const string __id = "getAttrString.(Landroid/content/Context;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (attrRes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

	}
}
