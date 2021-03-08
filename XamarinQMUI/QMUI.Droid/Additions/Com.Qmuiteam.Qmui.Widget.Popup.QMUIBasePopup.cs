using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.Popup {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIBasePopup", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.qmuiteam.qmui.widget.popup.QMUIBasePopup"})]
	public abstract partial class QMUIBasePopup : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='DIM_AMOUNT_NOT_EXIST']"
		[Register ("DIM_AMOUNT_NOT_EXIST")]
		public const float DimAmountNotExist = (float) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public const int NotSet = (int) -1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='mAttachedViewRf']"
		[Register ("mAttachedViewRf")]
		protected global::Java.Lang.Ref.WeakReference MAttachedViewRf {
			get {
				const string __id = "mAttachedViewRf.Ljava/lang/ref/WeakReference;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAttachedViewRf.Ljava/lang/ref/WeakReference;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='mWindow']"
		[Register ("mWindow")]
		protected global::Android.Widget.PopupWindow MWindow {
			get {
				const string __id = "mWindow.Landroid/widget/PopupWindow;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.PopupWindow> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mWindow.Landroid/widget/PopupWindow;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/field[@name='mWindowManager']"
		[Register ("mWindowManager")]
		protected global::Android.Views.IWindowManager MWindowManager {
			get {
				const string __id = "mWindowManager.Landroid/view/WindowManager;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.IWindowManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mWindowManager.Landroid/view/WindowManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIBasePopup", typeof (QMUIBasePopup));
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

		protected QMUIBasePopup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/constructor[@name='QMUIBasePopup' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIBasePopup (global::Android.Content.Context context)
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

		static Delegate cb_getDecorView;
#pragma warning disable 0169
		static Delegate GetGetDecorViewHandler ()
		{
			if (cb_getDecorView == null)
				cb_getDecorView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDecorView);
			return cb_getDecorView;
		}

		static IntPtr n_GetDecorView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DecorView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View DecorView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='getDecorView' and count(parameter)=0]"
			[Register ("getDecorView", "()Landroid/view/View;", "GetGetDecorViewHandler")]
			get {
				const string __id = "getDecorView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSkinManager;
#pragma warning disable 0169
		static Delegate GetGetSkinManagerHandler ()
		{
			if (cb_getSkinManager == null)
				cb_getSkinManager = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSkinManager);
			return cb_getSkinManager;
		}

		static IntPtr n_GetSkinManager (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SkinManager);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager SkinManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='getSkinManager' and count(parameter)=0]"
			[Register ("getSkinManager", "()Lcom/qmuiteam/qmui/skin/QMUISkinManager;", "GetGetSkinManagerHandler")]
			get {
				const string __id = "getSkinManager.()Lcom/qmuiteam/qmui/skin/QMUISkinManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_dimAmount_F;
#pragma warning disable 0169
		static Delegate GetDimAmount_FHandler ()
		{
			if (cb_dimAmount_F == null)
				cb_dimAmount_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_L) n_DimAmount_F);
			return cb_dimAmount_F;
		}

		static IntPtr n_DimAmount_F (IntPtr jnienv, IntPtr native__this, float dimAmount)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DimAmount (dimAmount));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='dimAmount' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("dimAmount", "(F)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetDimAmount_FHandler")]
		public virtual unsafe global::Java.Lang.Object DimAmount (float dimAmount)
		{
			const string __id = "dimAmount.(F)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dimAmount);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dimAmountAttr_I;
#pragma warning disable 0169
		static Delegate GetDimAmountAttr_IHandler ()
		{
			if (cb_dimAmountAttr_I == null)
				cb_dimAmountAttr_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_DimAmountAttr_I);
			return cb_dimAmountAttr_I;
		}

		static IntPtr n_DimAmountAttr_I (IntPtr jnienv, IntPtr native__this, int dimAmountAttr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DimAmountAttr (dimAmountAttr));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='dimAmountAttr' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dimAmountAttr", "(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetDimAmountAttr_IHandler")]
		public virtual unsafe global::Java.Lang.Object DimAmountAttr (int dimAmountAttr)
		{
			const string __id = "dimAmountAttr.(I)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dimAmountAttr);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='dismiss' and count(parameter)=0]"
		[Register ("dismiss", "()V", "")]
		public unsafe void Dismiss ()
		{
			const string __id = "dismiss.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dismissIfOutsideTouch_Z;
#pragma warning disable 0169
		static Delegate GetDismissIfOutsideTouch_ZHandler ()
		{
			if (cb_dismissIfOutsideTouch_Z == null)
				cb_dismissIfOutsideTouch_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_DismissIfOutsideTouch_Z);
			return cb_dismissIfOutsideTouch_Z;
		}

		static IntPtr n_DismissIfOutsideTouch_Z (IntPtr jnienv, IntPtr native__this, bool dismissIfOutsideTouch)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DismissIfOutsideTouch (dismissIfOutsideTouch));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='dismissIfOutsideTouch' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("dismissIfOutsideTouch", "(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetDismissIfOutsideTouch_ZHandler")]
		public virtual unsafe global::Java.Lang.Object DismissIfOutsideTouch (bool dismissIfOutsideTouch)
		{
			const string __id = "dismissIfOutsideTouch.(Z)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dismissIfOutsideTouch);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_modifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_;
#pragma warning disable 0169
		static Delegate GetModifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_Handler ()
		{
			if (cb_modifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_ == null)
				cb_modifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ModifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_);
			return cb_modifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_;
		}

		static void n_ModifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lp = global::Java.Lang.Object.GetObject<global::Android.Views.WindowManagerLayoutParams> (native_lp, JniHandleOwnership.DoNotTransfer);
			__this.ModifyWindowLayoutParams (lp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='modifyWindowLayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.WindowManager.LayoutParams']]"
		[Register ("modifyWindowLayoutParams", "(Landroid/view/WindowManager$LayoutParams;)V", "GetModifyWindowLayoutParams_Landroid_view_WindowManager_LayoutParams_Handler")]
		protected virtual unsafe void ModifyWindowLayoutParams (global::Android.Views.WindowManagerLayoutParams lp)
		{
			const string __id = "modifyWindowLayoutParams.(Landroid/view/WindowManager$LayoutParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (lp);
			}
		}

		static Delegate cb_onDismiss;
