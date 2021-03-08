using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Kotlin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/kotlin/LayoutParamKtKt", DoNotGenerateAcw=true)]
	public sealed partial class LayoutParamKtKt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/kotlin/LayoutParamKtKt", typeof (LayoutParamKtKt));
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

		internal LayoutParamKtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe int ConstraintParentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='getConstraintParentId' and count(parameter)=0]"
			[Register ("getConstraintParentId", "()I", "")]
			get {
				const string __id = "getConstraintParentId.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int MatchConstraint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='getMatchConstraint' and count(parameter)=0]"
			[Register ("getMatchConstraint", "()I", "")]
			get {
				const string __id = "getMatchConstraint.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int MatchParent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='getMatchParent' and count(parameter)=0]"
			[Register ("getMatchParent", "()I", "")]
			get {
				const string __id = "getMatchParent.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int WrapContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='getWrapContent' and count(parameter)=0]"
			[Register ("getWrapContent", "()I", "")]
			get {
				const string __id = "getWrapContent.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParent4' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParent4", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParent4 (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParent4.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentHor' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentHor", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentHor (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentHor.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentLeftBottom' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentLeftBottom", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentLeftBottom (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentLeftBottom.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentLeftTop' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentLeftTop", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentLeftTop (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentLeftTop.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentRightBottom' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentRightBottom", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentRightBottom (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentRightBottom.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentRightTop' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentRightTop", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentRightTop (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentRightTop.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignParentVer' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("alignParentVer", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V", "")]
		public static unsafe void AlignParentVer (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj)
		{
			const string __id = "alignParentVer.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignView4' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignView4", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignView4 (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignView4.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewHor' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewHor", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewHor (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewHor.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewLeftBottom' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewLeftBottom", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewLeftBottom (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewLeftBottom.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewLeftTop' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewLeftTop", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewLeftTop (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewLeftTop.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewRightBottom' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewRightBottom", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewRightBottom (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewRightBottom.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewRightTop' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewRightTop", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewRightTop (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewRightTop.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='LayoutParamKtKt']/method[@name='alignViewVer' and count(parameter)=2 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[2][@type='int']]"
		[Register ("alignViewVer", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V", "")]
		public static unsafe void AlignViewVer (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams obj, int id)
		{
			const string __id = "alignViewVer.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
