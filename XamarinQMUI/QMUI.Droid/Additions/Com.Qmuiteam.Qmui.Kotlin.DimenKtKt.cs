using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Kotlin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/kotlin/DimenKtKt", DoNotGenerateAcw=true)]
	public sealed partial class DimenKtKt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/kotlin/DimenKtKt", typeof (DimenKtKt));
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

		internal DimenKtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dimen' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dimen", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Dimen (global::Android.Content.Context obj, int resource)
		{
			const string __id = "dimen.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (resource);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dimen' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("dimen", "(Landroid/view/View;I)I", "")]
		public static unsafe int Dimen (global::Android.Views.View obj, int resource)
		{
			const string __id = "dimen.(Landroid/view/View;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (resource);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dimen' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='int']]"
		[Register ("dimen", "(Landroidx/fragment/app/Fragment;I)I", "")]
		public static unsafe int Dimen (global::AndroidX.Fragment.App.Fragment obj, int resource)
		{
			const string __id = "dimen.(Landroidx/fragment/app/Fragment;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (resource);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("dip", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Dip (global::Android.Content.Context obj, float value)
		{
			const string __id = "dip.(Landroid/content/Context;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("dip", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Dip (global::Android.Content.Context obj, int value)
		{
			const string __id = "dip.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("dip", "(Landroid/view/View;F)I", "")]
		public static unsafe int Dip (global::Android.Views.View obj, float value)
		{
			const string __id = "dip.(Landroid/view/View;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("dip", "(Landroid/view/View;I)I", "")]
		public static unsafe int Dip (global::Android.Views.View obj, int value)
		{
			const string __id = "dip.(Landroid/view/View;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='float']]"
		[Register ("dip", "(Landroidx/fragment/app/Fragment;F)I", "")]
		public static unsafe int Dip (global::AndroidX.Fragment.App.Fragment obj, float value)
		{
			const string __id = "dip.(Landroidx/fragment/app/Fragment;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='dip' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='int']]"
		[Register ("dip", "(Landroidx/fragment/app/Fragment;I)I", "")]
		public static unsafe int Dip (global::AndroidX.Fragment.App.Fragment obj, int value)
		{
			const string __id = "dip.(Landroidx/fragment/app/Fragment;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2dp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("px2dp", "(Landroid/content/Context;I)F", "")]
		public static unsafe float Px2dp (global::Android.Content.Context obj, int px)
		{
			const string __id = "px2dp.(Landroid/content/Context;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2dp' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("px2dp", "(Landroid/view/View;I)F", "")]
		public static unsafe float Px2dp (global::Android.Views.View obj, int px)
		{
			const string __id = "px2dp.(Landroid/view/View;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2dp' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='int']]"
		[Register ("px2dp", "(Landroidx/fragment/app/Fragment;I)F", "")]
		public static unsafe float Px2dp (global::AndroidX.Fragment.App.Fragment obj, int px)
		{
			const string __id = "px2dp.(Landroidx/fragment/app/Fragment;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2sp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("px2sp", "(Landroid/content/Context;I)F", "")]
		public static unsafe float Px2sp (global::Android.Content.Context obj, int px)
		{
			const string __id = "px2sp.(Landroid/content/Context;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2sp' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("px2sp", "(Landroid/view/View;I)F", "")]
		public static unsafe float Px2sp (global::Android.Views.View obj, int px)
		{
			const string __id = "px2sp.(Landroid/view/View;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='px2sp' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='int']]"
		[Register ("px2sp", "(Landroidx/fragment/app/Fragment;I)F", "")]
		public static unsafe float Px2sp (global::AndroidX.Fragment.App.Fragment obj, int px)
		{
			const string __id = "px2sp.(Landroidx/fragment/app/Fragment;I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='float']]"
		[Register ("sp", "(Landroid/content/Context;F)I", "")]
		public static unsafe int Sp (global::Android.Content.Context obj, float value)
		{
			const string __id = "sp.(Landroid/content/Context;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("sp", "(Landroid/content/Context;I)I", "")]
		public static unsafe int Sp (global::Android.Content.Context obj, int value)
		{
			const string __id = "sp.(Landroid/content/Context;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='float']]"
		[Register ("sp", "(Landroid/view/View;F)I", "")]
		public static unsafe int Sp (global::Android.Views.View obj, float value)
		{
			const string __id = "sp.(Landroid/view/View;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("sp", "(Landroid/view/View;I)I", "")]
		public static unsafe int Sp (global::Android.Views.View obj, int value)
		{
			const string __id = "sp.(Landroid/view/View;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='float']]"
		[Register ("sp", "(Landroidx/fragment/app/Fragment;F)I", "")]
		public static unsafe int Sp (global::AndroidX.Fragment.App.Fragment obj, float value)
		{
			const string __id = "sp.(Landroidx/fragment/app/Fragment;F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.kotlin']/class[@name='DimenKtKt']/method[@name='sp' and count(parameter)=2 and parameter[1][@type='androidx.fragment.app.Fragment'] and parameter[2][@type='int']]"
		[Register ("sp", "(Landroidx/fragment/app/Fragment;I)I", "")]
		public static unsafe int Sp (global::AndroidX.Fragment.App.Fragment obj, int value)
		{
			const string __id = "sp.(Landroidx/fragment/app/Fragment;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
