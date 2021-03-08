using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Skin {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/skin/QMUISkinHelper", DoNotGenerateAcw=true)]
	public partial class QMUISkinHelper : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/field[@name='sSkinValueBuilder']"
		[Register ("sSkinValueBuilder")]
		public static global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder SSkinValueBuilder {
			get {
				const string __id = "sSkinValueBuilder.Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sSkinValueBuilder.Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/skin/QMUISkinHelper", typeof (QMUISkinHelper));
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

		protected QMUISkinHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/constructor[@name='QMUISkinHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe QMUISkinHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getCurrentSkinIndex' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getCurrentSkinIndex", "(Landroid/view/View;)I", "")]
		public static unsafe int GetCurrentSkinIndex (global::Android.Views.View view)
		{
			const string __id = "getCurrentSkinIndex.(Landroid/view/View;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getSkinApplyListener' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSkinApplyListener", "(Landroid/view/View;)Lcom/qmuiteam/qmui/skin/IQMUISkinApplyListener;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListener GetSkinApplyListener (global::Android.Views.View view)
		{
			const string __id = "getSkinApplyListener.(Landroid/view/View;)Lcom/qmuiteam/qmui/skin/IQMUISkinApplyListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getSkinColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getSkinColor", "(Landroid/view/View;I)I", "")]
		public static unsafe int GetSkinColor (global::Android.Views.View view, int colorAttr)
		{
			const string __id = "getSkinColor.(Landroid/view/View;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (colorAttr);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getSkinColorStateList' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getSkinColorStateList", "(Landroid/view/View;I)Landroid/content/res/ColorStateList;", "")]
		public static unsafe global::Android.Content.Res.ColorStateList GetSkinColorStateList (global::Android.Views.View view, int colorAttr)
		{
			const string __id = "getSkinColorStateList.(Landroid/view/View;I)Landroid/content/res/ColorStateList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (colorAttr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getSkinDrawable' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("getSkinDrawable", "(Landroid/view/View;I)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetSkinDrawable (global::Android.Views.View view, int drawableAttr)
		{
			const string __id = "getSkinDrawable.(Landroid/view/View;I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (drawableAttr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='getSkinTheme' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getSkinTheme", "(Landroid/view/View;)Landroid/content/res/Resources$Theme;", "")]
		public static unsafe global::Android.Content.Res.Resources.Theme GetSkinTheme (global::Android.Views.View view)
		{
			const string __id = "getSkinTheme.(Landroid/view/View;)Landroid/content/res/Resources$Theme;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='refreshRVItemDecoration' and count(parameter)=2 and parameter[1][@type='androidx.recyclerview.widget.RecyclerView'] and parameter[2][@type='com.qmuiteam.qmui.skin.IQMUISkinHandlerDecoration']]"
		[Register ("refreshRVItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/IQMUISkinHandlerDecoration;)V", "")]
		public static unsafe void RefreshRVItemDecoration (global::AndroidX.RecyclerView.Widget.RecyclerView view, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerDecoration itemDecoration)
		{
			const string __id = "refreshRVItemDecoration.(Landroidx/recyclerview/widget/RecyclerView;Lcom/qmuiteam/qmui/skin/IQMUISkinHandlerDecoration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((itemDecoration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) itemDecoration).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (itemDecoration);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='refreshViewSkin' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("refreshViewSkin", "(Landroid/view/View;)V", "")]
		public static unsafe void RefreshViewSkin (global::Android.Views.View view)
		{
			const string __id = "refreshViewSkin.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setIgnoreSkinApply' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("setIgnoreSkinApply", "(Landroid/view/View;Z)V", "")]
		public static unsafe void SetIgnoreSkinApply (global::Android.Views.View view, bool ignore)
		{
			const string __id = "setIgnoreSkinApply.(Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (ignore);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setInterceptSkinDispatch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean']]"
		[Register ("setInterceptSkinDispatch", "(Landroid/view/View;Z)V", "")]
		public static unsafe void SetInterceptSkinDispatch (global::Android.Views.View view, bool intercept)
		{
			const string __id = "setInterceptSkinDispatch.(Landroid/view/View;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (intercept);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setSkinApplyListener' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.IQMUISkinApplyListener']]"
		[Register ("setSkinApplyListener", "(Landroid/view/View;Lcom/qmuiteam/qmui/skin/IQMUISkinApplyListener;)V", "")]
		public static unsafe void SetSkinApplyListener (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinApplyListener listener)
		{
			const string __id = "setSkinApplyListener.(Landroid/view/View;Lcom/qmuiteam/qmui/skin/IQMUISkinApplyListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (listener);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setSkinDefaultProvider' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.defaultAttr.IQMUISkinDefaultAttrProvider']]"
		[Register ("setSkinDefaultProvider", "(Landroid/view/View;Lcom/qmuiteam/qmui/skin/defaultAttr/IQMUISkinDefaultAttrProvider;)V", "")]
		public static unsafe void SetSkinDefaultProvider (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider provider)
		{
			const string __id = "setSkinDefaultProvider.(Landroid/view/View;Lcom/qmuiteam/qmui/skin/defaultAttr/IQMUISkinDefaultAttrProvider;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((provider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) provider).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (provider);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setSkinValue' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.QMUISkinValueBuilder']]"
		[Register ("setSkinValue", "(Landroid/view/View;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V", "")]
		public static unsafe void SetSkinValue (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Skin.QMUISkinValueBuilder skinValueBuilder)
		{
			const string __id = "setSkinValue.(Landroid/view/View;Lcom/qmuiteam/qmui/skin/QMUISkinValueBuilder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((skinValueBuilder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinValueBuilder).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (skinValueBuilder);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setSkinValue' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.skin.SkinWriter']]"
		[Register ("setSkinValue", "(Landroid/view/View;Lcom/qmuiteam/qmui/skin/SkinWriter;)V", "")]
		public static unsafe void SetSkinValue (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Skin.ISkinWriter writer)
		{
			const string __id = "setSkinValue.(Landroid/view/View;Lcom/qmuiteam/qmui/skin/SkinWriter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((writer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) writer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (writer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='setSkinValue' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSkinValue", "(Landroid/view/View;Ljava/lang/String;)V", "")]
		public static unsafe void SetSkinValue (global::Android.Views.View view, string value)
		{
			const string __id = "setSkinValue.(Landroid/view/View;Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
				global::System.GC.KeepAlive (view);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='syncViewSkin' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.View']]"
		[Register ("syncViewSkin", "(Landroid/view/View;Landroid/view/View;)V", "")]
		public static unsafe void SyncViewSkin (global::Android.Views.View view, global::Android.Views.View sourceView)
		{
			const string __id = "syncViewSkin.(Landroid/view/View;Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((sourceView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sourceView).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (sourceView);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.skin']/class[@name='QMUISkinHelper']/method[@name='warnRuleNotSupport' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.lang.String']]"
		[Register ("warnRuleNotSupport", "(Landroid/view/View;Ljava/lang/String;)V", "")]
		public static unsafe void WarnRuleNotSupport (global::Android.Views.View view, string rule)
		{
			const string __id = "warnRuleNotSupport.(Landroid/view/View;Ljava/lang/String;)V";
			IntPtr native_rule = JNIEnv.NewString (rule);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (native_rule);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rule);
				global::System.GC.KeepAlive (view);
			}
		}

	}
}