#pragma warning disable 0169
		static Delegate GetOnDismissHandler ()
		{
			if (cb_onDismiss == null)
				cb_onDismiss = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDismiss);
			return cb_onDismiss;
		}

		static void n_OnDismiss (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDismiss ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='onDismiss' and count(parameter)=0]"
		[Register ("onDismiss", "()V", "GetOnDismissHandler")]
		protected virtual unsafe void OnDismiss ()
		{
			const string __id = "onDismiss.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDismiss_Landroid_widget_PopupWindow_OnDismissListener_;
#pragma warning disable 0169
		static Delegate GetOnDismiss_Landroid_widget_PopupWindow_OnDismissListener_Handler ()
		{
			if (cb_onDismiss_Landroid_widget_PopupWindow_OnDismissListener_ == null)
				cb_onDismiss_Landroid_widget_PopupWindow_OnDismissListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnDismiss_Landroid_widget_PopupWindow_OnDismissListener_);
			return cb_onDismiss_Landroid_widget_PopupWindow_OnDismissListener_;
		}

		static IntPtr n_OnDismiss_Landroid_widget_PopupWindow_OnDismissListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var listener = (global::Android.Widget.PopupWindow.IOnDismissListener)global::Java.Lang.Object.GetObject<global::Android.Widget.PopupWindow.IOnDismissListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnDismiss (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='onDismiss' and count(parameter)=1 and parameter[1][@type='android.widget.PopupWindow.OnDismissListener']]"
		[Register ("onDismiss", "(Landroid/widget/PopupWindow$OnDismissListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetOnDismiss_Landroid_widget_PopupWindow_OnDismissListener_Handler")]
		public virtual unsafe global::Java.Lang.Object OnDismiss (global::Android.Widget.PopupWindow.IOnDismissListener listener)
		{
			const string __id = "onDismiss.(Landroid/widget/PopupWindow$OnDismissListener;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (listener);
			}
		}

		static Delegate cb_onSkinChange_II;
#pragma warning disable 0169
		static Delegate GetOnSkinChange_IIHandler ()
		{
			if (cb_onSkinChange_II == null)
				cb_onSkinChange_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnSkinChange_II);
			return cb_onSkinChange_II;
		}

		static void n_OnSkinChange_II (IntPtr jnienv, IntPtr native__this, int oldSkin, int newSkin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSkinChange (oldSkin, newSkin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='onSkinChange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSkinChange", "(II)V", "GetOnSkinChange_IIHandler")]
		protected virtual unsafe void OnSkinChange (int oldSkin, int newSkin)
		{
			const string __id = "onSkinChange.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (oldSkin);
				__args [1] = new JniArgumentValue (newSkin);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showAtLocation_Landroid_view_View_II;
#pragma warning disable 0169
		static Delegate GetShowAtLocation_Landroid_view_View_IIHandler ()
		{
			if (cb_showAtLocation_Landroid_view_View_II == null)
				cb_showAtLocation_Landroid_view_View_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_ShowAtLocation_Landroid_view_View_II);
			return cb_showAtLocation_Landroid_view_View_II;
		}

		static void n_ShowAtLocation_Landroid_view_View_II (IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int x, int y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parent = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_parent, JniHandleOwnership.DoNotTransfer);
			__this.ShowAtLocation (parent, x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='showAtLocation' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("showAtLocation", "(Landroid/view/View;II)V", "GetShowAtLocation_Landroid_view_View_IIHandler")]
		protected virtual unsafe void ShowAtLocation (global::Android.Views.View parent, int x, int y)
		{
			const string __id = "showAtLocation.(Landroid/view/View;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (parent);
			}
		}

		static Delegate cb_skinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
#pragma warning disable 0169
		static Delegate GetInvokeSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler ()
		{
			if (cb_skinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ == null)
				cb_skinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_InvokeSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_);
			return cb_skinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_;
		}

		static IntPtr n_InvokeSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_skinManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.Popup.QMUIBasePopup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var skinManager = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager> (native_skinManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeSkinManager (skinManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.popup']/class[@name='QMUIBasePopup']/method[@name='skinManager' and count(parameter)=1 and parameter[1][@type='com.qmuiteam.qmui.skin.QMUISkinManager']]"
		[Register ("skinManager", "(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;", "GetInvokeSkinManager_Lcom_qmuiteam_qmui_skin_QMUISkinManager_Handler")]
		public virtual unsafe global::Java.Lang.Object InvokeSkinManager (global::Com.Qmuiteam.Qmui.Skin.QMUISkinManager skinManager)
		{
			const string __id = "skinManager.(Lcom/qmuiteam/qmui/skin/QMUISkinManager;)Lcom/qmuiteam/qmui/widget/popup/QMUIBasePopup;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((skinManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) skinManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (skinManager);
			}
		}

	}

	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/popup/QMUIBasePopup", DoNotGenerateAcw=true)]
	internal partial class QMUIBasePopupInvoker : QMUIBasePopup {

		public QMUIBasePopupInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/popup/QMUIBasePopup", typeof (QMUIBasePopupInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
