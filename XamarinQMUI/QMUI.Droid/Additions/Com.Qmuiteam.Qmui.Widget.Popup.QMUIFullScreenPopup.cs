using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Popup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup", DoNotGenerateAcw=true)]
	public partial class QMUIFullScreenPopup : global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup.KeyboardPercentOffsetListener']"
		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$KeyboardPercentOffsetListener", DoNotGenerateAcw=true)]
		public partial class KeyboardPercentOffsetListener : global::Java.Lang.Object, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$KeyboardPercentOffsetListener", typeof (KeyboardPercentOffsetListener));
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

			protected KeyboardPercentOffsetListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup.KeyboardPercentOffsetListener']/constructor[@name='QMUIFullScreenPopup.KeyboardPercentOffsetListener' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register (".ctor", "(F)V", "")]
			public unsafe KeyboardPercentOffsetListener (float percent)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(F)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (percent);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onKeyboardToggle_Landroid_view_View_ZII;
#pragma warning disable 0169
			static Delegate GetOnKeyboardToggle_Landroid_view_View_ZIIHandler ()
			{
				if (cb_onKeyboardToggle_Landroid_view_View_ZII == null)
					cb_onKeyboardToggle_Landroid_view_View_ZII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZII_V) n_OnKeyboardToggle_Landroid_view_View_ZII);
				return cb_onKeyboardToggle_Landroid_view_View_ZII;
			}

			static void n_OnKeyboardToggle_Landroid_view_View_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_view, bool toShow, int keyboardHeight, int rootViewHeight)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.KeyboardPercentOffsetListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyboardToggle (view, toShow, keyboardHeight, rootViewHeight);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup.KeyboardPercentOffsetListener']/method[@name='onKeyboardToggle' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onKeyboardToggle", "(Landroid/view/View;ZII)V", "GetOnKeyboardToggle_Landroid_view_View_ZIIHandler")]
			public virtual unsafe void OnKeyboardToggle (global::Android.Views.View view, bool toShow, int keyboardHeight, int rootViewHeight)
			{
				const string __id = "onKeyboardToggle.(Landroid/view/View;ZII)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
					__args [1] = new JniArgumentValue (toShow);
					__args [2] = new JniArgumentValue (keyboardHeight);
					__args [3] = new JniArgumentValue (rootViewHeight);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (view);
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIFullScreenPopup.OnBlankClickListener']"
		[Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnBlankClickListener", "", "Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup/IOnBlankClickListenerInvoker")]
		public partial interface IOnBlankClickListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIFullScreenPopup.OnBlankClickListener']/method[@name='onBlankClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup']]"
			[Register ("onBlankClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;)V", "GetOnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_Handler:Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup/IOnBlankClickListenerInvoker, QMUI.Droid")]
			void OnBlankClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup popup);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnBlankClickListener", DoNotGenerateAcw=true)]
		internal partial class IOnBlankClickListenerInvoker : global::Java.Lang.Object, IOnBlankClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnBlankClickListener", typeof (IOnBlankClickListenerInvoker));

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

			public static IOnBlankClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBlankClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnBlankClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBlankClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_;
#pragma warning disable 0169
			static Delegate GetOnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_Handler ()
			{
				if (cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_ == null)
					cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_);
				return cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_;
			}

			static void n_OnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_ (IntPtr jnienv, IntPtr native__this, IntPtr native_popup)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnBlankClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var popup = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (native_popup, JniHandleOwnership.DoNotTransfer);
				__this.OnBlankClick (popup);
			}
