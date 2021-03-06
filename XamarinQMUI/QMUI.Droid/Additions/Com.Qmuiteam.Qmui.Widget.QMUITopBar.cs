using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUITopBar", DoNotGenerateAcw=true)]
	public partial class QMUITopBar : global::Com.Qmuiteam.Qmui.Layout.QMUIRelativeLayout, global::Com.Qmuiteam.Qmui.Skin.IQMUISkinHandlerView, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUITopBar.Action']"
		[Register ("com/qmuiteam/qmui/widget/QMUITopBar$Action", "", "Com.Qmuiteam.Qmui.Widget.QMUITopBar/IActionInvoker")]
		public partial interface IAction : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/interface[@name='QMUITopBar.Action']/method[@name='call' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register ("call", "(Landroid/view/View;IZ)V", "GetCall_Landroid_view_View_IZHandler:Com.Qmuiteam.Qmui.Widget.QMUITopBar/IActionInvoker, QMUI.Droid")]
			void Call (global::Android.Views.View p0, int p1, bool p2);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/QMUITopBar$Action", DoNotGenerateAcw=true)]
		internal partial class IActionInvoker : global::Java.Lang.Object, IAction {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUITopBar$Action", typeof (IActionInvoker));

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

			public static IAction GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAction> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.QMUITopBar.Action"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_call_Landroid_view_View_IZ;
#pragma warning disable 0169
			static Delegate GetCall_Landroid_view_View_IZHandler ()
			{
				if (cb_call_Landroid_view_View_IZ == null)
					cb_call_Landroid_view_View_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIZ_V) n_Call_Landroid_view_View_IZ);
				return cb_call_Landroid_view_View_IZ;
			}

			static void n_Call_Landroid_view_View_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar.IAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Call (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_call_Landroid_view_View_IZ;
			public unsafe void Call (global::Android.Views.View p0, int p1, bool p2)
			{
				if (id_call_Landroid_view_View_IZ == IntPtr.Zero)
					id_call_Landroid_view_View_IZ = JNIEnv.GetMethodID (class_ref, "call", "(Landroid/view/View;IZ)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_call_Landroid_view_View_IZ, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/QMUITopBar", typeof (QMUITopBar));
		internal static new IntPtr class_ref {
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

		protected QMUITopBar (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/constructor[@name='QMUITopBar' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUITopBar (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/constructor[@name='QMUITopBar' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUITopBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/constructor[@name='QMUITopBar' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe QMUITopBar (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
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

		static Delegate cb_getSubTitleView;
#pragma warning disable 0169
		static Delegate GetGetSubTitleViewHandler ()
		{
			if (cb_getSubTitleView == null)
				cb_getSubTitleView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSubTitleView);
			return cb_getSubTitleView;
		}

		static IntPtr n_GetSubTitleView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SubTitleView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SubTitleView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getSubTitleView' and count(parameter)=0]"
			[Register ("getSubTitleView", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetGetSubTitleViewHandler")]
			get {
				const string __id = "getSubTitleView.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.TitleFormatted);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence TitleFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public string Title {
			get { return TitleFormatted == null ? null : TitleFormatted.ToString (); }
		}

		static Delegate cb_getTitleContainerRect;
#pragma warning disable 0169
		static Delegate GetGetTitleContainerRectHandler ()
		{
			if (cb_getTitleContainerRect == null)
				cb_getTitleContainerRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitleContainerRect);
			return cb_getTitleContainerRect;
		}

		static IntPtr n_GetTitleContainerRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleContainerRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Rect TitleContainerRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getTitleContainerRect' and count(parameter)=0]"
			[Register ("getTitleContainerRect", "()Landroid/graphics/Rect;", "GetGetTitleContainerRectHandler")]
			get {
				const string __id = "getTitleContainerRect.()Landroid/graphics/Rect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleContainerView;
#pragma warning disable 0169
		static Delegate GetGetTitleContainerViewHandler ()
		{
			if (cb_getTitleContainerView == null)
				cb_getTitleContainerView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitleContainerView);
			return cb_getTitleContainerView;
		}

		static IntPtr n_GetTitleContainerView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleContainerView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Widget.LinearLayout TitleContainerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getTitleContainerView' and count(parameter)=0]"
			[Register ("getTitleContainerView", "()Landroid/widget/LinearLayout;", "GetGetTitleContainerViewHandler")]
			get {
				const string __id = "getTitleContainerView.()Landroid/widget/LinearLayout;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitleView;
#pragma warning disable 0169
		static Delegate GetGetTitleViewHandler ()
		{
			if (cb_getTitleView == null)
				cb_getTitleView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTitleView);
			return cb_getTitleView;
		}

		static IntPtr n_GetTitleView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TitleView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView TitleView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='getTitleView' and count(parameter)=0]"
			[Register ("getTitleView", "()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetGetTitleViewHandler")]
			get {
				const string __id = "getTitleView.()Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addLeftBackImageButton;
#pragma warning disable 0169
		static Delegate GetAddLeftBackImageButtonHandler ()
		{
			if (cb_addLeftBackImageButton == null)
				cb_addLeftBackImageButton = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AddLeftBackImageButton);
			return cb_addLeftBackImageButton;
		}

		static IntPtr n_AddLeftBackImageButton (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddLeftBackImageButton ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftBackImageButton' and count(parameter)=0]"
		[Register ("addLeftBackImageButton", "()Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddLeftBackImageButtonHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddLeftBackImageButton ()
		{
			const string __id = "addLeftBackImageButton.()Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addLeftImageButton_IZI;
#pragma warning disable 0169
		static Delegate GetAddLeftImageButton_IZIHandler ()
		{
			if (cb_addLeftImageButton_IZI == null)
				cb_addLeftImageButton_IZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZI_L) n_AddLeftImageButton_IZI);
			return cb_addLeftImageButton_IZI;
		}

		static IntPtr n_AddLeftImageButton_IZI (IntPtr jnienv, IntPtr native__this, int drawableResId, bool followTintColor, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddLeftImageButton (drawableResId, followTintColor, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftImageButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("addLeftImageButton", "(IZI)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddLeftImageButton_IZIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddLeftImageButton (int drawableResId, bool followTintColor, int viewId)
		{
			const string __id = "addLeftImageButton.(IZI)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (followTintColor);
				__args [2] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addLeftImageButton_IZIII;
#pragma warning disable 0169
		static Delegate GetAddLeftImageButton_IZIIIHandler ()
		{
			if (cb_addLeftImageButton_IZIII == null)
				cb_addLeftImageButton_IZIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZIII_L) n_AddLeftImageButton_IZIII);
			return cb_addLeftImageButton_IZIII;
		}

		static IntPtr n_AddLeftImageButton_IZIII (IntPtr jnienv, IntPtr native__this, int drawableResId, bool followTintColor, int viewId, int iconWidth, int iconHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddLeftImageButton (drawableResId, followTintColor, viewId, iconWidth, iconHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftImageButton' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("addLeftImageButton", "(IZIII)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddLeftImageButton_IZIIIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddLeftImageButton (int drawableResId, bool followTintColor, int viewId, int iconWidth, int iconHeight)
		{
			const string __id = "addLeftImageButton.(IZIII)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (followTintColor);
				__args [2] = new JniArgumentValue (viewId);
				__args [3] = new JniArgumentValue (iconWidth);
				__args [4] = new JniArgumentValue (iconHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addLeftImageButton_II;
#pragma warning disable 0169
		static Delegate GetAddLeftImageButton_IIHandler ()
		{
			if (cb_addLeftImageButton_II == null)
				cb_addLeftImageButton_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_AddLeftImageButton_II);
			return cb_addLeftImageButton_II;
		}

		static IntPtr n_AddLeftImageButton_II (IntPtr jnienv, IntPtr native__this, int drawableResId, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddLeftImageButton (drawableResId, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftImageButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addLeftImageButton", "(II)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddLeftImageButton_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddLeftImageButton (int drawableResId, int viewId)
		{
			const string __id = "addLeftImageButton.(II)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addLeftTextButton_II;
#pragma warning disable 0169
		static Delegate GetAddLeftTextButton_IIHandler ()
		{
			if (cb_addLeftTextButton_II == null)
				cb_addLeftTextButton_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_AddLeftTextButton_II);
			return cb_addLeftTextButton_II;
		}

		static IntPtr n_AddLeftTextButton_II (IntPtr jnienv, IntPtr native__this, int stringResId, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddLeftTextButton (stringResId, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftTextButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addLeftTextButton", "(II)Landroid/widget/Button;", "GetAddLeftTextButton_IIHandler")]
		public virtual unsafe global::Android.Widget.Button AddLeftTextButton (int stringResId, int viewId)
		{
			const string __id = "addLeftTextButton.(II)Landroid/widget/Button;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (stringResId);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addLeftTextButton_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddLeftTextButton_Ljava_lang_String_IHandler ()
		{
			if (cb_addLeftTextButton_Ljava_lang_String_I == null)
				cb_addLeftTextButton_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddLeftTextButton_Ljava_lang_String_I);
			return cb_addLeftTextButton_Ljava_lang_String_I;
		}

		static IntPtr n_AddLeftTextButton_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonText, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buttonText = JNIEnv.GetString (native_buttonText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddLeftTextButton (buttonText, viewId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftTextButton' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addLeftTextButton", "(Ljava/lang/String;I)Landroid/widget/Button;", "GetAddLeftTextButton_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Android.Widget.Button AddLeftTextButton (string buttonText, int viewId)
		{
			const string __id = "addLeftTextButton.(Ljava/lang/String;I)Landroid/widget/Button;";
			IntPtr native_buttonText = JNIEnv.NewString (buttonText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buttonText);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_buttonText);
			}
		}

		static Delegate cb_addLeftView_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetAddLeftView_Landroid_view_View_IHandler ()
		{
			if (cb_addLeftView_Landroid_view_View_I == null)
				cb_addLeftView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_AddLeftView_Landroid_view_View_I);
			return cb_addLeftView_Landroid_view_View_I;
		}

		static void n_AddLeftView_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.AddLeftView (view, viewId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("addLeftView", "(Landroid/view/View;I)V", "GetAddLeftView_Landroid_view_View_IHandler")]
		public virtual unsafe void AddLeftView (global::Android.Views.View view, int viewId)
		{
			const string __id = "addLeftView.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (viewId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_addLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_Handler ()
		{
			if (cb_addLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ == null)
				cb_addLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_AddLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_);
			return cb_addLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_;
		}

		static void n_AddLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewId, IntPtr native_layoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var layoutParams = global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (native_layoutParams, JniHandleOwnership.DoNotTransfer);
			__this.AddLeftView (view, viewId, layoutParams);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addLeftView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.widget.RelativeLayout.LayoutParams']]"
		[Register ("addLeftView", "(Landroid/view/View;ILandroid/widget/RelativeLayout$LayoutParams;)V", "GetAddLeftView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_Handler")]
		public virtual unsafe void AddLeftView (global::Android.Views.View view, int viewId, global::Android.Widget.RelativeLayout.LayoutParams layoutParams)
		{
			const string __id = "addLeftView.(Landroid/view/View;ILandroid/widget/RelativeLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (viewId);
				__args [2] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		static Delegate cb_addRightImageButton_IZI;
#pragma warning disable 0169
		static Delegate GetAddRightImageButton_IZIHandler ()
		{
			if (cb_addRightImageButton_IZI == null)
				cb_addRightImageButton_IZI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZI_L) n_AddRightImageButton_IZI);
			return cb_addRightImageButton_IZI;
		}

		static IntPtr n_AddRightImageButton_IZI (IntPtr jnienv, IntPtr native__this, int drawableResId, bool followTintColor, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddRightImageButton (drawableResId, followTintColor, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightImageButton' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("addRightImageButton", "(IZI)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddRightImageButton_IZIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddRightImageButton (int drawableResId, bool followTintColor, int viewId)
		{
			const string __id = "addRightImageButton.(IZI)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (followTintColor);
				__args [2] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addRightImageButton_IZIII;
#pragma warning disable 0169
		static Delegate GetAddRightImageButton_IZIIIHandler ()
		{
			if (cb_addRightImageButton_IZIII == null)
				cb_addRightImageButton_IZIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZIII_L) n_AddRightImageButton_IZIII);
			return cb_addRightImageButton_IZIII;
		}

		static IntPtr n_AddRightImageButton_IZIII (IntPtr jnienv, IntPtr native__this, int drawableResId, bool followTintColor, int viewId, int iconWidth, int iconHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddRightImageButton (drawableResId, followTintColor, viewId, iconWidth, iconHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightImageButton' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("addRightImageButton", "(IZIII)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddRightImageButton_IZIIIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddRightImageButton (int drawableResId, bool followTintColor, int viewId, int iconWidth, int iconHeight)
		{
			const string __id = "addRightImageButton.(IZIII)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (followTintColor);
				__args [2] = new JniArgumentValue (viewId);
				__args [3] = new JniArgumentValue (iconWidth);
				__args [4] = new JniArgumentValue (iconHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addRightImageButton_II;
#pragma warning disable 0169
		static Delegate GetAddRightImageButton_IIHandler ()
		{
			if (cb_addRightImageButton_II == null)
				cb_addRightImageButton_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_AddRightImageButton_II);
			return cb_addRightImageButton_II;
		}

		static IntPtr n_AddRightImageButton_II (IntPtr jnienv, IntPtr native__this, int drawableResId, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddRightImageButton (drawableResId, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightImageButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addRightImageButton", "(II)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;", "GetAddRightImageButton_IIHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton AddRightImageButton (int drawableResId, int viewId)
		{
			const string __id = "addRightImageButton.(II)Lcom/qmuiteam/qmui/alpha/QMUIAlphaImageButton;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (drawableResId);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Alpha.QMUIAlphaImageButton> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addRightTextButton_II;
#pragma warning disable 0169
		static Delegate GetAddRightTextButton_IIHandler ()
		{
			if (cb_addRightTextButton_II == null)
				cb_addRightTextButton_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_AddRightTextButton_II);
			return cb_addRightTextButton_II;
		}

		static IntPtr n_AddRightTextButton_II (IntPtr jnienv, IntPtr native__this, int stringResId, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AddRightTextButton (stringResId, viewId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightTextButton' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addRightTextButton", "(II)Landroid/widget/Button;", "GetAddRightTextButton_IIHandler")]
		public virtual unsafe global::Android.Widget.Button AddRightTextButton (int stringResId, int viewId)
		{
			const string __id = "addRightTextButton.(II)Landroid/widget/Button;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (stringResId);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addRightTextButton_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetAddRightTextButton_Ljava_lang_String_IHandler ()
		{
			if (cb_addRightTextButton_Ljava_lang_String_I == null)
				cb_addRightTextButton_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_L) n_AddRightTextButton_Ljava_lang_String_I);
			return cb_addRightTextButton_Ljava_lang_String_I;
		}

		static IntPtr n_AddRightTextButton_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_buttonText, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buttonText = JNIEnv.GetString (native_buttonText, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddRightTextButton (buttonText, viewId));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightTextButton' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addRightTextButton", "(Ljava/lang/String;I)Landroid/widget/Button;", "GetAddRightTextButton_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Android.Widget.Button AddRightTextButton (string buttonText, int viewId)
		{
			const string __id = "addRightTextButton.(Ljava/lang/String;I)Landroid/widget/Button;";
			IntPtr native_buttonText = JNIEnv.NewString (buttonText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buttonText);
				__args [1] = new JniArgumentValue (viewId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_buttonText);
			}
		}

		static Delegate cb_addRightView_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetAddRightView_Landroid_view_View_IHandler ()
		{
			if (cb_addRightView_Landroid_view_View_I == null)
				cb_addRightView_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_AddRightView_Landroid_view_View_I);
			return cb_addRightView_Landroid_view_View_I;
		}

		static void n_AddRightView_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.AddRightView (view, viewId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("addRightView", "(Landroid/view/View;I)V", "GetAddRightView_Landroid_view_View_IHandler")]
		public virtual unsafe void AddRightView (global::Android.Views.View view, int viewId)
		{
			const string __id = "addRightView.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (viewId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_addRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_Handler ()
		{
			if (cb_addRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ == null)
				cb_addRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_V) n_AddRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_);
			return cb_addRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_;
		}

		static void n_AddRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, int viewId, IntPtr native_layoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var layoutParams = global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (native_layoutParams, JniHandleOwnership.DoNotTransfer);
			__this.AddRightView (view, viewId, layoutParams);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='addRightView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='android.widget.RelativeLayout.LayoutParams']]"
		[Register ("addRightView", "(Landroid/view/View;ILandroid/widget/RelativeLayout$LayoutParams;)V", "GetAddRightView_Landroid_view_View_ILandroid_widget_RelativeLayout_LayoutParams_Handler")]
		public virtual unsafe void AddRightView (global::Android.Views.View view, int viewId, global::Android.Widget.RelativeLayout.LayoutParams layoutParams)
		{
			const string __id = "addRightView.(Landroid/view/View;ILandroid/widget/RelativeLayout$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (viewId);
				__args [2] = new JniArgumentValue ((layoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) layoutParams).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (layoutParams);
			}
		}

		static Delegate cb_computeAndSetBackgroundAlpha_III;
#pragma warning disable 0169
		static Delegate GetComputeAndSetBackgroundAlpha_IIIHandler ()
		{
			if (cb_computeAndSetBackgroundAlpha_III == null)
				cb_computeAndSetBackgroundAlpha_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_I) n_ComputeAndSetBackgroundAlpha_III);
			return cb_computeAndSetBackgroundAlpha_III;
		}

		static int n_ComputeAndSetBackgroundAlpha_III (IntPtr jnienv, IntPtr native__this, int currentOffset, int alphaBeginOffset, int alphaTargetOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComputeAndSetBackgroundAlpha (currentOffset, alphaBeginOffset, alphaTargetOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='computeAndSetBackgroundAlpha' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("computeAndSetBackgroundAlpha", "(III)I", "GetComputeAndSetBackgroundAlpha_IIIHandler")]
		public virtual unsafe int ComputeAndSetBackgroundAlpha (int currentOffset, int alphaBeginOffset, int alphaTargetOffset)
		{
			const string __id = "computeAndSetBackgroundAlpha.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (currentOffset);
				__args [1] = new JniArgumentValue (alphaBeginOffset);
				__args [2] = new JniArgumentValue (alphaTargetOffset);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_eachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_;
#pragma warning disable 0169
		static Delegate GetEachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_Handler ()
		{
			if (cb_eachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_ == null)
				cb_eachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_);
			return cb_eachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_;
		}

		static void n_EachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var action = (global::Com.Qmuiteam.Qmui.Widget.QMUITopBar.IAction)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar.IAction> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.EachLeftRightView (action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='eachLeftRightView' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.QMUITopBar.Action']]"
		[Register ("eachLeftRightView", "(Lcom/qmuiteam/qmui/widget/QMUITopBar$Action;)V", "GetEachLeftRightView_Lcom_qmuiteam_qmui_widget_QMUITopBar_Action_Handler")]
		public virtual unsafe void EachLeftRightView (global::Com.Qmuiteam.Qmui.Widget.QMUITopBar.IAction action)
		{
			const string __id = "eachLeftRightView.(Lcom/qmuiteam/qmui/widget/QMUITopBar$Action;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (action);
			}
		}

		static Delegate cb_generateTopBarImageButtonLayoutParams;
#pragma warning disable 0169
		static Delegate GetGenerateTopBarImageButtonLayoutParamsHandler ()
		{
			if (cb_generateTopBarImageButtonLayoutParams == null)
				cb_generateTopBarImageButtonLayoutParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateTopBarImageButtonLayoutParams);
			return cb_generateTopBarImageButtonLayoutParams;
		}

		static IntPtr n_GenerateTopBarImageButtonLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateTopBarImageButtonLayoutParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='generateTopBarImageButtonLayoutParams' and count(parameter)=0]"
		[Register ("generateTopBarImageButtonLayoutParams", "()Landroid/widget/RelativeLayout$LayoutParams;", "GetGenerateTopBarImageButtonLayoutParamsHandler")]
		public virtual unsafe global::Android.Widget.RelativeLayout.LayoutParams GenerateTopBarImageButtonLayoutParams ()
		{
			const string __id = "generateTopBarImageButtonLayoutParams.()Landroid/widget/RelativeLayout$LayoutParams;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_generateTopBarImageButtonLayoutParams_II;
#pragma warning disable 0169
		static Delegate GetGenerateTopBarImageButtonLayoutParams_IIHandler ()
		{
			if (cb_generateTopBarImageButtonLayoutParams_II == null)
				cb_generateTopBarImageButtonLayoutParams_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_L) n_GenerateTopBarImageButtonLayoutParams_II);
			return cb_generateTopBarImageButtonLayoutParams_II;
		}

		static IntPtr n_GenerateTopBarImageButtonLayoutParams_II (IntPtr jnienv, IntPtr native__this, int iconWidth, int iconHeight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateTopBarImageButtonLayoutParams (iconWidth, iconHeight));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='generateTopBarImageButtonLayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("generateTopBarImageButtonLayoutParams", "(II)Landroid/widget/RelativeLayout$LayoutParams;", "GetGenerateTopBarImageButtonLayoutParams_IIHandler")]
		public virtual unsafe global::Android.Widget.RelativeLayout.LayoutParams GenerateTopBarImageButtonLayoutParams (int iconWidth, int iconHeight)
		{
			const string __id = "generateTopBarImageButtonLayoutParams.(II)Landroid/widget/RelativeLayout$LayoutParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (iconWidth);
				__args [1] = new JniArgumentValue (iconHeight);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_generateTopBarTextButtonLayoutParams;
#pragma warning disable 0169
		static Delegate GetGenerateTopBarTextButtonLayoutParamsHandler ()
		{
			if (cb_generateTopBarTextButtonLayoutParams == null)
				cb_generateTopBarTextButtonLayoutParams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateTopBarTextButtonLayoutParams);
			return cb_generateTopBarTextButtonLayoutParams;
		}

		static IntPtr n_GenerateTopBarTextButtonLayoutParams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenerateTopBarTextButtonLayoutParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='generateTopBarTextButtonLayoutParams' and count(parameter)=0]"
		[Register ("generateTopBarTextButtonLayoutParams", "()Landroid/widget/RelativeLayout$LayoutParams;", "GetGenerateTopBarTextButtonLayoutParamsHandler")]
		public virtual unsafe global::Android.Widget.RelativeLayout.LayoutParams GenerateTopBarTextButtonLayoutParams ()
		{
			const string __id = "generateTopBarTextButtonLayoutParams.()Landroid/widget/RelativeLayout$LayoutParams;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout.LayoutParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
#pragma warning disable 0169
		static Delegate GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler ()
		{
			if (cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ == null)
				cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLILL_V) n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_);
			return cb_handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_;
		}

		static void n_Handle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_manager, int skinIndex, IntPtr native_theme, IntPtr native_attrs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var manager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_manager, JniHandleOwnership.DoNotTransfer);
			var theme = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (native_theme, JniHandleOwnership.DoNotTransfer);
			var attrs = global::Java.Lang.Object.GetObject<global::AndroidX.Collection.SimpleArrayMap> (native_attrs, JniHandleOwnership.DoNotTransfer);
			__this.Handle (manager, skinIndex, theme, attrs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='handle' and count(parameter)=4 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager'] and parameter[2][@type='int'] and parameter[3][@type='android.content.res.Resources.Theme'] and parameter[4][@type='androidx.collection.SimpleArrayMap&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("handle", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V", "GetHandle_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ILandroid_content_res_Resources_Theme_Landroidx_collection_SimpleArrayMap_Handler")]
		public new virtual unsafe void Handle (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager manager, int skinIndex, global::Android.Content.Res.Resources.Theme theme, global::AndroidX.Collection.SimpleArrayMap attrs)
		{
			const string __id = "handle.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;ILandroid/content/res/Resources$Theme;Landroidx/collection/SimpleArrayMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((manager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) manager).Handle);
				__args [1] = new JniArgumentValue (skinIndex);
				__args [2] = new JniArgumentValue ((theme == null) ? IntPtr.Zero : ((global::Java.Lang.Object) theme).Handle);
				__args [3] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (manager);
				global::System.GC.KeepAlive (theme);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_removeAllLeftViews;
#pragma warning disable 0169
		static Delegate GetRemoveAllLeftViewsHandler ()
		{
			if (cb_removeAllLeftViews == null)
				cb_removeAllLeftViews = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAllLeftViews);
			return cb_removeAllLeftViews;
		}

		static void n_RemoveAllLeftViews (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllLeftViews ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='removeAllLeftViews' and count(parameter)=0]"
		[Register ("removeAllLeftViews", "()V", "GetRemoveAllLeftViewsHandler")]
		public virtual unsafe void RemoveAllLeftViews ()
		{
			const string __id = "removeAllLeftViews.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeAllRightViews;
#pragma warning disable 0169
		static Delegate GetRemoveAllRightViewsHandler ()
		{
			if (cb_removeAllRightViews == null)
				cb_removeAllRightViews = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAllRightViews);
			return cb_removeAllRightViews;
		}

		static void n_RemoveAllRightViews (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllRightViews ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='removeAllRightViews' and count(parameter)=0]"
		[Register ("removeAllRightViews", "()V", "GetRemoveAllRightViewsHandler")]
		public virtual unsafe void RemoveAllRightViews ()
		{
			const string __id = "removeAllRightViews.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeCenterViewAndTitleView;
#pragma warning disable 0169
		static Delegate GetRemoveCenterViewAndTitleViewHandler ()
		{
			if (cb_removeCenterViewAndTitleView == null)
				cb_removeCenterViewAndTitleView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveCenterViewAndTitleView);
			return cb_removeCenterViewAndTitleView;
		}

		static void n_RemoveCenterViewAndTitleView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCenterViewAndTitleView ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='removeCenterViewAndTitleView' and count(parameter)=0]"
		[Register ("removeCenterViewAndTitleView", "()V", "GetRemoveCenterViewAndTitleViewHandler")]
		public virtual unsafe void RemoveCenterViewAndTitleView ()
		{
			const string __id = "removeCenterViewAndTitleView.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBackgroundAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundAlpha_IHandler ()
		{
			if (cb_setBackgroundAlpha_I == null)
				cb_setBackgroundAlpha_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBackgroundAlpha_I);
			return cb_setBackgroundAlpha_I;
		}

		static void n_SetBackgroundAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setBackgroundAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackgroundAlpha", "(I)V", "GetSetBackgroundAlpha_IHandler")]
		public virtual unsafe void SetBackgroundAlpha (int alpha)
		{
			const string __id = "setBackgroundAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetCenterView_Landroid_view_View_Handler ()
		{
			if (cb_setCenterView_Landroid_view_View_ == null)
				cb_setCenterView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCenterView_Landroid_view_View_);
			return cb_setCenterView_Landroid_view_View_;
		}

		static void n_SetCenterView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterView (view);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setCenterView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setCenterView", "(Landroid/view/View;)V", "GetSetCenterView_Landroid_view_View_Handler")]
		public virtual unsafe void SetCenterView (global::Android.Views.View view)
		{
			const string __id = "setCenterView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_setSubTitle_I;
#pragma warning disable 0169
		static Delegate GetSetSubTitle_IHandler ()
		{
			if (cb_setSubTitle_I == null)
				cb_setSubTitle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetSubTitle_I);
			return cb_setSubTitle_I;
		}

		static IntPtr n_SetSubTitle_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSubTitle (resId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setSubTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSubTitle", "(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetSetSubTitle_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SetSubTitle (int resId)
		{
			const string __id = "setSubTitle.(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSubTitle_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetSubTitle_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setSubTitle_Ljava_lang_CharSequence_ == null)
				cb_setSubTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSubTitle_Ljava_lang_CharSequence_);
			return cb_setSubTitle_Ljava_lang_CharSequence_;
		}

		static IntPtr n_SetSubTitle_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_subTitle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var subTitle = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_subTitle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSubTitle (subTitle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setSubTitle' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("setSubTitle", "(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetSetSubTitle_Ljava_lang_CharSequence_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SetSubTitle (global::Java.Lang.ICharSequence subTitle)
		{
			const string __id = "setSubTitle.(Ljava/lang/CharSequence;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
			IntPtr native_subTitle = CharSequence.ToLocalJniHandle (subTitle);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_subTitle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_subTitle);
				global::System.GC.KeepAlive (subTitle);
			}
		}

		public global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SetSubTitle (string subTitle)
		{
			var jls_subTitle = subTitle == null ? null : new global::Java.Lang.String (subTitle);
			global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView __result = SetSubTitle (jls_subTitle);
			var __rsval = __result;
			jls_subTitle?.Dispose ();
			return __rsval;
		}

		static Delegate cb_setTitle_I;
#pragma warning disable 0169
		static Delegate GetSetTitle_IHandler ()
		{
			if (cb_setTitle_I == null)
				cb_setTitle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTitle_I);
			return cb_setTitle_I;
		}

		static IntPtr n_SetTitle_I (IntPtr jnienv, IntPtr native__this, int resId)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTitle (resId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitle", "(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetSetTitle_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SetTitle (int resId)
		{
			const string __id = "setTitle.(I)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static IntPtr n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTitle (title));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView SetTitle (string title)
		{
			const string __id = "setTitle.(Ljava/lang/String;)Lcom/qmuiteam/qmui/qqface/QMUIQQFaceView;";
			IntPtr native_title = JNIEnv.NewString (title);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_title);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Qqface.QMUIQQFaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
			}
		}

		static Delegate cb_setTitleGravity_I;
#pragma warning disable 0169
		static Delegate GetSetTitleGravity_IHandler ()
		{
			if (cb_setTitleGravity_I == null)
				cb_setTitleGravity_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTitleGravity_I);
			return cb_setTitleGravity_I;
		}

		static void n_SetTitleGravity_I (IntPtr jnienv, IntPtr native__this, int gravity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTitleGravity (gravity);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='setTitleGravity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTitleGravity", "(I)V", "GetSetTitleGravity_IHandler")]
		public virtual unsafe void SetTitleGravity (int gravity)
		{
			const string __id = "setTitleGravity.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (gravity);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showTitleView_Z;
#pragma warning disable 0169
		static Delegate GetShowTitleView_ZHandler ()
		{
			if (cb_showTitleView_Z == null)
				cb_showTitleView_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_ShowTitleView_Z);
			return cb_showTitleView_Z;
		}

		static void n_ShowTitleView_Z (IntPtr jnienv, IntPtr native__this, bool toShow)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.QMUITopBar> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTitleView (toShow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget']/class[@name='QMUITopBar']/method[@name='showTitleView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showTitleView", "(Z)V", "GetShowTitleView_ZHandler")]
		public virtual unsafe void ShowTitleView (bool toShow)
		{
			const string __id = "showTitleView.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (toShow);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
