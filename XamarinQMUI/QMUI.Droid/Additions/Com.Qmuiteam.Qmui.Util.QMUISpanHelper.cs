using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/util/QMUISpanHelper", DoNotGenerateAcw=true)]
	public partial class QMUISpanHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/util/QMUISpanHelper", typeof (QMUISpanHelper));
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

		protected QMUISpanHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/constructor[@name='QMUISpanHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISpanHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateHorIconText' and count(parameter)=5 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.drawable.Drawable']]"
		[Register ("generateHorIconText", "(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;ILandroid/graphics/drawable/Drawable;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateHorIconTextFormatted (global::Java.Lang.ICharSequence text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight)
		{
			const string __id = "generateHorIconText.(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;ILandroid/graphics/drawable/Drawable;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (leftPadding);
				__args [2] = new JniArgumentValue ((iconLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconLeft).Handle);
				__args [3] = new JniArgumentValue (rightPadding);
				__args [4] = new JniArgumentValue ((iconRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconRight).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (iconLeft);
				global::System.GC.KeepAlive (iconRight);
			}
		}

		public static string GenerateHorIconText (string text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateHorIconTextFormatted (jls_text, leftPadding, iconLeft, rightPadding, iconRight);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateHorIconText' and count(parameter)=6 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.drawable.Drawable'] and parameter[6][@type='int']]"
		[Register ("generateHorIconText", "(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;ILandroid/graphics/drawable/Drawable;I)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateHorIconTextFormatted (global::Java.Lang.ICharSequence text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconOffsetY)
		{
			const string __id = "generateHorIconText.(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;ILandroid/graphics/drawable/Drawable;I)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (leftPadding);
				__args [2] = new JniArgumentValue ((iconLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconLeft).Handle);
				__args [3] = new JniArgumentValue (rightPadding);
				__args [4] = new JniArgumentValue ((iconRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconRight).Handle);
				__args [5] = new JniArgumentValue (iconOffsetY);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (iconLeft);
				global::System.GC.KeepAlive (iconRight);
			}
		}

		public static string GenerateHorIconText (string text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconOffsetY)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateHorIconTextFormatted (jls_text, leftPadding, iconLeft, rightPadding, iconRight, iconOffsetY);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateHorIconText' and count(parameter)=8 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.drawable.Drawable'] and parameter[7][@type='int'] and parameter[8][@type='android.view.View']]"
		[Register ("generateHorIconText", "(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;IILandroid/graphics/drawable/Drawable;ILandroid/view/View;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateHorIconTextFormatted (global::Java.Lang.ICharSequence text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int iconLeftTintAttr, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconRightTintAttr, global::Android.Views.View skinFollowView)
		{
			const string __id = "generateHorIconText.(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;IILandroid/graphics/drawable/Drawable;ILandroid/view/View;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (leftPadding);
				__args [2] = new JniArgumentValue ((iconLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconLeft).Handle);
				__args [3] = new JniArgumentValue (iconLeftTintAttr);
				__args [4] = new JniArgumentValue (rightPadding);
				__args [5] = new JniArgumentValue ((iconRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconRight).Handle);
				__args [6] = new JniArgumentValue (iconRightTintAttr);
				__args [7] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (iconLeft);
				global::System.GC.KeepAlive (iconRight);
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		public static string GenerateHorIconText (string text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int iconLeftTintAttr, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconRightTintAttr, global::Android.Views.View skinFollowView)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateHorIconTextFormatted (jls_text, leftPadding, iconLeft, iconLeftTintAttr, rightPadding, iconRight, iconRightTintAttr, skinFollowView);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateHorIconText' and count(parameter)=9 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.graphics.drawable.Drawable'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='android.view.View']]"
		[Register ("generateHorIconText", "(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;IILandroid/graphics/drawable/Drawable;IILandroid/view/View;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateHorIconTextFormatted (global::Java.Lang.ICharSequence text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int iconLeftTintAttr, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconRightTintAttr, int iconOffsetY, global::Android.Views.View skinFollowView)
		{
			const string __id = "generateHorIconText.(Ljava/lang/CharSequence;ILandroid/graphics/drawable/Drawable;IILandroid/graphics/drawable/Drawable;IILandroid/view/View;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (leftPadding);
				__args [2] = new JniArgumentValue ((iconLeft == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconLeft).Handle);
				__args [3] = new JniArgumentValue (iconLeftTintAttr);
				__args [4] = new JniArgumentValue (rightPadding);
				__args [5] = new JniArgumentValue ((iconRight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iconRight).Handle);
				__args [6] = new JniArgumentValue (iconRightTintAttr);
				__args [7] = new JniArgumentValue (iconOffsetY);
				__args [8] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (iconLeft);
				global::System.GC.KeepAlive (iconRight);
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		public static string GenerateHorIconText (string text, int leftPadding, global::Android.Graphics.Drawables.Drawable iconLeft, int iconLeftTintAttr, int rightPadding, global::Android.Graphics.Drawables.Drawable iconRight, int iconRightTintAttr, int iconOffsetY, global::Android.Views.View skinFollowView)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateHorIconTextFormatted (jls_text, leftPadding, iconLeft, iconLeftTintAttr, rightPadding, iconRight, iconRightTintAttr, iconOffsetY, skinFollowView);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateSideIconText' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='android.graphics.drawable.Drawable']]"
		[Register ("generateSideIconText", "(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateSideIconTextFormatted (bool left, int iconPadding, global::Java.Lang.ICharSequence text, global::Android.Graphics.Drawables.Drawable icon)
		{
			const string __id = "generateSideIconText.(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (iconPadding);
				__args [2] = new JniArgumentValue (native_text);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (icon);
			}
		}

		public static string GenerateSideIconText (bool left, int iconPadding, string text, global::Android.Graphics.Drawables.Drawable icon)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateSideIconTextFormatted (left, iconPadding, jls_text, icon);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateSideIconText' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='android.graphics.drawable.Drawable'] and parameter[5][@type='int']]"
		[Register ("generateSideIconText", "(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;I)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateSideIconTextFormatted (bool left, int iconPadding, global::Java.Lang.ICharSequence text, global::Android.Graphics.Drawables.Drawable icon, int iconOffsetY)
		{
			const string __id = "generateSideIconText.(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;I)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (iconPadding);
				__args [2] = new JniArgumentValue (native_text);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [4] = new JniArgumentValue (iconOffsetY);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (icon);
			}
		}

		public static string GenerateSideIconText (bool left, int iconPadding, string text, global::Android.Graphics.Drawables.Drawable icon, int iconOffsetY)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateSideIconTextFormatted (left, iconPadding, jls_text, icon, iconOffsetY);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateSideIconText' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='android.graphics.drawable.Drawable'] and parameter[5][@type='int'] and parameter[6][@type='android.view.View']]"
		[Register ("generateSideIconText", "(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;ILandroid/view/View;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateSideIconTextFormatted (bool left, int iconPadding, global::Java.Lang.ICharSequence text, global::Android.Graphics.Drawables.Drawable icon, int iconTintAttr, global::Android.Views.View skinFollowView)
		{
			const string __id = "generateSideIconText.(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;ILandroid/view/View;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (iconPadding);
				__args [2] = new JniArgumentValue (native_text);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [4] = new JniArgumentValue (iconTintAttr);
				__args [5] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (icon);
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		public static string GenerateSideIconText (bool left, int iconPadding, string text, global::Android.Graphics.Drawables.Drawable icon, int iconTintAttr, global::Android.Views.View skinFollowView)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateSideIconTextFormatted (left, iconPadding, jls_text, icon, iconTintAttr, skinFollowView);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.util']/class[@name='QMUISpanHelper']/method[@name='generateSideIconText' and count(parameter)=7 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='android.graphics.drawable.Drawable'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='android.view.View']]"
		[Register ("generateSideIconText", "(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;IILandroid/view/View;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GenerateSideIconTextFormatted (bool left, int iconPadding, global::Java.Lang.ICharSequence text, global::Android.Graphics.Drawables.Drawable icon, int iconOffsetY, int iconTintAttr, global::Android.Views.View skinFollowView)
		{
			const string __id = "generateSideIconText.(ZILjava/lang/CharSequence;Landroid/graphics/drawable/Drawable;IILandroid/view/View;)Ljava/lang/CharSequence;";
			IntPtr native_text = CharSequence.ToLocalJniHandle (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (iconPadding);
				__args [2] = new JniArgumentValue (native_text);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [4] = new JniArgumentValue (iconOffsetY);
				__args [5] = new JniArgumentValue (iconTintAttr);
				__args [6] = new JniArgumentValue ((skinFollowView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinFollowView).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
				global::System.GC.KeepAlive (text);
				global::System.GC.KeepAlive (icon);
				global::System.GC.KeepAlive (skinFollowView);
			}
		}

		public static string GenerateSideIconText (bool left, int iconPadding, string text, global::Android.Graphics.Drawables.Drawable icon, int iconOffsetY, int iconTintAttr, global::Android.Views.View skinFollowView)
		{
			var jls_text = text == null ? null : new global::Java.Lang.String (text);
			global::Java.Lang.ICharSequence __result = GenerateSideIconTextFormatted (left, iconPadding, jls_text, icon, iconOffsetY, iconTintAttr, skinFollowView);
			var __rsval = __result?.ToString ();
			jls_text?.Dispose ();
			return __rsval;
		}

	}
}