#pragma warning restore 0169

			IntPtr id_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_;
			public unsafe void OnBlankClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup popup)
			{
				if (id_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_ == IntPtr.Zero)
					id_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_ = JNIEnv.GetMethodID (class_ref, "onBlankClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((popup == null) ? IntPtr.Zero : ((global::Java.Lang.Object) popup).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnBlankClickListener.onBlankClick
		public partial class BlankClickEventArgs : global::System.EventArgs {

			public BlankClickEventArgs (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup popup)
			{
				this.popup = popup;
			}

			global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup popup;
			public global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup Popup {
				get { return popup; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup_OnBlankClickListenerImplementor")]
		internal sealed partial class IOnBlankClickListenerImplementor : global::Java.Lang.Object, IOnBlankClickListener {

			object sender;

			public IOnBlankClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup_OnBlankClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BlankClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnBlankClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup popup)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BlankClickEventArgs (popup));
			}

			internal static bool __IsEmpty (IOnBlankClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIFullScreenPopup.OnKeyBoardListener']"
		[Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener", "", "Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup/IOnKeyBoardListenerInvoker")]
		public partial interface IOnKeyBoardListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/interface[@name='QMUIFullScreenPopup.OnKeyBoardListener']/method[@name='onKeyboardToggle' and count(parameter)=4 and parameter[1][@type='android.view.View'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("onKeyboardToggle", "(Landroid/view/View;ZII)V", "GetOnKeyboardToggle_Landroid_view_View_ZIIHandler:Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup/IOnKeyBoardListenerInvoker, QMUI.Droid")]
			void OnKeyboardToggle (global::Android.Views.View p0, bool p1, int p2, int p3);

		}

		[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener", DoNotGenerateAcw=true)]
		internal partial class IOnKeyBoardListenerInvoker : global::Java.Lang.Object, IOnKeyBoardListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener", typeof (IOnKeyBoardListenerInvoker));

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

			public static IOnKeyBoardListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnKeyBoardListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnKeyBoardListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnKeyBoardListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onKeyboardToggle_Landroid_view_View_ZII;
#pragma warning disable 0169
			static Delegate GetOnKeyboardToggle_Landroid_view_View_ZIIHandler ()
			{
				if (cb_onKeyboardToggle_Landroid_view_View_ZII == null)
					cb_onKeyboardToggle_Landroid_view_View_ZII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZII_V) n_OnKeyboardToggle_Landroid_view_View_ZII);
				return cb_onKeyboardToggle_Landroid_view_View_ZII;
			}

			static void n_OnKeyboardToggle_Landroid_view_View_ZII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1, int p2, int p3)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnKeyboardToggle (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onKeyboardToggle_Landroid_view_View_ZII;
			public unsafe void OnKeyboardToggle (global::Android.Views.View p0, bool p1, int p2, int p3)
			{
				if (id_onKeyboardToggle_Landroid_view_View_ZII == IntPtr.Zero)
					id_onKeyboardToggle_Landroid_view_View_ZII = JNIEnv.GetMethodID (class_ref, "onKeyboardToggle", "(Landroid/view/View;ZII)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onKeyboardToggle_Landroid_view_View_ZII, __args);
			}

		}

		// event args for com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnKeyBoardListener.onKeyboardToggle
		public partial class KeyBoardEventArgs : global::System.EventArgs {

			public KeyBoardEventArgs (global::Android.Views.View p0, bool p1, int p2, int p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			global::Android.Views.View p0;
			public global::Android.Views.View P0 {
				get { return p0; }
			}

			bool p1;
			public bool P1 {
				get { return p1; }
			}

			int p2;
			public int P2 {
				get { return p2; }
			}

			int p3;
			public int P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup_OnKeyBoardListenerImplementor")]
		internal sealed partial class IOnKeyBoardListenerImplementor : global::Java.Lang.Object, IOnKeyBoardListener {

			object sender;

			public IOnKeyBoardListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup_OnKeyBoardListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<KeyBoardEventArgs> Handler;
#pragma warning restore 0649

			public void OnKeyboardToggle (global::Android.Views.View p0, bool p1, int p2, int p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new KeyBoardEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IOnKeyBoardListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup", typeof (QMUIFullScreenPopup));
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

		protected QMUIFullScreenPopup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/constructor[@name='QMUIFullScreenPopup' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIFullScreenPopup (global::Android.Content.Context context)
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

		static Delegate cb_getCloseBtnId;
#pragma warning disable 0169
		static Delegate GetGetCloseBtnIdHandler ()
		{
			if (cb_getCloseBtnId == null)
				cb_getCloseBtnId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCloseBtnId);
			return cb_getCloseBtnId;
		}

		static int n_GetCloseBtnId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseBtnId;
		}
#pragma warning restore 0169

		public virtual unsafe int CloseBtnId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='getCloseBtnId' and count(parameter)=0]"
			[Register ("getCloseBtnId", "()I", "GetGetCloseBtnIdHandler")]
			get {
				const string __id = "getCloseBtnId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isShowing;
#pragma warning disable 0169
		static Delegate GetIsShowingHandler ()
		{
			if (cb_isShowing == null)
				cb_isShowing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShowing);
			return cb_isShowing;
		}

		static bool n_IsShowing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowing;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsShowing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='isShowing' and count(parameter)=0]"
			[Register ("isShowing", "()Z", "GetIsShowingHandler")]
			get {
				const string __id = "isShowing.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener OffsetHalfKeyboardHeightListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='getOffsetHalfKeyboardHeightListener' and count(parameter)=0]"
			[Register ("getOffsetHalfKeyboardHeightListener", "()Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;", "")]
			get {
				const string __id = "getOffsetHalfKeyboardHeightListener.()Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener OffsetKeyboardHeightListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='getOffsetKeyboardHeightListener' and count(parameter)=0]"
			[Register ("getOffsetKeyboardHeightListener", "()Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;", "")]
			get {
				const string __id = "getOffsetKeyboardHeightListener.()Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetAddView_Landroid_view_View_Handler ()
		{
			if (cb_addView_Landroid_view_View_ == null)
				cb_addView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_AddView_Landroid_view_View_);
			return cb_addView_Landroid_view_View_;
		}

		static IntPtr n_AddView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddView (view));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='addView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("addView", "(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetAddView_Landroid_view_View_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup AddView (global::Android.Views.View view)
		{
			const string __id = "addView.(Landroid/view/View;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetAddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler ()
		{
			if (cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ == null)
				cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_);
			return cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
		}

		static IntPtr n_AddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_lp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var lp = global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (native_lp, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddView (view, lp));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='addView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("addView", "(Landroid/view/View;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetAddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup AddView (global::Android.Views.View view, global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams lp)
		{
			const string __id = "addView.(Landroid/view/View;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (lp);
			}
		}

		static Delegate cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_;
#pragma warning disable 0169
		static Delegate GetAddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_Handler ()
		{
			if (cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ == null)
				cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_AddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_);
			return cb_addView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_;
		}

		static IntPtr n_AddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_lp, IntPtr native_onKeyBoardListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var lp = global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (native_lp, JniHandleOwnership.DoNotTransfer);
			var onKeyBoardListener = (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener> (native_onKeyBoardListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddView (view, lp, onKeyBoardListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='addView' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams'] and parameter[3][@type='com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnKeyBoardListener']]"
		[Register ("addView", "(Landroid/view/View;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetAddView_Landroid_view_View_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup AddView (global::Android.Views.View view, global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams lp, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener onKeyBoardListener)
		{
			const string __id = "addView.(Landroid/view/View;Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				__args [2] = new JniArgumentValue ((onKeyBoardListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onKeyBoardListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (lp);
				global::System.GC.KeepAlive (onKeyBoardListener);
			}
		}

		static Delegate cb_addView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_;
#pragma warning disable 0169
		static Delegate GetAddView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_Handler ()
		{
			if (cb_addView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ == null)
				cb_addView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_);
			return cb_addView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_;
		}

		static IntPtr n_AddView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_onKeyBoardListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			var onKeyBoardListener = (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener> (native_onKeyBoardListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddView (view, onKeyBoardListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='addView' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnKeyBoardListener']]"
		[Register ("addView", "(Landroid/view/View;Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetAddView_Landroid_view_View_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnKeyBoardListener_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup AddView (global::Android.Views.View view, global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnKeyBoardListener onKeyBoardListener)
		{
			const string __id = "addView.(Landroid/view/View;Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnKeyBoardListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((onKeyBoardListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onKeyBoardListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
				global::System.GC.KeepAlive (onKeyBoardListener);
			}
		}

		static Delegate cb_animStyle_I;
#pragma warning disable 0169
		static Delegate GetAnimStyle_IHandler ()
		{
			if (cb_animStyle_I == null)
				cb_animStyle_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_AnimStyle_I);
			return cb_animStyle_I;
		}

		static IntPtr n_AnimStyle_I (IntPtr jnienv, IntPtr native__this, int animStyle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnimStyle (animStyle));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='animStyle' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animStyle", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetAnimStyle_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup AnimStyle (int animStyle)
		{
			const string __id = "animStyle.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (animStyle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_closeBtn_Z;
#pragma warning disable 0169
		static Delegate GetCloseBtn_ZHandler ()
		{
			if (cb_closeBtn_Z == null)
				cb_closeBtn_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_CloseBtn_Z);
			return cb_closeBtn_Z;
		}

		static IntPtr n_CloseBtn_Z (IntPtr jnienv, IntPtr native__this, bool close)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseBtn (close));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='closeBtn' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("closeBtn", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetCloseBtn_ZHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup CloseBtn (bool close)
		{
			const string __id = "closeBtn.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (close);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_closeIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetCloseIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_closeIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_closeIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CloseIcon_Landroid_graphics_drawable_Drawable_);
			return cb_closeIcon_Landroid_graphics_drawable_Drawable_;
		}

		static IntPtr n_CloseIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CloseIcon (drawable));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='closeIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("closeIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetCloseIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup CloseIcon (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "closeIcon.(Landroid/graphics/drawable/Drawable;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (drawable);
			}
		}

		static Delegate cb_closeIconAttr_I;
#pragma warning disable 0169
		static Delegate GetCloseIconAttr_IHandler ()
		{
			if (cb_closeIconAttr_I == null)
				cb_closeIconAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_CloseIconAttr_I);
			return cb_closeIconAttr_I;
		}

		static IntPtr n_CloseIconAttr_I (IntPtr jnienv, IntPtr native__this, int closeIconAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloseIconAttr (closeIconAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='closeIconAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("closeIconAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetCloseIconAttr_IHandler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup CloseIconAttr (int closeIconAttr)
		{
			const string __id = "closeIconAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (closeIconAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_closeLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetCloseLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler ()
		{
			if (cb_closeLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ == null)
				cb_closeLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_CloseLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_);
			return cb_closeLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_;
		}

		static IntPtr n_CloseLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentLayoutParams)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var contentLayoutParams = global::Java.Lang.Object.GetObject<global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams> (native_contentLayoutParams, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CloseLp (contentLayoutParams));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='closeLp' and count(parameter)=1 and parameter[1][@type='androidx.constraintlayout.widget.ConstraintLayout.LayoutParams']]"
		[Register ("closeLp", "(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetCloseLp_Landroidx_constraintlayout_widget_ConstraintLayout_LayoutParams_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup CloseLp (global::AndroidX.ConstraintLayout.Widget.ConstraintLayout.LayoutParams contentLayoutParams)
		{
			const string __id = "closeLp.(Landroidx/constraintlayout/widget/ConstraintLayout$LayoutParams;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((contentLayoutParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) contentLayoutParams).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (contentLayoutParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='getOrCreateViewOffsetHelper' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("getOrCreateViewOffsetHelper", "(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;", "")]
		public static unsafe global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper GetOrCreateViewOffsetHelper (global::Android.Views.View view)
		{
			const string __id = "getOrCreateViewOffsetHelper.(Landroid/view/View;)Lcom/qmuiteam/qmui/util/QMUIViewOffsetHelper;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Util.QMUIViewOffsetHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (view);
			}
		}

		static Delegate cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_;
#pragma warning disable 0169
		static Delegate GetOnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_Handler ()
		{
			if (cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_ == null)
				cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_);
			return cb_onBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_;
		}

		static IntPtr n_OnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onBlankClickListener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var onBlankClickListener = (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnBlankClickListener)global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnBlankClickListener> (native_onBlankClickListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBlankClick (onBlankClickListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='onBlankClick' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.widget.popup.QMUIFullScreenPopup.OnBlankClickListener']]"
		[Register ("onBlankClick", "(Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnBlankClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;", "GetOnBlankClick_Lcom_qmuiteam_qmui_widget_popup_QMUIFullScreenPopup_OnBlankClickListener_Handler")]
		public virtual unsafe global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup OnBlankClick (global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup.IOnBlankClickListener onBlankClickListener)
		{
			const string __id = "onBlankClick.(Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup$OnBlankClickListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIFullScreenPopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onBlankClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onBlankClickListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (onBlankClickListener);
			}
		}

		static Delegate cb_show_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetShow_Landroid_view_View_Handler ()
		{
			if (cb_show_Landroid_view_View_ == null)
				cb_show_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Show_Landroid_view_View_);
			return cb_show_Landroid_view_View_;
		}

		static void n_Show_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIFullScreenPopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.Show (parent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIFullScreenPopup']/method[@name='show' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("show", "(Landroid/view/View;)V", "GetShow_Landroid_view_View_Handler")]
		public virtual unsafe void Show (global::Android.Views.View parent)
		{
			const string __id = "show.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parent);
			}
		}

	}
}
