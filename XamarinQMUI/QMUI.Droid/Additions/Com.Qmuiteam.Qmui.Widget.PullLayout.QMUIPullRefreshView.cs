using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Qmuiteam.Qmui.Widget.PullLayout {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']"
	[global::Android.Runtime.Register ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullRefreshView", DoNotGenerateAcw=true)]
	public partial class QMUIPullRefreshView : global::AndroidX.AppCompat.Widget.AppCompatImageView, global::Com.Qmuiteam.Qmui.Skin.DefaultAttr.IQMUISkinDefaultAttrProvider, global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.IActionPullWatcherView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/qmuiteam/qmui/widget/pullLayout/QMUIPullRefreshView", typeof (QMUIPullRefreshView));
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

		protected QMUIPullRefreshView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/constructor[@name='QMUIPullRefreshView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe QMUIPullRefreshView (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/constructor[@name='QMUIPullRefreshView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe QMUIPullRefreshView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultSkinAttrs);
		}
#pragma warning restore 0169

		public virtual unsafe global::AndroidX.Collection.SimpleArrayMap DefaultSkinAttrs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='getDefaultSkinAttrs' and count(parameter)=0]"
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

		static Delegate cb_doRefresh;
#pragma warning disable 0169
		static Delegate GetDoRefreshHandler ()
		{
			if (cb_doRefresh == null)
				cb_doRefresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DoRefresh);
			return cb_doRefresh;
		}

		static void n_DoRefresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoRefresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='doRefresh' and count(parameter)=0]"
		[Register ("doRefresh", "()V", "GetDoRefreshHandler")]
		public virtual unsafe void DoRefresh ()
		{
			const string __id = "doRefresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onActionFinished;
#pragma warning disable 0169
		static Delegate GetOnActionFinishedHandler ()
		{
			if (cb_onActionFinished == null)
				cb_onActionFinished = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnActionFinished);
			return cb_onActionFinished;
		}

		static void n_OnActionFinished (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionFinished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='onActionFinished' and count(parameter)=0]"
		[Register ("onActionFinished", "()V", "GetOnActionFinishedHandler")]
		public virtual unsafe void OnActionFinished ()
		{
			const string __id = "onActionFinished.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onActionTriggered;
#pragma warning disable 0169
		static Delegate GetOnActionTriggeredHandler ()
		{
			if (cb_onActionTriggered == null)
				cb_onActionTriggered = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnActionTriggered);
			return cb_onActionTriggered;
		}

		static void n_OnActionTriggered (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnActionTriggered ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='onActionTriggered' and count(parameter)=0]"
		[Register ("onActionTriggered", "()V", "GetOnActionTriggeredHandler")]
		public virtual unsafe void OnActionTriggered ()
		{
			const string __id = "onActionTriggered.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
#pragma warning disable 0169
		static Delegate GetOnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler ()
		{
			if (cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I == null)
				cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I);
			return cb_onPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I;
		}

		static void n_OnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_I (IntPtr jnienv, IntPtr native__this, IntPtr native_pullAction, int currentTargetOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pullAction = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction> (native_pullAction, JniHandleOwnership.DoNotTransfer);
			__this.OnPull (pullAction, currentTargetOffset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='onPull' and count(parameter)=2 and parameter[1][@type='com.qmuiteam.qmui.widget.pullLayout.QMUIPullLayout.PullAction'] and parameter[2][@type='int']]"
		[Register ("onPull", "(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V", "GetOnPull_Lcom_qmuiteam_qmui_widget_pullLayout_QMUIPullLayout_PullAction_IHandler")]
		public virtual unsafe void OnPull (global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullLayout.PullAction pullAction, int currentTargetOffset)
		{
			const string __id = "onPull.(Lcom/qmuiteam/qmui/widget/pullLayout/QMUIPullLayout$PullAction;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pullAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pullAction).Handle);
				__args [1] = new JniArgumentValue (currentTargetOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pullAction);
			}
		}

		static Delegate cb_setColorSchemeColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColorSchemeColors_arrayIHandler ()
		{
			if (cb_setColorSchemeColors_arrayI == null)
				cb_setColorSchemeColors_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColorSchemeColors_arrayI);
			return cb_setColorSchemeColors_arrayI;
		}

		static void n_SetColorSchemeColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColorSchemeColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='setColorSchemeColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setColorSchemeColors", "([I)V", "GetSetColorSchemeColors_arrayIHandler")]
		public virtual unsafe void SetColorSchemeColors (params int[] colors)
		{
			const string __id = "setColorSchemeColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setColorSchemeResources_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColorSchemeResources_arrayIHandler ()
		{
			if (cb_setColorSchemeResources_arrayI == null)
				cb_setColorSchemeResources_arrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetColorSchemeResources_arrayI);
			return cb_setColorSchemeResources_arrayI;
		}

		static void n_SetColorSchemeResources_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colorResIds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colorResIds = (int[]) JNIEnv.GetArray (native_colorResIds, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColorSchemeResources (colorResIds);
			if (colorResIds != null)
				JNIEnv.CopyArray (colorResIds, native_colorResIds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='setColorSchemeResources' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setColorSchemeResources", "([I)V", "GetSetColorSchemeResources_arrayIHandler")]
		public virtual unsafe void SetColorSchemeResources (params int[] colorResIds)
		{
			const string __id = "setColorSchemeResources.([I)V";
			IntPtr native_colorResIds = JNIEnv.NewArray (colorResIds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colorResIds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colorResIds != null) {
					JNIEnv.CopyArray (native_colorResIds, colorResIds);
					JNIEnv.DeleteLocalRef (native_colorResIds);
				}
				global::System.GC.KeepAlive (colorResIds);
			}
		}

		static Delegate cb_setSize_I;
#pragma warning disable 0169
		static Delegate GetSetSize_IHandler ()
		{
			if (cb_setSize_I == null)
				cb_setSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSize_I);
			return cb_setSize_I;
		}

		static void n_SetSize_I (IntPtr jnienv, IntPtr native__this, int size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSize (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSize", "(I)V", "GetSetSize_IHandler")]
		public virtual unsafe void SetSize (int size)
		{
			const string __id = "setSize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Qmuiteam.Qmui.Widget.PullLayout.QMUIPullRefreshView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.qmuiteam.qmui.widget.pullLayout']/class[@name='QMUIPullRefreshView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
